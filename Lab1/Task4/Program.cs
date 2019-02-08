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
            int n = int.Parse(Console.ReadLine());// Reading input and convert to int 
            string[,] s = new string[n, n]; // creating 2d array with string  type
            for (int i = 0; i < n; i++)// first loop for first line 
            {
                for (int j = 0; j <= i; j++)// second loop for 
                {
                    s[i, j] = "[*]";//  assignment of char
                    Console.Write(s[i, j]);// output o
                }
                Console.WriteLine();// starting out from next line
            }

        }
    }
}
