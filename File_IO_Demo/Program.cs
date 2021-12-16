﻿using System;
using System.IO;

namespace File_IO_Demo
{
        class Program
        {
            static void Main(string[] args)
            {


            FileExists();
            ReadAllLines();
            ReadAllText();
            FileCopy();
            DeleteFile();
            ReadFromStreamReader();
            WriteUsingStreamWriter();
            Console.ReadKey();

            }
             /// <summary>
             /// it will check file exists or not
             /// </summary>
            public static void FileExists()
            {
            String path = @"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\File_IO_Demo\Example.txt";
                if (File.Exists(path))
                    Console.WriteLine("File exists");
                else
                    Console.WriteLine("File doesn't exists");
            }

            public static void ReadAllLines()
            {
                String path = @"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\File_IO_Demo\Example.txt";
                String[] lines;
                //C: \Users/inyadav\source\repos\Day20_FileIO\Day20_FileIO
                lines = File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);

            }

            public static void ReadAllText()
            {
                String path = @"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\File_IO_Demo\Example.txt";
                String lines;
                lines = File.ReadAllText(path);
                Console.WriteLine(lines);

            }

            public static void FileCopy()
            {
                String path = @"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\File_IO_Demo\Example.txt";
                String copypath = @"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\File_IO_Demo\Example1.txt";

                File.Copy(path, copypath);

            }

            public static void DeleteFile()
            {
                String path = @"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\File_IO_Demo\Example1.txt";

                File.Delete(path);

            }

            public static void ReadFromStreamReader()
            {
                String path = @"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\File_IO_Demo\Example.txt";

                using (StreamReader sr = File.OpenText(path))
                {
                    String s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

            }

            public static void WriteUsingStreamWriter()
            {
                String path = @"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\File_IO_Demo\Example.txt";

                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine("Hellow World - .Net is awesome");
                    sr.Close();
                    Console.WriteLine(File.ReadAllText(path));
                }
            }

        }
}


    
