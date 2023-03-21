using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleconsoleapplinq
{
    class Product : IEnumerable
    {
        public string[] ProductList = new string[5];
        int index = 0;

        public void AddProduct(string product) 
        {
            ProductList[index++] = product;
        }

        public void RemoveProduct(int index) 
        {
            ProductList[index] = "";
        }

        public IEnumerator GetEnumerator() 
        {
            return new ProductEnumerator();
        }

        class ProductEnumerator : IEnumerator 
        {
            public object Current => throw new NotImplementedException();

            public bool MoveNext() 
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }

    class ienumprgm
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();

            p1.AddProduct("a");
            p1.AddProduct("b");

            p1.RemoveProduct(0);

            Console.WriteLine("Products are : ");
            foreach (var i in p1.ProductList) 
            {
                Console.WriteLine(i);
            }




            int[] arr = new int[5] { 10,20,30,40,50};

            var res = arr.AsEnumerable();

            foreach (var ele in res) 
            {
                Console.WriteLine(ele);
            }

            int res1 = Queryable.Sum(arr.AsQueryable());
            Console.WriteLine("Sum :   "+res1);

            Console.ReadKey(); 
        }
    }
}
