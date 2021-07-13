using System;
using CalculatorCore;

namespace TestableCalculatorRunner
{
	class Program
	{
		static void Main(string[] args)
		{
			var calculator = new Calculator();

			Console.WriteLine("\u001b[35mEnter two numbers and a '+' or '-' operator inbetween ex: '1 + 1'\u001b[0m");

			string input = Console.ReadLine();
			var output = calculator.Evaluate(input);

			if (String.IsNullOrWhiteSpace(output.ErrorMessage))
			{
				Console.WriteLine(output.ErrorMessage);
			}
			else
			{
				Console.WriteLine(output.Result);
			}
			
		}
	}
}
