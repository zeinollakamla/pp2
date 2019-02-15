using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("Kamila", "ID120");
            a.GetInfo();
            a.PlusYear();
            a.GetInfo();
            Console.ReadKey();
        }
    }
    class Student
    {
        public string name;
        public string id;
        public int year;

        public Student(string n, string i)
        {
            name = n;
            id = i;
            year = 1;
        }
        public void PlusYear()
        {
            ++year;
        }
          
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}, ID: {id}, the year of study: {year}");
            
        }
    }
}
