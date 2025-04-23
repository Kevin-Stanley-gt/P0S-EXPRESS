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
using static P0S_EXPRESS.FORMS.Usuarios.EditarUsuario;

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
                string query = @"select a.Id, a.Rol_Id, b.Nombres as Rol , a.Nombres, a.Apellidos, USUARIO as Usuario,a.Direccion, COALESCE (CUI, '') AS CUI, a.activo 
                                from usuario a inner join Roles b on b.Id= a.Rol_Id 
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

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                int rol_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Rol_Id"].Value);
                string rol = dataGridView1.SelectedRows[0].Cells["Rol"].Value.ToString();
                string Nombre = dataGridView1.SelectedRows[0].Cells["Nombres"].Value.ToString();
                string apellidos = dataGridView1.SelectedRows[0].Cells["Apellidos"].Value.ToString();
                string direccion = dataGridView1.SelectedRows[0].Cells["Direccion"].Value.ToString();
                string usuario = dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString();
                string cui = dataGridView1.SelectedRows[0].Cells["CUI"].Value.ToString();
                var Activo = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Activo"].Value);
                EditarUsuario frmeditar = new EditarUsuario(id, rol_id, rol, Nombre, apellidos,usuario,cui, direccion, Activo);
                frmeditar.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Seleccionar un Usuario de la lista");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                Editarpw frmeditar = new Editarpw(id);
                frmeditar.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Seleccionar un Usuario de la lista");
            }
        }
    }
}
