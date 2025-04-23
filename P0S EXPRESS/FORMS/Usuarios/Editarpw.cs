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
using static P0S_EXPRESS.FORMS.Usuarios.EditarUsuario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P0S_EXPRESS.FORMS.Usuarios
{
    public partial class Editarpw : Form
    {
        private int idusuario;
        public Editarpw()
        {
            InitializeComponent();
        }

        public Editarpw(int id)
        {
            InitializeComponent();
            idusuario = id;
        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string contraseña = PW.Text.Trim();
            byte[] hash = HashPassword(contraseña);

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = @"update Usuario 
                                   SET CONTRASENIA = @contraseña 
                                   WHERE Id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@contraseña", hash);
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


        public static byte[] HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
