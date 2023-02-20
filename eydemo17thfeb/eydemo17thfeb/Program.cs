////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace eydemo17thfeb
////{
////	class Program
////	{
////		static void Main(string[] args)
////		{
////			char[] arr = { 'a', 'e', 'i', 'o', 'u' };

////			String s1 = new String(arr);

////			Console.WriteLine(s1);

////			string s2 = "write in c#";

////			Console.WriteLine(s2);

////			string s3 = "data";
////			Console.WriteLine(s3);


////			StringBuilder addWord = new StringBuilder("Word1");
////			addWord.Append(", Word2");
////			addWord.Append(", Word3");
////			addWord.Remove(0, 5);
////			Console.WriteLine(addWord);




////			Console.ReadKey();

////		}
////	}
////}


//using System;

//namespace A 
//{
//	class myclass1 
//	{ 
//	public void function1()
//		{
//			Console.WriteLine("namespace a");
//		}
//	}
//}

//namespace B
//{
//	class myclass2
//	{
//		public void function2()
//		{
//			Console.WriteLine("namespace b");
//		}
//	}
//}

//class myclass3 
//{
//	public void function3()
//	{
//		Console.WriteLine("class 3");
//	}
//}

//class india 
//{
//	static void Main(string[] args)
//	{
//		A.myclass1 obj1 = new A.myclass1();
//		obj1.function1();

//		B.myclass2 obj2 = new B.myclass2();
//		obj2.function2();

//		myclass3 obj3 = new myclass3();
//		obj3.function3();




//		Console.ReadKey();
//	}
//}