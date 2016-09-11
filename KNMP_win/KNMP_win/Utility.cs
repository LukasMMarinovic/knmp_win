using System;
using System.Collections.Generic;
using System.Text;

namespace KNMP_win
{
    class Utility
    {
        public static int Random(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
    }
}
