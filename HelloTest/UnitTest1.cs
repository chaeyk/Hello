using System;
using Xunit;
using Hello;

namespace HelloTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(-10, 10, 0)]
        public void AddTest(int v1, int v2, int result)
        {
            Calculator calc = new Calculator();
            Assert.Equal(result, calc.Add(v1, v2));
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(-1, -2, 1)]
        [InlineData(-10, 10, -20)]
        public void SubTest(int v1, int v2, int result)
        {
            Calculator calc = new Calculator();
            Assert.Equal(result, calc.Sub(v1, v2));
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(-1, -2, 2)]
        [InlineData(-10, 10, -100)]
        [InlineData(3, 0, 0)]
        public void MulTest(int v1, int v2, int result)
        {
            Calculator calc = new Calculator();
            Assert.Equal(result, calc.Mul(v1, v2));
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(3, 1, 3)]
        [InlineData(6, -2, -3)]
        [InlineData(-12, -3, 4)]
        [InlineData(8, 3, 2)]
        [InlineData(7, 3, 2)]
        public void DivTest(int v1, int v2, int result)
        {
            Calculator calc = new Calculator();
            Assert.Equal(result, calc.Div(v1, v2));
        }

        [Fact]
        public void DivZeroTest()
        {
            Calculator calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Div(1, 0));
        }
    }
}
