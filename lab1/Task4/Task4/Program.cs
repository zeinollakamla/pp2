using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();

            int n = int.Parse(line1);//Cast the string to int
            string[,] a = new string[n, n];
            for (int i=0; i<n; ++i)//Fills the array
            {
                for(int j=0; j<n; ++j)
                {
                    a[i, j] = "[*]";
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n-(n-1)+i; ++j)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine('\t');
            }



        }
    }
}
