using System;
using CalculatorCore;

namespace TestableCalculatorRunner
{
	class Program
	{
		static void Main(string[] args)
		{
			var calculator = new Calculator();

			//Console.WriteLine("\033[31m" + "Enter two numbers and a '+' or '-' operator inbetween ex: '1 + 1'" + "\033[0m");
			Console.WriteLine("\u001b[35mEnter two numbers and a '+' or '-' operator inbetween ex: '1 + 1'\u001b[0m");
			string input = Console.ReadLine();


		var output = calculator.Evaluate(input);
			Console.WriteLine(output.Result);
		}
	}
}
