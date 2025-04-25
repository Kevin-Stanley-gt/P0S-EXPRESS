using P0S_EXPRESS.FORMS.Compras;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P0S_EXPRESS.FORMS
{
    public partial class MENU2 : Form
    {
        public MENU2()
        {
            InitializeComponent();
            this.Load += new EventHandler(ClientesCarga);
            this.Load += new EventHandler(ProductoCarga);

        }

        public class producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre;
            }
        }
        public class cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public string Nit {  get; set; }

            public override string ToString()
            {
                return Nombre;
            }
        }

        private void ClientesCarga(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre, Nit FROM CLIENTES";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cliente CLIENTES = new cliente
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Nit = reader.GetString(2)
                        };

                        boxcliente.Items.Add(CLIENTES);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar Cliente: " + ex.Message);
                }
            }
        }

        private void ProductoCarga(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, Nombre FROM Producto";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        producto PRODUCTO = new producto
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };

                        boxarticulo.Items.Add(PRODUCTO);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar Producto: " + ex.Message);
                }
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
            new MENU1().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            new ClienteNuevo().Show();
        }
    }
}
