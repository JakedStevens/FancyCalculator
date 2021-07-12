using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorCore.Tests
{
    [TestClass]
    public class CalculatorCoreTests
    {
        private Calculator _calc;

        [TestInitialize]
        public void SetupOrInitialize()
		{
            _calc = new Calculator();
		}

        [TestMethod]
        public void AddTwoNumbers()
        {
            // arrange
            //var calc = new Calculator();
            // act
            EvaluationResult result = _calc.Evaluate("6 + 8");
            // assert
            Assert.AreEqual(14m, result.Result);
        }

        [TestMethod]
        public void SubtractTwoNumbers()
        {
            EvaluationResult result = _calc.Evaluate("8 - 2");
            Assert.AreEqual(6m, result.Result);
        }

        [TestMethod]
        public void MultiplyTwoNumbers()
        {
            EvaluationResult result = _calc.Evaluate("8 * 2");
            Assert.AreEqual(16m, result.Result);
        }

        [TestMethod]
        public void DivideTwoNumbers()
        {
            EvaluationResult result = _calc.Evaluate("8 / 2");
            Assert.AreEqual(4m, result.Result);
        }

        [TestMethod]
        public void FirstOperandMustBeNumber()
        {
            var result = _calc.Evaluate("fdsalkj + 8");
            Assert.AreEqual("The first number, 'fdsalkj', was not a valid number.", result.ErrorMessage);
        }

        [TestMethod]
        public void SecondOperandMustBeNumber()
        {
            var result = _calc.Evaluate("7 + hello");
            Assert.AreEqual("The second number, 'hello', was not a valid number.", result.ErrorMessage);
        }

    }
}
