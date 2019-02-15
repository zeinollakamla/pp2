using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
        
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Kamila Zeinolla\Documents\Visual Studio 2017\Projects");
            PrintInfo(dir, 1);
        }
                            
  

        private static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string line = new string(' ', k);
            line = line + fsi.Name;
            Console.WriteLine(line);

            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                var items = (fsi as DirectoryInfo).GetFileSystemInfos();
                foreach (var i in items)
                {
                    PrintInfo(i, k + 4);
                }
            }
        }
        
    }
}
