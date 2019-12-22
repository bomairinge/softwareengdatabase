using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Software_Engin_Project
{
    static class RandomNum
    {
        private static Random rng = new Random();
        // Method to get a new random number for patient vitals.
        public static int NextRandom()
        {
            lock (rng) return rng.Next(0, 51);
        }
    }
}
