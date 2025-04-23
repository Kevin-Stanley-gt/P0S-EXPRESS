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

namespace P0S_EXPRESS.FORMS.Usuarios
{
    public partial class EditarUsuario : Form
    {
        private int idusuario;
        private int idrol;
        public EditarUsuario()
        {
            InitializeComponent();

        }

        public EditarUsuario(int id, int Rol_id, string Rol, string Nombre, string Apellidos, string usuario, string CUI, string direccion, bool Activo)
        {
            InitializeComponent();
            idusuario = id;
            idrol = Rol_id;

            txtNombre.Text = Nombre;
            txtapellidos.Text = Apellidos;
            txtusuario.Text = usuario;
            TXTCUI.Text = CUI;
            checkBox1.Checked = Activo;
            this.Load += new EventHandler(Editar_Rol);
            txtdireccion.Text = direccion;
        }

        public class rol
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Mostrar solo el nombre en el ComboBox
            }
        }


        private void Editar_Rol(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nombres FROM Roles", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rol r = new rol
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1)
                    };

                    txtrol.Items.Add(r);
                }

                reader.Close();

                // Establece el valor seleccionado
                foreach (rol r in txtrol.Items)
                {
                    if (r.Id == idrol)
                    {
                        txtrol.SelectedItem = r;
                        break;
                    }
                }
            }
        }



        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Usuarioss().Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellidos = txtapellidos.Text.Trim();
            string direccion = txtdireccion.Text.Trim();
            string CUI = TXTCUI.Text.Trim();
            string usuario = txtusuario.Text.Trim();
            var activo = checkBox1.Checked;
            int idrol = ((rol)txtrol.SelectedItem)?.Id ?? 0;

            if (idrol == 0)
            {
                MessageBox.Show("Debe seleccionar una Rol.");
                return;
            }



            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = @"update Usuario 
                                     SET Nombres = @nombre, 
                                     apellidos = @apellidos, 
                                     direccion = @direccion, 
                                     cui = @cui, 
                                     usuario = @usuario,
                                     Rol_Id = @rol,
                                     activo = @activo
                                 WHERE Id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@cui", CUI);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@rol", idrol);
                    cmd.Parameters.AddWithValue("@activo", activo);
                    cmd.Parameters.AddWithValue("@id", idusuario);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Usuario actualizado correctamente.");
                        this.Close();
                        new Usuarioss().Show();


                    }
                    else
                    {
                        MessageBox.Show("No se actualizó el usuario.");
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
