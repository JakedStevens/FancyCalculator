using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore
{
	public class EvaluationResult
	{
		public decimal Result { get; set; }
		public decimal PreviousResult { get; set; }
		public string ErrorMessage { get; set; }
		public Expression Expression { get; set; }
	}
}
