using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.User.Helpers
{
    public static class Bcrypt
    {
        public static string HashPass(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool ComparePass(string passHashed, string pass)
        {
            return BCrypt.Net.BCrypt.Verify(pass, passHashed);
        }
    }
}
