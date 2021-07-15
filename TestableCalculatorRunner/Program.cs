using System;
using System.Collections.Generic;
using System.Linq;
using CalculatorCore;

namespace TestableCalculatorRunner
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
			ParseExpression parseExpression = new ParseExpression();
			List<EvaluationResult> historyList = new List<EvaluationResult>();
			History history = new History();
			decimal prevResult = 0;

			while (true)
			{
				Console.WriteLine("Enter an expression to evaluate. ex: '1 + 1' OR type 'exit' to quit");
				string input = Console.ReadLine();

				if (input.ToLower() == "exit") { break; }
				if (input.ToLower().Contains("history"))
				{
					history.GetHistory(historyList, input);
				}
				else
				{
					Expression parsedExpression = parseExpression.ParseUserInput(input);
					if (String.IsNullOrWhiteSpace(parsedExpression.ErrorMessage))
					{
						EvaluationResult output = calculator.Evaluate(parsedExpression, prevResult);
						historyList.Add(output);

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
					else { Console.WriteLine($"\u001b[31m{parsedExpression.ErrorMessage}\u001b[0m"); }
				}
			}
		}
	}
}
