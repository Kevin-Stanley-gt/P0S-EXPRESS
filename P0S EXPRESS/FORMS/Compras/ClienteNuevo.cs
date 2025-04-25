using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P0S_EXPRESS.FORMS.Compras
{
    public partial class ClienteNuevo : Form
    {
        public ClienteNuevo()
        {
            InitializeComponent();
            this.Load += new EventHandler(TipoLoad);

        }

        public class TipoC
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Mostrar solo el nombre en el ComboBox
            }
        }

        private void TipoLoad(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "select id,Descripcion from TipoCliente  where activo =1";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TipoC tipo = new TipoC
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };

                        txttipo.Items.Add(tipo);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar Tipo Cliente: " + ex.Message);
                }
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this .Hide();
            new MENU2().Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellidos = txtapellidos.Text.Trim();
            string nit = TxtNit.Text.Trim();
            string direccion = Txtdireccion.Text.Trim();
            string correo = Txtcorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace (txtNombre.Text) )
            {
                MessageBox.Show("Por favor, Ingresar Nombres .");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtapellidos.Text))
            {
                MessageBox.Show("Por favor, Ingresar Apellidos .");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtNit.Text))
            {
                MessageBox.Show("Por favor, Ingresar el Nit del Cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtNit.Text) || TxtNit.Text.Length < 8 || TxtNit.Text.Length > 10 || !TxtNit.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, valide la informacion del NIT.");
                return;
            }


            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"insert into Clientes (Nombre, Nit, Direccion, Correo, Creado_El, Activo )
                                 VALUES (concat (@nombre, ' ', @apellidos), @nit, @direccion ,@correo, GETDATE(), 1)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidos", apellidos);
                cmd.Parameters.AddWithValue("@nit", nit);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@correo", correo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente agregado correctamente.");
                    this.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar Cliente: " + ex.Message);
                }
            }

        }
    }
}
