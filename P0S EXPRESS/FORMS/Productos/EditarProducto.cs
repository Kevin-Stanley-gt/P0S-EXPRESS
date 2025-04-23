using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P0S_EXPRESS.FORMS.Productos
{
    public partial class EditarProducto : Form
    {
        private int idProd;
        private int idProveedor;
        public EditarProducto()
        {
            InitializeComponent();
        }


        public EditarProducto(int id, int Proveedor_Id, string Proveedor, string Nombre, string Descripcion,string Costo, bool Activo)
        {
            InitializeComponent();
            idProd = id;
            idProveedor = Proveedor_Id;

            txtNombre.Text = Nombre;
            txtdescripcion.Text = Descripcion;
            txtCosto.Text = Costo;
            checkBox1.Checked = Activo;
            this.Load += new EventHandler(Editar_Producto_Load);
            TxtProvee.Text = Proveedor;
        }

        public class Moneda
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Mostrar solo el nombre en el ComboBox
            }
        }

        private void Editar_Producto_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "select Id, Nombre from Proveedores";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Moneda moneda = new Moneda
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };

                        TxtProvee.Items.Add(moneda);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar monedas: " + ex.Message);
                }
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MENU1().Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            string costo = txtCosto.Text.Trim();
            var activo = checkBox1.Checked ;
            int IdProveedor = ((Moneda)TxtProvee.SelectedItem)?.Id ?? 0;

            if (IdProveedor == 0)
            {
                MessageBox.Show("Debe seleccionar una moneda.");
                return;
            }



            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Proveedores 
                                 SET Nombre = @nombre, 
                                     Direccion = @direccion, 
                                     Telefono = @telefono, 
                                     Razon_Social = @razon, 
                                     Moneda_Id = @moneda 
                                 WHERE Id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@direccion", descripcion);
                    cmd.Parameters.AddWithValue("@telefono", costo);
                    cmd.Parameters.AddWithValue("@razon", activo);
                    cmd.Parameters.AddWithValue("@moneda", IdProveedor);
                    cmd.Parameters.AddWithValue("@id", idProd);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Proveedor actualizado correctamente.");
                        this.Close();
                        new Proveedoress().Show();


                    }
                    else
                    {
                        MessageBox.Show("No se actualizó el proveedor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }


            }
        }
    }
}
