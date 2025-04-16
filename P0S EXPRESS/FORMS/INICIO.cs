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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P0S_EXPRESS.FORMS
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = USER.Text.Trim();
            string contrasenia = PW.Text.Trim();

            byte[] hash = HashPassword(contrasenia);

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT ID, USUARIO, Rol_Id 
                         FROM Usuario 
                         WHERE USUARIO = @usuario AND CONTRASENIA = @contrasenia AND activo = 1";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasenia", hash);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Guardamos los datos del usuario en sesión
                    SesionUsuario.Id = reader.GetInt32(0);
                    SesionUsuario.Usuario = reader.GetString(1);
                    SesionUsuario.RolId = reader.GetInt32(2);
                    conn.Close();

                    // Si el rol es administrador o supervisor (rol 1 o 2)
                    if (SesionUsuario.RolId == 1 || SesionUsuario.RolId == 2)
                    {
                        this.Hide();
                        new MENU1().Show();
                    }
                    // Si el rol es cajero (rol 3)
                    else if (SesionUsuario.RolId == 3)
                    {
                        bool tieneJornada = JornadaService.TieneJornadaAbierta(SesionUsuario.Id);

                        if (!tieneJornada)
                        {
                            using (var formApertura = new AperturaCaja())
                            {
                                if (formApertura.ShowDialog() == DialogResult.OK)
                                {
                                    decimal monto = formApertura.MontoApertura;
                                    JornadaService.CrearJornada(SesionUsuario.Id, monto);
                                }
                                else
                                {
                                    MessageBox.Show("Debe aperturar caja para continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }

                        this.Hide();
                        new MENU2().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
