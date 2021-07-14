using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
    public class Calculator
    {
        public EvaluationResult Evaluate(string input, bool shouldUsePrevVal, decimal prevResult)
        {
            Expression expression = new Expression();
            string[] expressionBits;

            if (input.Contains("+"))
			{
                expressionBits = input.Split("+");
                expression.FirstValue = expressionBits[0].Trim(' ');
                expression.SecondValue = expressionBits[1].Trim(' ');
                expression.Operator = "+";
            }
            else if (input.Contains("-"))
			{
                expressionBits = input.Split("-");
                expression.FirstValue = expressionBits[0].Trim(' ');
                expression.SecondValue = expressionBits[1].Trim(' ');
                expression.Operator = "-";
            }
            else if (input.Contains("*"))
            {
                expressionBits = input.Split("*");
                expression.FirstValue = expressionBits[0].Trim(' ');
                expression.SecondValue = expressionBits[1].Trim(' ');
                expression.Operator = "*";
            }
            else
            {
                expressionBits = input.Split("/");
                expression.FirstValue = expressionBits[0].Trim(' ');
                expression.SecondValue = expressionBits[1].Trim(' ');
                expression.Operator = "/";
            }
            
            decimal firstOperand;
            decimal secondOperand;
            if (expressionBits.Length != 2)
            {
                return new EvaluationResult { ErrorMessage = $"\u001b[31mYour entry was invalid, two numbers with an operator inbetween them are required ex: 1 + 1\u001b[0m" };
            }
            if ((decimal.TryParse(expression.FirstValue, out firstOperand) == false) && shouldUsePrevVal == false)
            {
                return new EvaluationResult { ErrorMessage = $"\u001b[31mThe first number, '{expression.FirstValue}', was not a valid number.\u001b[0m" };
            }
            if ((decimal.TryParse(expression.SecondValue, out secondOperand) == false) && shouldUsePrevVal == false)
            {
                return new EvaluationResult { ErrorMessage = $"\u001b[31mThe second number, '{expression.SecondValue}', was not a valid number.\u001b[0m" };
            }
            expression.FirstNumber = firstOperand;
            expression.SecondNumber = secondOperand;

            decimal result;
            switch (expression.Operator)
			{
                case "+":
                    result = shouldUsePrevVal ? prevResult + secondOperand : firstOperand + secondOperand;
                    break;
                case "-":
                    result = shouldUsePrevVal ? prevResult - secondOperand : firstOperand - secondOperand;
                    break;
                case "*":
                    result = shouldUsePrevVal ? prevResult * secondOperand : firstOperand * secondOperand;
                    break;
                case "/":
                    result = shouldUsePrevVal ? prevResult / secondOperand : firstOperand / secondOperand;
                    break;
                default:
                    return new EvaluationResult { ErrorMessage = $"\u001b[31m'{expression.Operator}' is not a valid operator please use of of these: '+', '-', '*', '/'\u001b[0m" };
            }

            return new EvaluationResult { Result = result };
        }
    }
}
