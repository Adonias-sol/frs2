using System;
using System.Linq;

namespace frs
{
    static class HashHelper
    {
        public static string HashPassword(string plainPassword)
        {
           
            return BCrypt.Net.BCrypt.EnhancedHashPassword(plainPassword);
        }

        public static bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(plainPassword, hashedPassword);
        }
        public static string GenerateRandomPassword()
        {
            string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string spec = "!@#$%&*_";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string num = "0123456789";

            Random rnd = new Random();
            string password = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                password = password.Insert(i, caps[rnd.Next(caps.Length)].ToString());
                password = password.Insert(i, lower[rnd.Next(lower.Length)].ToString());
                password = password.Insert(i, num[rnd.Next(num.Length)].ToString());
                password = password.Insert(i, spec[rnd.Next(spec.Length)].ToString());
            }

            return new string(password.OrderBy(x => rnd.Next()).ToArray());
        }
    }
}