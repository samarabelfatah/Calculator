using CalculatorLogic;
using Xunit;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            var x = new Calculator().Sum(1, 2);
            Assert.Equal(x, 3);
        }

        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.Equal(x, 6);
        }
        [Fact]
        public void ShouldSubtractTwoNumbers()
        {
            var x = new Calculator().Subtract(3, 2);
            Assert.Equal(x, 1);
        }

        [Fact]
        public void ShouldDivideTwoNumbers()
        {
            var x = new Calculator().Divide(9, 3);
            Assert.Equal(x, 3);
        }
    }
}
