using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Random
{
    public class RandomNumber
    {
        // Generates a random number within a range.      
        public static int GetRandomNumber()
        {
            System.Random _random = new System.Random();
            return _random.Next(1000000, 99999999);
        }

        public static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            System.Random random = new System.Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        public static string RandomDigits(int length)
        {
            var random = new System.Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }
        public static string MakeKey(string code,int count)
        {
            string subkey = "";
            if (count<10)
            {
                subkey = "00000" + count;
            }
            else if (count < 100 && count>9)
            {
                subkey = "0000" + count;
            }
            else if (count < 1000 && count > 99)
            {
                subkey = "000" + count;
            }
            else if (count < 10000 && count > 999)
            {
                subkey = "00" + count;
            }
            else if (count < 100000 && count > 9999)
            {
                subkey = "0" + count;
            }
            else if (count < 1000000 && count > 99999)
            {
                subkey = "" + count;
            }
            return code+subkey;
        }
        public static string MakeCustomerKey(int count)
        {
            string subkey = "";
            if (count < 10)
            {
                subkey = "0000" + count;
            }
            else if (count < 100 && count > 9)
            {
                subkey = "000" + count;
            }
            else if (count < 1000 && count > 99)
            {
                subkey = "00" + count;
            }
            else if (count < 10000 && count > 999)
            {
                subkey = "0" + count;
            }
            else if (count < 100000 && count > 9999)
            {
                subkey = "" + count;
            }
            return subkey;
        }
    }
}
