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
            Assert.Equal(6, x);
        }
    }
}
