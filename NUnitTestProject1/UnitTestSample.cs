using DotNetCoreWebApiTest;
using DotNetCoreWebApiTest.Controllers;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class UnitTestSample
    {
        private ICalculator calculator;
        private CalculatorController calculatorController;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
            calculatorController = new CalculatorController(calculator);
        }

        [Test]
        public void CalculatorAddTest()
        {
            int addResult = calculatorController.Add(2, 3);

            Assert.IsTrue(addResult == 5);
        }
    }
}