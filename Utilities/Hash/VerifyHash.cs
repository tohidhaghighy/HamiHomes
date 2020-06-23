using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Utilities.Hash
{
    public class VerifyHash
    {
        public bool IsValidPassword(string password, string hashPass)
        {
            bool result = true;

            // Extract the bytes
            byte[] hashBytes = Convert.FromBase64String(hashPass);
            // Get the salt
            byte[] salt = new byte[20];
            Array.Copy(hashBytes, 0, salt, 0, 20);
            // Compute the hash on the password the user entered
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            // compare the results
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 20] != hash[i])
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                result = false;
                throw;
            }
            

            return result;
        }
    }
}
