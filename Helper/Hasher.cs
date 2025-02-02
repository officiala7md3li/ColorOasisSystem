using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ColorOasisSystem.Helper
{
    public static class Hasher
    {
        /// <summary>
        /// Creates a hash from a password using SHA256.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>The hash.</returns>
        public static string Hash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var data = Encoding.ASCII.GetBytes(password);
                var sha256data = sha256.ComputeHash(data);
                return Convert.ToBase64String(sha256data);
            }
        }

        /// <summary>
        /// Verifies a password against a hash using SHA256.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="hashedPassword">The hash.</param>
        /// <returns>Could be verified?</returns>
        public static bool Verify(string password, string hashedPassword)
        {
            var hashOfInput = Hash(password);
            return StringComparer.OrdinalIgnoreCase.Compare(hashOfInput, hashedPassword) == 0;
        }
    }
    //usage
   // var hash = Hasher.Hash("mypassword");

   // Verify
   //var result = Hasher.Verify("mypassword", hash);
}
