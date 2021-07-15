using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
	public class History
	{
		public void GetHistory(List<EvaluationResult> historyList, string input)
		{
			string historyType = input.Split("history")[1].Trim(' ');
			Console.WriteLine("\u001b[36mHistory of Valid Evaluations\u001b[0m");

			if (String.IsNullOrWhiteSpace(historyType))
			{
				historyList.ForEach(evaluationResult =>
				{
					if (String.IsNullOrWhiteSpace(evaluationResult.ErrorMessage))
					{
						Console.WriteLine("{0,10:N1} {1,10} {2,10:N1} {3,10:N1}",
							$"\u001b[95m{evaluationResult.Expression.FirstValue}",
							$" {evaluationResult.Expression.Operator}",
							$" {evaluationResult.Expression.SecondValue}",
							$" = {evaluationResult.Result}\u001b[0m"
						);
					}
				});
			}
			else
			{
				historyList.ForEach(evaluationResult =>
				{
					if (String.IsNullOrWhiteSpace(evaluationResult.ErrorMessage) && evaluationResult.Expression.Operator == historyType)
					{
						Console.WriteLine("{0,10:N1} {1,10} {2,10:N1} {3,10:N1}",
							$"\u001b[95m{evaluationResult.Expression.FirstValue}",
							$" {evaluationResult.Expression.Operator}",
							$" {evaluationResult.Expression.SecondValue}",
							$" = {evaluationResult.Result}\u001b[0m"
						);
					}
				});
			}

		}
	}
}
