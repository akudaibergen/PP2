using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine(); // we are reading the name of file from the console
            string sourcePath = @"D:\проекты\PP2\Lab2\Task4\input"; // location of the file 
            string targetPath = @"D:\проекты\PP2\Lab2\Task4\output"; // endpoint location of the file that will be moved
            string sourceFile = Path.Combine(sourcePath, filename); // it combines the path with the file
            string destFile = Path.Combine(targetPath, filename); // it combines the endpath with the file
            File.Create(sourcePath + @"\" + filename).Dispose(); // creating file on the sourcepath by adding link
            Console.WriteLine("Press SPACE to copy the file"); // writing to the console instrunction
            ConsoleKeyInfo pressedKey = Console.ReadKey(); // reading the key, that will be pressed on keyboard
            if (pressedKey.Key == ConsoleKey.Spacebar) // if this activity wil lbe equal to the "Spacebar" then do copy
            {
                File.Copy(sourceFile, destFile); // copy file of combined file to the destination
            }
            Console.WriteLine("Press Backspace to copy the file"); // writing to the console instrunction
            ConsoleKeyInfo pressedKey2 = Console.ReadKey(); //reading the key, that will be pressed on keyboard
            if (pressedKey2.Key == ConsoleKey.Backspace)  // if this activity wil lbe equal to the "Backspace" then do delete
            {
                File.Delete(sourcePath + @"\" + filename); // delete filename from teh sourcepath by link
            }

        }
    }
}
