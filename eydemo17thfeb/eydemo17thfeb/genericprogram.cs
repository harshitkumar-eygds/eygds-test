//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace eydemo17thfeb
//{
//    class genericprogram
//    {
//        static void Main(string[] args)
//        {
//            Stack<string> s1 = new Stack<string>();
//            s1.Push("aa");
//            s1.Push("bb");
//            s1.Push("cc");
//            s1.Push("dd");

//            Console.WriteLine("Stack(strings) elements are : ");
//            foreach (var item in s1) 
//            {
//                Console.WriteLine(item);
//            }

//            Stack<int> sl1 = new Stack<int>();
//            sl1.Push(11);
//            sl1.Push(22);
//            sl1.Push(33);
//            sl1.Push(44);

//            Console.WriteLine("Stack(int) elements are : ");
//            foreach (var item in sl1)
//            {
//                Console.WriteLine(item);
//            }

//            Queue<int> q = new Queue<int>();
//            q.Enqueue(11);
//            q.Enqueue(12);
//            q.Enqueue(13);
//            q.Enqueue(14);

//            Console.WriteLine("Queue(int) elements are : ");
//            foreach (var item in q)
//            {
//                Console.WriteLine(item);
//            }

//            SortedList<int, String> p1 = new SortedList<int, string>();
//            p1.Add(10, "aa");
//            p1.Add(11, "bb");
//            p1.Add(12, "cc");
//            p1.Add(13, "dd");
//            p1.Add(14, "ee");

//            Console.WriteLine("SortedList<int, String> p1 elements are : ");
//            foreach (var item in p1)
//            {
//                Console.WriteLine(item);
//            }

//            LinkedList<int> ls1 = new LinkedList<int>();
//            ls1.AddFirst(1);
//            ls1.AddLast(10);
//            ls1.AddLast(11);
//            ls1.AddLast(12);
//            ls1.AddLast(13);
//            ls1.AddLast(14);
//            ls1.AddLast(15);

//            ls1.AddFirst(2);
//            ls1.AddFirst(3);
//            ls1.AddFirst(4);
//            ls1.AddFirst(5);

//            LinkedListNode<int> n1;
//            n1 = ls1.Find(5);
//            ls1.AddAfter(n1, 6);

//            Console.WriteLine("LinkedList<int> p1 elements are : ");
//            foreach (var item in ls1)
//            {
//                Console.WriteLine(item);
//            }



//            //======Practice Program ==== 

//            Console.WriteLine("=====================Practice Program ================");
//            LinkedList<int> ls2 = new LinkedList<int>();
//            ls2.AddFirst(9);
//            ls2.AddLast(8);
//            ls2.AddLast(7);
//            ls2.AddLast(6);
//            ls2.AddLast(5);
            
//            LinkedListNode<int> n2;
//            n2 = ls2.Find(7);
//            ls2.AddBefore(n2, 10);

//            n2 = ls2.Find(5);
//            ls2.AddAfter(n2, 11);

//            Console.WriteLine("LinkedList<int> ls2 elements are : ");
//            foreach (var item in ls2)
//            {
//                Console.WriteLine(item);
//            }





//            Console.ReadKey();



//        }
//    }
//}
