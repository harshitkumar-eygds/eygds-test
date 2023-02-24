using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    class filehandling
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\labuser\source\repos\harshitkumar-eygds\eygds-test\a.txt";
            FileInfo fi = new FileInfo(file);

            Console.WriteLine("File name : " + fi.Name);
            Console.WriteLine("Full file name : " + fi.FullName);
            Console.WriteLine("Extension : " + fi.Extension);
            Console.WriteLine("Directory name : " + fi.DirectoryName);
            Console.WriteLine("Directory : " + fi.Directory);
            Console.WriteLine("Length : " + fi.Length);

            
            string directory = "C:\\Users\\labuser\\source\\repos\\harshitkumar-eygds\\eygds-test";

            DirectoryInfo di = new DirectoryInfo(directory);

            Console.WriteLine("Directory name : " + di.Name);
            Console.WriteLine("Full Directory name : " + di.FullName);
            Console.WriteLine("parent : " + di.Parent);
            //Console.WriteLine("Directory name : " + fi.DirectoryName);
            //Console.WriteLine("Directory : " + fi.Directory);
            //Console.WriteLine("Length : " + fi.Length);


            string pathString = System.IO.Path.Combine(directory, "demo1");

            string newdir = directory + "\\demo1";
            Console.WriteLine(newdir);
            Directory.CreateDirectory(newdir);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Directory in the folder");
            foreach (var item in Directory.GetDirectories(directory)) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Files in the folder");
            foreach (var item in Directory.GetFiles(directory))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            //di.Create("demo1");

        }
    }
}
