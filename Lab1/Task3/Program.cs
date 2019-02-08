using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            int e = int.Parse(Console.ReadLine()); // e is integer, which shows the length of massive
            int[] aa = new int[e]; // create integer massive aa
            string s = Console.ReadLine(); // Reading new string
            string[] sd = s.Split(); // Creating string massive 'sd' and saving 's' string to it with split(deleting empty spaces)
            for (int i = 0; i < e; i++) // Loop from 0 to 'e'
            {
                aa[i] = int.Parse(sd[i]); // Rewriting from massive 'sd' to 'aa' massive integers
                for (int j = 0; j < 2; j++) // loop from 0 to 2. Because we should show the elements of massive 2 times in this task
                {
                    Console.Write(aa[i] + " "); // rewriting 'i-th' element of massive 'aa' two times by using massive 'j'
                }
            }
            Console.ReadKey(); // To not close the console in debugging procce
        }
    }
}
