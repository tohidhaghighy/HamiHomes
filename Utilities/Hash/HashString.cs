using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Utilities.Hash
{
    public static class HashString
    {
        public static string GetHashPassword(this string password)
        {
            string hashPass = string.Empty;

            // 1.-Create the salt value with a cryptographic PRNG
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[20]);

            // 2.-Create the RFC2898DeriveBytes and get the hash value
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            // 3.-Combine the salt and password bytes for later use
            byte[] hashBytes = new byte[40];
            Array.Copy(salt, 0, hashBytes, 0, 20);
            Array.Copy(hash, 0, hashBytes, 20, 20);

            // 4.-Turn the combined salt+hash into a string for storage
            hashPass = Convert.ToBase64String(hashBytes);

            return hashPass;
        }

        
    }
}
