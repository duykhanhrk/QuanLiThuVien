using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Text;

namespace QuanLyThuVien.Lib
{
    public static class PasswordSecurity
    {
        public static string Encrypt(string password)
        {
            byte[] salt = Encoding.ASCII.GetBytes(System.Configuration.ConfigurationManager.AppSettings["Secret"]);

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}
