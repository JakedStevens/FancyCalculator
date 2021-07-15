using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
	public class ParseExpression
	{
		public Expression ParseUserInput(string input)
		{
            var expression = new Expression();
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
            else if (input.Contains("/"))
            {
                expressionBits = input.Split("/");
                expression.FirstValue = expressionBits[0].Trim(' ');
                expression.SecondValue = expressionBits[1].Trim(' ');
                expression.Operator = "/";
            }
			else
			{
                expression.ExpressionHasError = true;
                expression.ErrorMessage = "\u001b[31mYou didnt not enter in a valid operator for your expression.\u001b[0m";
			}

            if (expression.FirstValue == "")
			{
                expression.ContinueLastOperation = true;
			}

            return expression;
        }
	}
}
