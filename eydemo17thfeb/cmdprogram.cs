using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    class asoperator
    {
        class Class1 { }
        class Class2 { }
        class Class3 { }
        static void Main(string[] args)
        {
            object[] myObjects = new object[6];

            myObjects[0] = new Class1();
            myObjects[1] = new Class2();

            myObjects[2] = "string";
            myObjects[3] = 32;
            myObjects[4] = null;

            for (int i = 0; i < myObjects.Length; i++) 
            {
                string s = myObjects[i] as string;

                Console.Write($"{i} : ");

                if(s!=null)
                    Console.WriteLine($"'{s}'");
                else
                    Console.WriteLine("Not a string");
            
            }



            Console.ReadKey();
        }
     }
    }

