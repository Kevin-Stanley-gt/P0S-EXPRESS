using System.Data.SqlClient;

public static class JornadaService
{
    public static bool TieneJornadaAbierta(int idCajero)
    {
        using (SqlConnection conn = Conexion.ObtenerConexion())
        {
            string query = "SELECT COUNT(*) FROM Jornada WHERE Cajero = @id AND Estado = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idCajero);

            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
    }

    public static void CrearJornada(int idCajero, decimal monto)
    {
        using (SqlConnection conn = Conexion.ObtenerConexion())
        {
            string query = @"INSERT INTO Jornada (Cajero, FechaApertura, TotalUsuario, Estado)
                             VALUES (@id, GETDATE(), @monto, 1)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idCajero);
            cmd.Parameters.AddWithValue("@monto", monto);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
