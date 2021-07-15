using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {
		public EvaluationResult Evaluate(Expression expression, decimal prevResult)
		{
			if ((decimal.TryParse(expression.FirstValue, out decimal firstOperand) == false) && expression.ContinueLastOperation == false)
			{
				return new EvaluationResult { ErrorMessage = $"\u001b[31mThe first number, '{expression.FirstValue}', was not a valid number.\u001b[0m" };
			}
			if (decimal.TryParse(expression.SecondValue, out decimal secondOperand) == false)
			{
				return new EvaluationResult { ErrorMessage = $"\u001b[31mThe second number, '{expression.SecondValue}', was not a valid number.\u001b[0m" };
			}
			expression.FirstNumber = firstOperand;
			expression.SecondNumber = secondOperand;

			decimal result;
			switch (expression.Operator)
			{
				case "+":
					result = expression.ContinueLastOperation ? prevResult + secondOperand : firstOperand + secondOperand;
					break;
				case "-":
					result = expression.ContinueLastOperation ? prevResult - secondOperand : firstOperand - secondOperand;
					break;
				case "*":
					result = expression.ContinueLastOperation ? prevResult * secondOperand : firstOperand * secondOperand;
					break;
				case "/":
					result = expression.ContinueLastOperation ? prevResult / secondOperand : firstOperand / secondOperand;
					break;
				default:
					return new EvaluationResult { ErrorMessage = $"\u001b[31m'{expression.Operator}' is not a valid operator please use of of these: '+', '-', '*', '/'\u001b[0m" };
			}

			return new EvaluationResult { Result = result };
		}
	}
}
