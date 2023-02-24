//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class paramprgm
//    {
//        public static void Show(params int[] val1) 
//        {
//            foreach (var i in val1) 
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//        }

//        public void Show(params String[] val1)
//        {
//            foreach (var i in val1)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();
//        }

//        public int Show(params float[] val1)
//        {
//            foreach (var i in val1)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine();

//            return 0;
//        }

//        static void Main(string[] args)
//        {
//            Show(1, 2, 3, 4, 5, 6, 7, 8, 9,10);

//            paramprgm obj1 = new paramprgm();
//            obj1.Show("aa", "bb", "cc");

//            obj1.Show(2.4f, 5.6f, 23.3f);
//            Console.ReadKey();
//        }
//    }
//}
