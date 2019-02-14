using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name; // creating public variable "name"
        public string ID;// creating public variable "ID"
        public int year;// creating public variable "year"
        public Student(string name, string id, string year)// class that will get info of student
        {
            this.name = name;// our public "name" is equal to the public variable
            this.ID = id;// our public "id" is equal to the public variable
            this.year = int.Parse(year);// our public "year" is equal to the public variable
        }
        public void PrintStudent() // function that will print the variables
        {
            Console.WriteLine(name);// prints name
            Console.WriteLine(ID);// prints ID
            Console.WriteLine(year);// prints year
        }
        public void IncreamentYear()// increamenting method
        {
            this.year++;
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kudaibergen Adil", "18BD116446", "1");// creating class student with 3 parametrs
            student.PrintStudent();// urging the printing function
            student.IncreamentYear();// urging increamenting method
            student.PrintStudent();// urging the printing function
             
        }
       
    }
}

