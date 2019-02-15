using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"C:\Users\Kamila Zeinolla\Desktop\path";
            string folderName1 = @"C:\Users\Kamila Zeinolla\Desktop\path1";
            string fileName = "newfile.txt";
            string path = Path.Combine(folderName, fileName);
            string path1 = Path.Combine(folderName1, fileName);
          
            FileStream fs= File.Create(path);
            fs.Close();
            File.Copy(path, path1, true);
            File.Delete(path);
            

            
                                                    

        }
       
    }
}
