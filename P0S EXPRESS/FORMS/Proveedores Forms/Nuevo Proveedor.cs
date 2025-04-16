using P0S_EXPRESS.CLASES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace P0S_EXPRESS.FORMS
{
    public partial class Nuevo_Proveedor : Form
    {
        public Nuevo_Proveedor()
        {
            InitializeComponent();
            this.Load += new EventHandler(Nuevo_Proveedor_Load);
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

        private void Nuevo_Proveedor_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre FROM Monedas";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Moneda moneda = new Moneda
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };

                        txtmoneda.Items.Add(moneda);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar monedas: " + ex.Message);
                }
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtdireccion.Text.Trim();
            string telefono = txttel.Text.Trim();
            string razon = txtRazon.Text.Trim();

            var monedaSeleccionada = txtmoneda.SelectedItem as Moneda;
            if (monedaSeleccionada == null)
            {
                MessageBox.Show("Por favor, selecciona una moneda.");
                return;
            }

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Proveedores (Nombre, Direccion, Telefono, Razon_Social, Moneda_Id, Creado_El) 
                                 VALUES (@nombre, @direccion, @tel, @razon, @moneda, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@tel", telefono);
                cmd.Parameters.AddWithValue("@razon", razon);
                cmd.Parameters.AddWithValue("@moneda", monedaSeleccionada.Id);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor agregado correctamente.");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar proveedor: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtdireccion.Clear();
            txttel.Clear();
            txtRazon.Clear();
            txtmoneda.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Proveedoress().Show();

        }
    }
}
