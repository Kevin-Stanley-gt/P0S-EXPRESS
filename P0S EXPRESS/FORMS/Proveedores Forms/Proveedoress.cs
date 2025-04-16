using P0S_EXPRESS.FORMS.Proveedores;
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

namespace P0S_EXPRESS.FORMS
{
    public partial class Proveedoress : Form
    {
        public Proveedoress()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string proveedor = txtprov.Text.Trim();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT Id, Nombre, Direccion, Telefono, Razon_Social 
                         FROM Proveedores 
                         WHERE Nombre LIKE @proveedor";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@proveedor", "%" + proveedor + "%");

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar proveedor: " + ex.Message);
                }
            }

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Nuevo_Proveedor().Show();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                string nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string direccion = dataGridView1.SelectedRows[0].Cells["Direccion"].Value.ToString();
                string telefono = dataGridView1.SelectedRows[0].Cells["Telefono"].Value.ToString();
                string Razon = dataGridView1.SelectedRows[0].Cells["Razon_Social"].Value.ToString();
                EditarProvee frmeditar = new EditarProvee(id, nombre, direccion, telefono, Razon);
                frmeditar.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Seleccionar un Proveedor de la lista");
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MENU1().Show();
        }
    }
}
