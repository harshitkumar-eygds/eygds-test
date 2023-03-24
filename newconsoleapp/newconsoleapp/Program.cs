using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newconsoleapp
{
    class subject2
    {
        public int studid { get; set; }
        public string sub_name { get; set; }
        public int marks { get; set; }
    }
    class Program : subject2
    {
        public void insert() 
        {
            Console.WriteLine("Enter student id:");
            studid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Name");
            sub_name = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = int.Parse(Console.ReadLine());
        }


        static void Main(string[] args)
        {
        }
    }
}
