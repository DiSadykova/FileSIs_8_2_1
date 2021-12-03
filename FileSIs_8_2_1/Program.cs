using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSIs_8_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryAdres = "E:\\Диляра\\Дом Ушковой" ;
            string[] directories = Directory.GetDirectories(directoryAdres);
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine(directories[i]);
                string subDirectoryAdres = directories[i];
                string[] subDirectories = Directory.GetDirectories(subDirectoryAdres); 
                for (int j = 0; j < subDirectories.Length; j++)
                {
                    Console.WriteLine("     {0}", subDirectories[j]);
                }
            }
            Console.ReadKey();
        }
    }
}
