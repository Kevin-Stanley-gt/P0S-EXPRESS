using System.Data.SqlClient;

public class Conexion
{
    public static SqlConnection ObtenerConexion()
    {
        string cadena = "workstation id=EXPRESS.mssql.somee.com;packet size=4096;user id=KVNSABIN_SQLLogin_1;pwd=Aitanna2024;data source=EXPRESS.mssql.somee.com;persist security info=False;initial catalog=EXPRESS;TrustServerCertificate=True";
        return new SqlConnection(cadena);
    }
}
