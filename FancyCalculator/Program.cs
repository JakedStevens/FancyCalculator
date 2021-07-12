using System;

namespace FancyCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Step 2
			Console.WriteLine("Enter a number");
			string firstValue = Console.ReadLine();
			decimal firstNum;
			while (!Decimal.TryParse(firstValue, out firstNum))
			{
				Console.WriteLine("Unable to convert '{0}' to decimal/integer. Please Enter valid number.", firstValue);
				firstValue = Console.ReadLine();
			}
			Console.WriteLine("First number entered was {1}", firstValue, firstNum);


			Console.WriteLine("Enter a second number, and I'll add it onto the first");
			string secondValue = Console.ReadLine();
			decimal secondNum;
			while (!Decimal.TryParse(secondValue, out secondNum))
			{
				Console.WriteLine("Unable to convert '{0}' to decimal/integer. Please Enter valid number.", secondValue);
				firstValue = Console.ReadLine();
			}
			Console.WriteLine("Second number entered was {1}", secondValue, secondNum);


			decimal result = firstNum + secondNum;
			Console.WriteLine($"Result: {result}");
			#endregion


		}
	}
}
