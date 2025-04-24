using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace P0S_EXPRESS.FORMS
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();

            this.Load += new EventHandler(ProveedorCargar);
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            dataGridView1.Columns.Add("ProductoId", "ID");
            dataGridView1.Columns["ProductoId"].Visible = false;
            dataGridView1.Columns.Add("Nombre", "Nombre del Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Total", "Total");
        }

        public class Proveedor
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre;
            }
        }

        public class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre;
            }
        }

        private void ProveedorCargar(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre FROM Proveedores";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Proveedor proveedor = new Proveedor
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };

                        comboBox1.Items.Add(proveedor);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar Proveedor: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem is Proveedor proveedorSeleccionado)
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT Id, Nombre FROM Producto WHERE Proveedor_Id = @ProveedorId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ProveedorId", proveedorSeleccionado.Id);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Producto producto = new Producto
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1)
                            };

                            comboBox2.Items.Add(producto);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar productos del proveedor: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtCantidad.Text) || !int.TryParse(TxtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text) || !decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            


            var productoSeleccionado = (Producto)comboBox2.SelectedItem;
            int productoId = productoSeleccionado.Id;
            string nombreProducto = productoSeleccionado.Nombre;
            decimal total = cantidad * precio;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductoId"].Value?.ToString() == productoId.ToString())
                {
                    MessageBox.Show("Este producto ya ha sido agregado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox2.SelectedIndex = -1;
                    TxtCantidad.Clear();
                    txtPrecio.Clear();
                    return;
                }
            }
            dataGridView1.Rows.Add(productoId, nombreProducto, cantidad, precio, total);

            
            comboBox2.SelectedIndex = -1;
            TxtCantidad.Clear();
            txtPrecio.Clear();



        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace (txtnumero.Text))
            {
                MessageBox.Show("Ingrese Numero de Factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtserie.Text))
            {
                MessageBox.Show("Ingrese Numero de Factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Proveedor proveedorSeleccionado = (Proveedor)comboBox1.SelectedItem;

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                SqlTransaction transaction = null;

                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    
                    string insertEncabezado = @"INSERT INTO Compra_Encabezado (numero, serie,ProveedorId, Fecha)
                                        OUTPUT INSERTED.Id
                                        VALUES (@numero, @serie, @ProveedorId, @Fecha)";
                    SqlCommand cmdEncabezado = new SqlCommand(insertEncabezado, conn, transaction);
                    cmdEncabezado.Parameters.AddWithValue("@ProveedorId", proveedorSeleccionado.Id);
                    cmdEncabezado.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmdEncabezado.Parameters.AddWithValue("@numero", txtnumero.Text);
                    cmdEncabezado.Parameters.AddWithValue("@serie", txtserie.Text);

                    long compraId = (long)cmdEncabezado.ExecuteScalar();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue; 

                        if (!int.TryParse(row.Cells["ProductoId"].Value?.ToString(), out int productoId))
                            throw new Exception($"ProductoId inválido en fila {row.Index + 1}");

                        if (!int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out int cantidad))
                            throw new Exception($"Cantidad inválida en fila {row.Index + 1}");

                        if (!decimal.TryParse(row.Cells["Precio"].Value?.ToString(), out decimal precio))
                            throw new Exception($"Precio inválido en fila {row.Index + 1}");

                        string insertDetalle = @"INSERT INTO Compra_Detalle (Compra_Id, Producto_Id, Cantidad, Precio)
                                         VALUES (@CompraId, @ProductoId, @Cantidad, @Precio)";

                        SqlCommand cmdDetalle = new SqlCommand(insertDetalle, conn, transaction);
                        cmdDetalle.Parameters.AddWithValue("@CompraId", compraId);
                        cmdDetalle.Parameters.AddWithValue("@ProductoId", productoId);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmdDetalle.Parameters.AddWithValue("@Precio", precio);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Compra registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    dataGridView1.Rows.Clear();
                    comboBox1.SelectedIndex = -1;
                    comboBox2.Items.Clear();
                    TxtCantidad.Clear();
                    txtPrecio.Clear();
                    txtnumero.Clear();
                    txtserie.Clear();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Error al registrar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MENU1().Show();
        }

        private void txteliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    if (!fila.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(fila);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
