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

namespace P0S_EXPRESS.FORMS.Proveedores
{
    public partial class EditarProvee : Form
    {
        private int proveedorId;
        public EditarProvee( int id, string nombre, string direccion,string telefono, string razon)
        {
            InitializeComponent();
            proveedorId = id;
            txtNombre.Text = nombre;
            txtdireccion.Text = direccion;
            txttel.Text = telefono;
            txtRazon.Text = razon;
            this.Load += new EventHandler(Editar_Proveedor_Load);

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

        private void Editar_Proveedor_Load(object sender, EventArgs e)
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

        private void Actualizar_clic(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtdireccion.Text.Trim();
            string telefono = txttel.Text.Trim();
            string razon = txtRazon.Text.Trim();
            int monedaId = ((Moneda)txtmoneda.SelectedItem)?.Id ?? 0;

            if (monedaId == 0)
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
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@razon", razon);
                    cmd.Parameters.AddWithValue("@moneda", monedaId);
                    cmd.Parameters.AddWithValue("@id", proveedorId);

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

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Close();
            new Proveedoress().Show();
        }
    }
}
