using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoey_16thfeb
{
	class ifelseprgm
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter month name in short");
			string month = Console.ReadLine();

			if (month == "january")
				Console.WriteLine(1);

			if (month == "feburary")
				Console.WriteLine(2);

			if (month == "march")
				Console.WriteLine(3);

			if (month == "april")
				Console.WriteLine(4);

			if (month == "may")
				Console.WriteLine(5);

			if (month == "june")
				Console.WriteLine(6);

			if (month == "july")
				Console.WriteLine(7);

			if (month == "august")
				Console.WriteLine(8);

			if (month == "september")
				Console.WriteLine(9);

			if (month == "october")
				Console.WriteLine(10);

			if (month == "novemebr")
				Console.WriteLine(11);

			if (month == "december")
				Console.WriteLine(12);


			//program 2


			Console.WriteLine("enter age");
			int age = int.Parse(Console.ReadLine());

			if (age >= 18)
				Console.WriteLine("Eligible to vote");
			else
				Console.WriteLine("Not eligible to vote");


			//program 3 
			Console.WriteLine("Enter day name");
			string day = Console.ReadLine();

			switch (day)
			{
				case "monday":
					Console.WriteLine(1);
					break;

				case "tuesday":
					Console.WriteLine(2);
					break;

				case "wednesday":
					Console.WriteLine(3);
					break;

				case "thrusday":
					Console.WriteLine(4);
					break;

				case "friday":
					Console.WriteLine(5);
					break;

				case "saturday":
					Console.WriteLine(6);
					break;

				case "sunday":
					Console.WriteLine(7);
					break;
			}
			//program 4

			Console.WriteLine(" Enter num1");
			int num1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter num1");
			int num2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter symbol");
			string symbol = Console.ReadLine();

			switch (symbol)
			{
				case "+":
					Console.WriteLine(num1 + num2);
					break;

				case "-":
					Console.WriteLine(num1 - num2);
					break;

				case "*":
					Console.WriteLine(num1 * num2);
					break;

				case "/":
					Console.WriteLine(num1 / num2);
					break;
			}

			Console.ReadKey();
		}
	}


}