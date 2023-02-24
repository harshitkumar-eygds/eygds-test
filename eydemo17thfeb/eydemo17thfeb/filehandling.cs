//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class filehandling
//    {
//        static void Main(string[] args)
//        {
//            string file = @"C:\Users\labuser\source\repos\harshitkumar-eygds\eygds-test\a.txt";
//            FileInfo fi = new FileInfo(file);

//            Console.WriteLine("File name : " + fi.Name);
//            Console.WriteLine("Full file name : " + fi.FullName);
//            Console.WriteLine("Extension : " + fi.Extension);
//            Console.WriteLine("Directory name : " + fi.DirectoryName);
//            Console.WriteLine("Directory : " + fi.Directory);
//            Console.WriteLine("Length : " + fi.Length);

            
//            string directory = "C:\\Users\\labuser\\source\\repos\\harshitkumar-eygds\\eygds-test";

//            DirectoryInfo di = new DirectoryInfo(directory);

//            Console.WriteLine("Directory name : " + di.Name);
//            Console.WriteLine("Full Directory name : " + di.FullName);
//            Console.WriteLine("parent : " + di.Parent);
//            //Console.WriteLine("Directory name : " + fi.DirectoryName);
//            //Console.WriteLine("Directory : " + fi.Directory);
//            //Console.WriteLine("Length : " + fi.Length);


//            string pathString = System.IO.Path.Combine(directory, "demo1");

//            string newdir = directory + "\\demo1";
//            Console.WriteLine(newdir);
//            Directory.CreateDirectory(newdir);

//            Console.WriteLine();
//            Console.WriteLine();

//            Console.WriteLine("Directory in the folder");
//            foreach (var item in Directory.GetDirectories(directory)) 
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine();

//            Console.WriteLine("Files in the folder");
//            foreach (var item in Directory.GetFiles(directory))
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine("==================Stream Reader program===================");

//            file = @"C:\Users\labuser\source\repos\harshitkumar-eygds\eygds-test\a.txt";
//            StreamReader rdr = new StreamReader(file);
//            string line;

//            while ((line = rdr.ReadLine()) != null) 
//            {
//                Console.WriteLine(line);
//            }

//            StreamReader rdr1 = new StreamReader(file);

//            while ((line = rdr1.Read().ToString()) != "-1")
//            {
//                Console.WriteLine(line);
//            }

//            Console.WriteLine("==================Stream Writer program===================");
//            directory = "C:\\Users\\labuser\\source\\repos\\harshitkumar-eygds\\eygds-test";
//            if (!File.Exists(directory + "\\demo.txt"))
//                File.CreateText(directory + "\\demo.txt");
//            string[] names = new string[] { "harshit", "another harshit", "Harshit the return", "Guess what its Harshti again" };

//            using (StreamWriter sw = new StreamWriter(directory + "\\demo.txt"))
//            {

//                foreach (string n in names)
//                {
//                    sw.WriteLine(n);
//                }

//                sw.Close();
//            }
//            StreamReader rdr2 = new StreamReader(directory + "//demo.txt");

//            while ((line = rdr2.ReadLine()) != null)
//            {
//                Console.WriteLine(line);
//            }

//            rdr2.Close();


//            Console.WriteLine("==================2nd way Stream Writer program===================");
//            directory = "C:\\Users\\labuser\\source\\repos\\harshitkumar-eygds\\eygds-test";

//            string filepath = directory + "\\demo2ndway.txt";
//            if (!File.Exists(filepath))
//                File.CreateText(filepath);
            
//            Console.WriteLine("Enter text to be entered in demo2ndway.txt");
//            string inp = Console.ReadLine();
//            using (StreamWriter sw1 = new StreamWriter(filepath))
//            {
//                sw1.WriteLine(inp);
//                sw1.Close();
//            }
//            StreamReader rdr3 = new StreamReader(filepath);

//            Console.WriteLine("Printing contents of demo2ndway.txt");
//            while ((line = rdr3.ReadLine()) != null)
//            {
//                Console.WriteLine(line);
//            }
//            rdr3.Close();

//            Console.ReadKey();
//            //di.Create("demo1");

//        }
//    }
//}
