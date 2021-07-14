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
			EvaluationResult output;
			decimal prevResult = 0;

			while(keepGoing)
			{
				Console.WriteLine("Enter an expression to evaluate. ex: '1 + 1' OR type 'exit' to quit");
				string input = Console.ReadLine();

				if (input == "exit")
				{
					keepGoing = false;
					break;
				}

				if (prevResult != 0)
				{
					output = calculator.Evaluate(input, true, prevResult);
				}
				else
				{
					output = calculator.Evaluate(input, false, prevResult);
				}

				if (!String.IsNullOrWhiteSpace(output.ErrorMessage))
				{
					Console.WriteLine(output.ErrorMessage);
				}
				else
				{
					prevResult = output.Result;
					Console.WriteLine($"\u001b[32mResult: {output.Result}\u001b[0m");
				}
			}
			
		}
	}
}
