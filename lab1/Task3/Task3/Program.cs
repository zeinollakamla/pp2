using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int[] MakeDoubleArray(int[] m)//function that fills the array where every element is repeated
        {
            int[] res = new int[2 * m.Length];
            for(int i=0; i<m.Length; ++i)
            {
                res[2 * i] = m[i];
                res[2 * i + 1] = m[i];
                //res[2 * i] = res[2 * i + 1] = m[i];
                
            }
            return res;
        }
        static void Main(string[] args)
        {
            int x=int.Parse(Console.ReadLine());//cast the string to int
            string line = Console.ReadLine();                          
            string[] a = line.Split();//splits a string into an array

            int[] b = new int[x];
            for (int i = 0; i < x; ++i)
            {
                b[i] = int.Parse(a[i]);
            }//fills the array of integers

            int[] ans = MakeDoubleArray(b);
            foreach(int g in ans)
            {
                Console.Write(g + " ");
            }
        }

    }
}
