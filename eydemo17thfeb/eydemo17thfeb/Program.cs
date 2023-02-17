using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] arr = { 'a', 'e', 'i', 'o', 'u' };

			String s1 = new String(arr);

			Console.WriteLine(s1);

			string s2 = "write in c#";

			Console.WriteLine(s2);

			string s3 = "data";
			Console.WriteLine(s3);


			StringBuilder addWord = new StringBuilder("Word1");
			addWord.Append(", Word2");
			addWord.Append(", Word3");
			addWord.Remove(0, 5);
			Console.WriteLine(addWord);




			Console.ReadKey();

		}
	}
}
