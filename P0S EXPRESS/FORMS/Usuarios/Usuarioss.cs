using P0S_EXPRESS.FORMS.Productos;
using P0S_EXPRESS.FORMS.Usuarios;
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
    public partial class Usuarioss : Form
    {
        public Usuarioss()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MENU1().Show();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string Usuario = txtusuario.Text.Trim();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"select a.Id, a.Rol_Id, b.Nombres as Rol , a.Nombres, a.Apellidos, a.Direccion, a.Nacionalidad, a.activo from usuario a
                                inner join Roles b on b.Id= a.Rol_Id 
                                where CONCAT (a.Nombres, ' ', a.Apellidos) like @Usuario ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", "%" + Usuario + "%");

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.Columns["Rol_Id"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar Usuario: " + ex.Message);
                }
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserNew().Show();
        }
    }
}
