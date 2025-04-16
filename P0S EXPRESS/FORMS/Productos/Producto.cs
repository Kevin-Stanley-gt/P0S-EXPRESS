using P0S_EXPRESS.FORMS.Productos;
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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string Producto = TxtProducto.Text.Trim();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"select a.Id, Proveedor_Id ,b.Nombre as Proveedor , a.Nombre, a.Descripcion, a.Costo, a.CostoPromedio, a.Activo , a.Creado_El from Producto a
                inner join Proveedores b on b.Id= a.Proveedor_Id where a.Nombre like @Producto ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Producto", "%" + Producto + "%");

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["Proveedor_Id"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar Producto: " + ex.Message);
                }
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NuevoProducto().Show();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MENU1().Show();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                int Proveedor_Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Proveedor_Id"].Value);
                string Proveedor = dataGridView1.SelectedRows[0].Cells["Proveedor"].Value.ToString();
                string Nombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string Descripcion = dataGridView1.SelectedRows[0].Cells["Descripcion"].Value.ToString();
                string Costo = dataGridView1.SelectedRows[0].Cells["Costo"].Value.ToString();
                var Activo = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Activo"].Value) ;
                EditarProducto frmeditar = new EditarProducto (id, Proveedor_Id, Proveedor, Nombre, Descripcion, Costo, Activo);
                frmeditar.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Seleccionar un Producto de la lista");
            }


        }
    }
}
