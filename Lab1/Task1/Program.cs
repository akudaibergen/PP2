using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;   // it counts prime numbers
            int a = int.Parse(Console.ReadLine()); // a is integer, which shows the length of massive
            int[] ag = new int[a]; // create integer massive ag
            string s = Console.ReadLine(); // reads the future elements of array
            string[] sr = s.Split(); // it splits the string to the new array
            List<int> BB = new List<int>(); // create a list in which we save prime numbers
            for (int i = 0; i < a; i++)// loop for assignment from string to int
            {
                ag[i] = int.Parse(sr[i]);// we save input integers to ag massive
            }
            for (int i = 0; i < a; i++) //loop for checking all elements of massive 
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
                        cnt++;// counting prime numbers
                        BB.Add(ag[i]);// assignment prime number to list
                    }
                }
            }
            Console.WriteLine(cnt);// output of counter
            for (int i = 0; i < BB.Count(); i++)// loop to out out all prime numbers
            {
                Console.Write(BB[i] + " ");//output 
            }
        }
    }
}
