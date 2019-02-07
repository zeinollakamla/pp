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
        
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Increment the year of study: {++year}");
        }
    }
}
