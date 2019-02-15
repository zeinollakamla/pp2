using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool IsPrime(int number)//computing the Prime numbers
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));//"Math.Floor" rounds down towards negative infinity

            for (int i=3; i<=boundary; i += 2)//checks the odd numbers
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            int n = int.Parse(line1);//cast the string to int
            string[] a = line2.Split();//splits a string into an array
            int cnt = 0;//counter
            List<int> myList = new List<int>();//сreate a list 

            for (int i=0; i<n; ++i)//numbers are checked for prime
            {
                int x = int.Parse(a[i]);
                if (IsPrime(x))
                {
                    cnt++;
                    myList.Add(x);//add prime numbers to the list
              
                }
            }

            Console.WriteLine(cnt);
            foreach(var q in myList)
            {
                Console.Write(q + " ");
            }
            Console.ReadKey();                   
        }
    }
}

