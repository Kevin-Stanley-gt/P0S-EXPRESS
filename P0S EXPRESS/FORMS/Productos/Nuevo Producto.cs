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
    public partial class NuevoProducto : Form
    {
        public NuevoProducto()
        {
            InitializeComponent();
            this.Load += new EventHandler(Nuevo_Proveedor_Load);

        }

        public class Provee
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Mostrar solo el nombre en el ComboBox
            }
        }

        private void Nuevo_Proveedor_Load(object sender, EventArgs e)
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
                        Provee proveedor = new Provee
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };

                        TxtProvee.Items.Add(proveedor);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar Proveedores: " + ex.Message);
                }
            }
        }


        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Producto().Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = txtdescripcion.Text.Trim();
            string Costo = txtCosto.Text.Trim();

            var ProveedorSeleccionado = TxtProvee.SelectedItem as Provee;
            bool activo = checkBox1.Checked;
            if (ProveedorSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona una Proveedor.");
                return;
            }

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"insert into Producto (Nombre, Descripcion, Costo, Proveedor_Id, Activo, Creado_El )  
                                 VALUES (@nombre, @descripcion, @costo, @proveedor, @activo, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@costo", Costo);
                cmd.Parameters.AddWithValue("@proveedor", ProveedorSeleccionado.Id);
                cmd.Parameters.AddWithValue("@activo", activo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado correctamente.");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar Producto: " + ex.Message);
                }
            }

        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtdescripcion.Clear();
            txtCosto.Clear();
            TxtProvee.SelectedIndex = -1;
            checkBox1.Checked = false;
        }
    }
}
