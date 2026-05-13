using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}