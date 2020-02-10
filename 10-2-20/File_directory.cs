using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_directory
{
    class Directory
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"F:/bigbasket");
            FileInfo[] f = dir.GetFiles();
            foreach(FileInfo file in f)
            {
                Console.WriteLine("File name:{0},Size:{1}",file.Name,file.Length);
            }
            Console.ReadKey();
        }
    }
}
