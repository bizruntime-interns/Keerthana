using System;
using System.IO;

namespace File
{
    class Disposable
    {
        static void Main(string[] args)
        {
            StreamReader sr=null;
            try
            {
                var path = "F:/hey.txt";
               sr  = new StreamReader(path);
                Console.WriteLine(sr.ReadToEnd());
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr?.Dispose();
            }
            Console.ReadKey();
        }
    }
}
