using System;
using System.Security.Cryptography;
using System.Text;

public static class SeguridadHelper
{
    public static byte[] HashPassword(string password)
    {
        using (var sha = SHA256.Create())
        {
            return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }

    public static string HashPasswordToBase64(string password)
    {
        var hashed = HashPassword(password);
        return Convert.ToBase64String(hashed);
    }
}
