using System;
using CalculatorCore;

namespace TestableCalculatorRunner
{
	class Program
	{
		static void Main(string[] args)
		{
			var calculator = new Calculator();

			bool keepGoing = true;

			while(keepGoing)
			{
				Console.WriteLine("\u001b[35mEnter an expression to evaluate. ex: '1 + 1' OR type 'exit' to quit\u001b[0m");

				string input = Console.ReadLine();
				if (input == "exit")
				{
					keepGoing = false;
					break;
				}
				var output = calculator.Evaluate(input);

				if (!String.IsNullOrWhiteSpace(output.ErrorMessage))
				{
					Console.WriteLine(output.ErrorMessage);
				}
				else
				{
					Console.WriteLine($"Result: {output.Result}");
				}
			}
			
		}
	}
}
