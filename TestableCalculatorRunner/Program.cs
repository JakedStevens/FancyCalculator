using System;
using CalculatorCore;

namespace TestableCalculatorRunner
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
			ParseExpression parseExpression = new ParseExpression();
			decimal prevResult = 0;

			while(true)
			{
				Console.WriteLine("Enter an expression to evaluate. ex: '1 + 1' OR type 'exit' to quit");

				string input = Console.ReadLine();
				if (input == "exit") { break; }

				Expression parsedExpression = parseExpression.ParseUserInput(input);
				EvaluationResult output = calculator.Evaluate(parsedExpression, prevResult);


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
