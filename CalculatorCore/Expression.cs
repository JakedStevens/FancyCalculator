using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
	public class Expression
	{
		public string FirstValue { get; set; }
		public string SecondValue { get; set; }

		public decimal FirstNumber { get; set; }
		public decimal SecondNumber { get; set; }

		public string Operator { get; set; }

		public bool ContinueLastOperation { get; set; }

		public bool ExpressionHasError { get; set; }
		public string ErrorMessage { get; set; }
	}
}
