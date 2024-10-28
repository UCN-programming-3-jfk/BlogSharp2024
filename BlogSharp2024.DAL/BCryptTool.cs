using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bcryptnet = BCrypt.Net;

namespace BlogSharp2024.DAL
{
    public class BCryptTool
    {
        public static string HashPassword(string password) => bcryptnet.BCrypt.HashPassword(password, GetRandomSalt());
        public static bool ValidatePassword(string password, string correctHash) => bcryptnet.BCrypt.Verify(password, correctHash);
        private static string GetRandomSalt() => bcryptnet.BCrypt.GenerateSalt(12);
    }

}
