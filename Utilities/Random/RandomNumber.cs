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
    }
}
