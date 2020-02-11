using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOApp
{
    class Readfile
    {
        static void Main(string[] args)
        {
            using (StreamReader read=new StreamReader("F:/hey.txt"))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                    Console.WriteLine(line);
                Console.ReadKey();
            }
        }
    }
}
