using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoey_16thfeb
{
	class circle
	{
		static void Main(string[] args)
		{

			int a1 = 10;
			float a2 = 10.23423f;
			char ch = 'a';
			string s1 = "abc";

			Console.WriteLine(a1);
			Console.WriteLine(a2);
			Console.WriteLine(ch);
			Console.WriteLine(s1);



			/* practice program 1 */

			Console.WriteLine("***************************");

			Console.Write("Enter your name : ");
			string name = Console.ReadLine();

			Console.Write("Enter your Roll No. : ");
			int roll = int.Parse(Console.ReadLine());

			Console.WriteLine("Your name is " + name);
			Console.WriteLine("Your Roll no. is " + roll);

			/* practice program 2 */

			Console.WriteLine("***************************");

			Console.Write("Enter 1st num : ");
			int num1 = int.Parse(Console.ReadLine());

			Console.Write("Enter 2nd num : ");
			int num2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Your results are");
			Console.WriteLine("Addition : " + (num1 + num2));
			Console.WriteLine("Multiplication : " + (num1 * num2));
			Console.WriteLine("Subtraction : " + (num1 - num2));
			Console.WriteLine("Division : " + (num1 / num2));

			/*Practice program 3*/

			Console.WriteLine("***************************");

			Console.Write("Enter principle amount : ");
			int p = int.Parse(Console.ReadLine());

			Console.Write("Enter interest : ");
			float i = float.Parse(Console.ReadLine());

			Console.Write("Enter time in years : ");
			int t = int.Parse(Console.ReadLine());

			float si = (p * i * t) / 100;

			Console.WriteLine("Your SI is : " + si);

			/*Practice program 4*/

			Console.WriteLine("***************************");




			const float pi = 3.142f;

			Console.Write("Enter the radius : ");
			float r = float.Parse(Console.ReadLine());


			Console.WriteLine("The area is : " + (pi * r * r));
			Console.WriteLine("The circumference is : " + (2 * pi * r));

			

			byte[] array1 = { 2, 4, 6, 8, 10 };
			Console.WriteLine("BArray is :{0}", BitConverter.ToString(array1));

			Console.WriteLine();
			String str = Convert.ToBase64String(array1);
			Console.WriteLine("Base 64 string is :{0}", str);

			Console.ReadKey(); 
			//update
		}
	}
}
