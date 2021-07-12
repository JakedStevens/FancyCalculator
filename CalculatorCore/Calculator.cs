using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {
        public EvaluationResult Evaluate(string input)
        {
            string[] expressionBits = input.Split(" ");

            decimal firstOperand;
            decimal secondOperand;

            if (decimal.TryParse(expressionBits[0], out firstOperand) == false)
            {
                return new EvaluationResult { ErrorMessage = $"The first number, '{expressionBits[0]}', was not a valid number." };
            }
            if (decimal.TryParse(expressionBits[2], out secondOperand) == false)
            {
                return new EvaluationResult { ErrorMessage = $"\u001b[35mThe second number, '{expressionBits[2]}', was not a valid number.\u001b[0m" };
            }

            string op = expressionBits[1];
            decimal result;

            switch (op)
			{
                case "+":
                    result = firstOperand + secondOperand;
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    break;
                case "/":
                    result = firstOperand / secondOperand;
                    break;
                default:
                    throw new NotImplementedException($"The operator {op} was used and is invalid.");
			}

            return new EvaluationResult { Result = result };
        }
    }
}
