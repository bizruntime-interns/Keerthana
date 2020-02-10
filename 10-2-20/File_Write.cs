using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWrite
{
    class Write_File
    {
        static void Main(string[] args)
        {
            string[] text = new string[] { "Keerthana", "Jayakumar" };
            
            using(StreamWriter write=new StreamWriter("F:/Keerthana/10-2-20/write.txt"))
            {
                foreach(string texts in text)
                {
                    write.WriteLine(texts);
                }
            }
            
             Console.ReadKey();

                
            
        }
    }
}
