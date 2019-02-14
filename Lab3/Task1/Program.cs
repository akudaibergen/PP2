using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class FarManager
    {
        public int cursor;
        public string path;
        public int size;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;

        public FarManager(string path)
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            size = directory.GetFileSystemInfos().Length;
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index)
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                Color(fs[i], k);
                Console.WriteLine(fs[i].Name);
                k++;
            }
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = size - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == size)
                cursor = 0;
        }


        public void Calc()
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            size = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        size--;
        }
        public void Start()
        {
            ConsoleKeyInfo ck = Console.ReadKey();
            while (ck.Key != ConsoleKey.Escape)
            {
                Calc();
                Show();
                ck = Console.ReadKey();
                if (ck.Key == ConsoleKey.UpArrow)
                    Up();
                if (ck.Key == ConsoleKey.DownArrow)
                    Down();
                if (ck.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0;
                }
                if (ck.Key == ConsoleKey.LeftArrow)
                {
                    ok = true;
                    cursor = 0;
                }
                if (ck.Key == ConsoleKey.Enter)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = currentFs.FullName;
                    }
                }
                if (ck.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }
                if (ck.Key == ConsoleKey.Delete)
                {
                    string path1 = currentFs.FullName;
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        Directory.Delete(path1, true);
                    }
                    else
                    {
                        File.Delete(path1);
                    }
                }
                if (ck.Key == ConsoleKey.R)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("Enter new name ");
                    string name = Console.ReadLine();

                    string path1 = currentFs.FullName;
                    string path2 = directory.Parent.FullName;
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {

                    }
                    else
                    {
                        File.Move();
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\проекты\PP2";
            FarManager fm = new FarManager(path);
            fm.Start();
        }
    }
}