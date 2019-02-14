using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = System.IO.File.ReadAllText(@"D:\проекты\PP2\Lab2\Task1\input.txt"); // it reads the value of string "s" from txt file that located on folder(by the link)
            bool ok = true; // bool argument that taken value "true"
            int k = s.Length; // we are getting the length of word and saving on int type "k"
            for (int i = 0; i < k / 2; i++) // loop that runs in half of word
            {
                if (s[i] != s[k - 1 - i]) // if first symbol and last symbol aren`t equal(equation should work) then it goes to next step
                {
                    ok = false; // then bool expression changes to "false"
                    break; // loop stops
                }
            }
            if (ok == true) // if bool expression equal to "true"
            {
                Console.WriteLine("Yes"); // then word is palindrome
            }
            else
            {
                Console.WriteLine("No"); // else it`s not
            }

        }
    }
}