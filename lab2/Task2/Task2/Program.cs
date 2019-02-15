using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task2
{
    class Program
    {
        public static bool IsPrime(int number)//computing the Prime numbers
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));//"Math.Floor" rounds down towards negative infinity

            for (int i = 3; i <= boundary; i += 2)//checks the odd numbers
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string a = File.ReadAllText(@"C:\Users\Kamila Zeinolla\Documents\Visual Studio 2017\Projects\Task2\text.txt", Encoding.Default);
            string[] s = a.Split();
            string b = "";

            for (int i = 0; i < s.Length; ++i)//numbers are checked for prime
            {
                int x = int.Parse(s[i]);
                if (IsPrime(x))
                {
                    
                    b+=$"{x} ";

                }
            }
            File.WriteAllText(@"C:\Users\Kamila Zeinolla\Documents\Visual Studio 2017\Projects\Task2\write.txt", b);

        }
    }
}
