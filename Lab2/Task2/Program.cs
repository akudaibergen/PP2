using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = System.IO.File.ReadAllText(@"D:\проекты\PP2\Lab2\Task2\input.txt");//reading the value of string from the txt file on folder(by link)
            StreamWriter sw = new StreamWriter(@"D:\проекты\PP2\Lab2\Task2\output.txt");// creating the stream to the output txt for editing
            string[] ss = s.Split();// creating string array "ss" that has value of splited(without spaces) "s"
            int n = ss.Length;// creating new array with length "ss"
            int[] ag = new int[n];// creating int array
            for (int i = 0; i < n; i++)// loop for writing input to int array
            {
                ag[i] = int.Parse(ss[i]);// copying input from ss to ag 
            }
            for (int i = 0; i < n; i++) //loop for checking all elements of massive 
            {
                int c = 0;// counter for checking to prime number
                if ((ag[i] != 1) && (ag[i] != 0))// first of all we are cheking number 1 or 0 because they are not prime
                {
                    for (int j = 2; j < ag[i]; j++)// loop for counting divisors
                    {
                        if ((ag[i] % j == 0))// condition for checking divisors
                        {
                            c++;// counter
                        }

                    }
                    if ((c == 0))// condition for checking 
                    {
                        sw.Write(ag[i] + " ");
                    }
                }
            }
            sw.Close();// Closing the stream
        }
    }
}
