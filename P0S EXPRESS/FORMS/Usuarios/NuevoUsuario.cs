using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static P0S_EXPRESS.FORMS.Productos.NuevoProducto;

namespace P0S_EXPRESS.FORMS.Usuarios
{
    public partial class UserNew : Form
    {
        public UserNew()
        {
            InitializeComponent();
            this.Load += new EventHandler(RolesLoad);

        }

        public class Roles_Load
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Mostrar solo el nombre en el ComboBox
            }
        }

        private void RolesLoad(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = "select id, Nombres from roles";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Roles_Load RolesL = new Roles_Load
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };

                        txtrol.Items.Add(RolesL);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar Roles: " + ex.Message);
                }
            }
        }


        private void Atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserNew().Show();
        }

        public static byte[] HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellidos = txtapellidos.Text.Trim();
            string contraseña = txtcontra.Text.Trim();
            string direccion = txtdireccion.Text.Trim();
            string CUI = TXTCUI.Text.Trim();
            string Usuario = txtusuario.Text.Trim();
            byte[] hash = HashPassword(contraseña);

            var Rollselecionado = txtrol.SelectedItem as Roles_Load;
            bool activo = checkBox1.Checked;
            if (Rollselecionado == null)
            {
                MessageBox.Show("Por favor, selecciona un Roll.");
                return;
            }

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"insert into Usuario (Nombres, Apellidos,Direccion,CUI,USUARIO ,  CONTRASENIA, Rol_Id, activo ,Creado_El)
                                 VALUES (@nombre, @apellidos, @direccion, @cui,@usuario, @contraseña, @roll, @activo, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellidos", apellidos);
                cmd.Parameters.AddWithValue("@contraseña", hash);
                cmd.Parameters.AddWithValue("@roll", Rollselecionado.Id);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@cui", CUI);
                cmd.Parameters.AddWithValue("@usuario", Usuario);
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
            txtdireccion.Clear();
            TXTCUI.Clear();
            txtapellidos.Clear();
            txtusuario.Clear();
            txtcontra.Clear();
            txtrol.SelectedIndex = -1;
            checkBox1.Checked = false;
        }

        private void UserNew_Load(object sender, EventArgs e)
        {

        }
    }
}
