//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace simpleconsoleapplinq
//{
//    class Firstordefaultprgm
//    {
//        static void Main(string[] args)
//        {
//            int[] vals = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//            int[] vals2 = {0 };

//            Console.WriteLine(vals.FirstOrDefault(x => x>5));
//            Console.WriteLine(vals2.FirstOrDefault(x => x > 5));

//            int[] vals3 = {};
//            string[] vals4 = { };
            
//            var a = vals4.DefaultIfEmpty();
//            Console.WriteLine(a);
//            //Console.WriteLine(a);

//            int[] NumArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

//            var result = NumArray.AsEnumerable();
//            Console.WriteLine(result);
//            Console.WriteLine();
//            foreach (var number in result) 
//            {
//                Console.WriteLine(number);
//            }

//            List<int> list = new List<int>();
//            list.Add(0);
//            list.Add(1);

//            int[] array = new int[2];
//            array[0] = 0;
//            array[1] = 1;

//            Stack<int> s = new Stack<int>();
//            s.Push(0);
//            s.Push(1);

//            Console.WriteLine(list.Average());
//            Console.WriteLine(list.Sum());

//            Console.WriteLine(array.Average());
//            Console.WriteLine(array.Sum());

//            Console.WriteLine(s.Average());
//            Console.WriteLine(s.Sum());

//            var qlist = list.AsQueryable();
//            var qarray = array.AsQueryable();

//            Console.WriteLine(qlist.Average());
//            Console.WriteLine(qlist.Sum());

//            Console.WriteLine(qarray.Average());
//            Console.WriteLine(qarray.Sum());



//            List<int> lint = new List<int>();
//            int[] iarray = new int[];



//            Console.ReadKey();
//        }
//    }
//}
