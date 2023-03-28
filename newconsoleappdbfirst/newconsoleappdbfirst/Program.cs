using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newconsoleappdbfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var con = new EYdatabaseEntities()) 
            {
                var result = con.studentmarks;

                foreach (var i in result) 
                {
                    Console.WriteLine("ID : " + i.id);
                    Console.WriteLine("Student Name : " + i.stud_name);
                    Console.WriteLine("Subject Name : " + i.sub_name);
                    Console.WriteLine("Marks : " + i.marks);
                    Console.WriteLine();
                    Console.WriteLine();
                    
                }

                Console.ReadKey();
                
            }
        }
    }
}
