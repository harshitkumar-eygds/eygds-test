using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newconsoleapp
{
    
    class Program 
    {
       // public int id { get; set; }
        public string stud_name { get; set; }
        public string sub_name { get; set; }
        public int marks { get; set; }
        
        public void insert() 
        {
            Program p = new Program();

            //Console.WriteLine("Enter student id:");
            //p.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student Name");
            p.stud_name = Console.ReadLine();

            Console.WriteLine("Enter Subject Name");
            p.sub_name = Console.ReadLine();

            Console.WriteLine("Enter Marks");
            p.marks = int.Parse(Console.ReadLine());

            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            studentmark obj = new studentmark();

           // obj.id = p.id;
            obj.stud_name = p.stud_name;
            obj.sub_name = p.sub_name;
            obj.marks = p.marks;

            LTS.studentmarks.InsertOnSubmit(obj);
            LTS.SubmitChanges();

        }

        public void delete()
        {
           // Program p = new Program();

            Console.WriteLine("Enter student id to delete:");
            int id = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter student Name");
            //p.stud_name = Console.ReadLine();

            //Console.WriteLine("Enter Subject Name");
            //p.sub_name = Console.ReadLine();

            //Console.WriteLine("Enter Marks");
            //p.marks = int.Parse(Console.ReadLine());

            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            studentmark obj = new studentmark();

            var deleterow = from s in LTS.studentmarks
                              where s.id == id
                              select s ;

            //foreach (var i in deleterow) 
            //{
            //    if (i.id == p.id)
            //    {
            //        obj.id = i.id;
            //        obj.stud_name = i.stud_name;
            //        obj.sub_name = i.sub_name;
            //        obj.marks = i.marks;
            //    }
            //}
            

            //LTS.studentmarks.Attach(obj);
            LTS.studentmarks.DeleteAllOnSubmit(deleterow);
            LTS.SubmitChanges();

        }

        public void display() 
        {
            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            var selectQuery = from s in LTS.studentmarks
                              select s;

            foreach (var i in selectQuery) 
            {
                Console.WriteLine(i.id + " " + i.stud_name + " " + i.sub_name + " " + i.marks);
            }
        }

        public void update() 
        {
            Program p = new Program();

            Console.WriteLine("Enter student id to update:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new student Name");
            p.stud_name = Console.ReadLine();

            Console.WriteLine("Enter new Subject Name");
            p.sub_name = Console.ReadLine();

            Console.WriteLine("Enter new Marks");
            p.marks = int.Parse(Console.ReadLine());

            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            var updateres = from s in LTS.studentmarks
                            where s.id == id
                            select s;

            //studentmark obj = new studentmark();

            // obj.id = p.id;
            foreach (var i in updateres)
            {
                i.stud_name = p.stud_name;
                i.sub_name = p.sub_name;
                i.marks = p.marks;
            }

            //LTS.studentmarks.InsertOnSubmit(obj);
            LTS.SubmitChanges();
        }


        static void Main(string[] args)
        {
            Program p1 = new Program();
            int i = 1;
            while (i == 1) 
            {
                Console.WriteLine("Choose Option :");
                Console.WriteLine("1. Display");
                Console.WriteLine("2. Insert");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Clear Console");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine("Display");
                            //Console.WriteLine();
                            p1.display();
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Insert");
                           // Console.WriteLine();
                            p1.insert();
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Update");
                           //Console.WriteLine();
                            p1.update();
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Delete");
                            Console.WriteLine();
                            p1.delete();
                            Console.WriteLine();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Console Cleared");
                            Console.WriteLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Exiting...");
                            i = 0;
                            break;
                        }
                    default:
                        Console.WriteLine("Enter correct value");
                        break;
                }
            }
            

            Console.ReadKey();
        }
    }
}
