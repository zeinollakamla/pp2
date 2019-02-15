using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C: \Users\Kamila Zeinolla\Documents\Visual Studio 2017\Projects\Task1\text.txt", Encoding.Default);

            char[] c = s.ToCharArray();
            Array.Reverse(c);
            string rs = new string(c);
            if (rs == s)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }
       
        }
       
    }
}
