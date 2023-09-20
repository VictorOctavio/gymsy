using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace gymsy.Utilities
{
    internal class Bcrypt
    {
        public static string HashPassoword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool ComparePassowrd(string currentPassowd, string passwordCompare)
        {
            return BCrypt.Net.BCrypt.Verify(currentPassowd, passwordCompare);
        } 
    }
}
