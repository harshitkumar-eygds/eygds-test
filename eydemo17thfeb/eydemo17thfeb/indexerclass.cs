using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    class IndexedNames 
    {
        private string[] nameslist = new string[size];
        static public int size = 10;

        public IndexedNames() 
        {
            for (int i = 0; i < size; i++) 
            {
                nameslist[i] = "N.A.";
            }
        }

        public string this[int index] 
        {
            get 
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                {
                    tmp = nameslist[index];
                }
                else 
                {
                    tmp = "";
                }

                return (tmp);
            }
            set 
            {
                if (index >= 0 && index <= size - 1)
                {
                     nameslist[index] = value;
                }
            }
        }
    }
    class indexerclass
    {
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Rohan0";
            names[1] = "Rohan1";
            names[2] = "Rohan2";
            names[3] = "Rohan3";
            names[4] = "Rohan4";
            names[5] = "Rohan5";
            //names[6] = "Rohan6";
            //names[7] = "Rohan7";
            //names[8] = "Rohan8";
            //names[9] = "Rohan9";

            for (int i = 0; i < IndexedNames.size; i++) 
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
    }
}
