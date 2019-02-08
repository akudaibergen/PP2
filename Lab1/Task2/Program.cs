using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string ID;
        public int year;
        public Student(string name, string id, string year)
        {
            this.name = name;
            this.ID = id;
            this.year = int.Parse(year);
        }
        public void PrintStudent()
        {
            Console.WriteLine(name);
            Console.WriteLine(ID);
            Console.WriteLine(year);
        }
        public void IncreamentYear()
        {
            this.year++;
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kudaibergen Adil", "18BD116446", "1");
            student.PrintStudent();
            student.IncreamentYear();
            student.PrintStudent();
             Console.ReadKey();
        }
       
    }
}

