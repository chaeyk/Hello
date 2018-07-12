using System;
using Xunit;
using Hello;

namespace HelloTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator calc = new Calculator();
            Assert.Equal(3, calc.Add(1, 2));
        }
    }
}
