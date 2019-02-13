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
            string PL = System.IO.File.ReadAllText(@"D:\проекты\PP2\Lab2\Task1\Input.txt");
            bool pol = true;
            int n = PL.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (PL[i] != PL[n - 1 - i])
                {
                    pol = false;
                    break;
                }
            }
            if (pol == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
