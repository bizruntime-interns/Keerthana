using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Linq_example
    {
        static void Main(string[] args)
        {
            int[] s = new int[] { 22, 33, 44, 55, 78, 100 };
            IEnumerable<int> scoreQuery =from score in s where score > 60 select score;
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

        }
    }
}
