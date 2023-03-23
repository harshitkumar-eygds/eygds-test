using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleconsoleapplinq
{
    class Firstordefaultprgm
    {
        static void Main(string[] args)
        {
            int[] vals = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] vals2 = {0 };

            Console.WriteLine(vals.FirstOrDefault(x => x>5));
            Console.WriteLine(vals2.FirstOrDefault(x => x > 5));

            int[] vals3 = {};

            
            var a = vals3.DefaultIfEmpty();
            Console.WriteLine(a);
            //Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
