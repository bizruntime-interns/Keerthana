using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Files_Binary
    {
        static void Main(string[] args)
        {
            int i = 100;
            string s = "name";
            float f = 40.0f;
            char c = 'a';
            //creation of the file
            BinaryWriter bw = new BinaryWriter(new FileStream("data.txt", FileMode.Create));
            //writing into the file
            bw.Write(i);
            bw.Write(s);
            bw.Write(f);
            bw.Write(c);

            bw.Close();
            //reading the data from the file 
            try
            {
                BinaryReader br = new BinaryReader(new FileStream("data.txt", FileMode.Open));
                i = br.ReadInt32();
                Console.WriteLine("Integer value:{0}", i);
                s = br.ReadString();
                Console.WriteLine("string value:{0}",s);
                f = br.ReadInt64();
                Console.WriteLine("float value:{0}",f);
                c = br.ReadChar();
                Console.WriteLine("Character value:{0}", c);
                br.Close();
            }
            catch(EndOfStreamException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
            
        }
    }
}
