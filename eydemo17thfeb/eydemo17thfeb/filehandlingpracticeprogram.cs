using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace eydemo17thfeb
{
    class filehandlingpracticeprogram
    {
        static void Main(string[] args)
        {
            string dir = "C:\\Users\\labuser\\source\\repos\\harshitkumar-eygds\\eygds-test";

            //if (!Directory.Exists(dir + "\\simplilearn"))
            //    Directory.CreateDirectory(dir + "\\simplilearn");

            //if (!Directory.Exists(dir + "\\simplilearn\\bangalore"))
            //    Directory.CreateDirectory(dir + "\\simplilearn\\bangalore");

            //if (!Directory.Exists(dir + "\\simplilearn\\delhi"))
            //    Directory.CreateDirectory(dir + "\\simplilearn\\delhi");

            if (!Directory.Exists(dir + "\\simplilearn\\bangalore\\whitefield"))
                Directory.CreateDirectory(dir + "\\simplilearn\\bangalore\\whitefield");

            if (!Directory.Exists(dir + "\\simplilearn\\bangalore\\silkboard"))
                Directory.CreateDirectory(dir + "\\simplilearn\\bangalore\\silkboard");

            if (!Directory.Exists(dir + "\\simplilearn\\delhi\\ncr"))
                Directory.CreateDirectory(dir + "\\simplilearn\\delhi\\ncr");

            string dir_bng_whitefield = dir + "\\simplilearn\\bangalore\\whitefield";
            string dir_bng_silkboard = dir + "\\simplilearn\\bangalore\\silkboard";
            string dir_delhi_ncr = dir + "\\simplilearn\\delhi\\ncr";

            //Console.WriteLine(dir_bng_whitefield + "\\" + "file1.txt");

            //if (File.Exists(dir_bng_whitefield + "\\" + "file1.txt"))
            //    File.Create(dir_bng_whitefield + "\\" + "file1.txt");

            //if (File.Exists(dir_bng_silkboard + "\\" + "file2.txt"))
            //    File.Create(dir_bng_silkboard + "\\" + "file2.txt");

            //if (File.Exists(dir_delhi_ncr + "\\" + "file3.txt"))
            //    File.Create(dir_delhi_ncr + "\\" + "file3.txt");

            string file_bng_whitefield = dir_bng_whitefield + "\\file1.txt";
            string file_bng_silkboard = dir_bng_silkboard + "\\file2.txt";
            string file_delhi_ncr = dir_delhi_ncr + "\\file3.txt";

            Console.WriteLine("Enter content for Bangalore WhiteField file1.txt");
            string content1 = Console.In.ReadToEnd();
            File.AppendAllText(file_bng_whitefield,content1);

            //using (StreamWriter stream = File.AppendText(file_bng_whitefield))
            //{
            //    stream.WriteLine(content1);
            //}

            Console.WriteLine("Enter content for Bangalore SilkBoard file2.txt");
            string content2 = Console.In.ReadToEnd();
            File.AppendAllText(file_bng_silkboard,content2);

            Console.WriteLine("Enter content for Delhi NCR file3.txt");
            string content3 = Console.In.ReadToEnd();
            File.AppendAllText(file_delhi_ncr,content3);

            Console.WriteLine();
            Console.WriteLine("============output=====================");
            Console.WriteLine();

            Console.WriteLine("Content for Bangalore WhiteField are : ");
            Console.WriteLine(File.ReadAllText(file_bng_whitefield));

            Console.WriteLine("Content for Bangalore silkboard are : ");
            Console.WriteLine(File.ReadAllText(file_bng_silkboard));

            Console.WriteLine("Content for Delhi Ncr are : ");
            Console.WriteLine(File.ReadAllText(file_delhi_ncr));



            Console.ReadKey();


        }
    }
}
