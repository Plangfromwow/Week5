using CalcApp;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace CalcApp_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestConstructor()
        {
            // test constructor first 
            Calculator c1 = new Calculator(15);
            int actual = c1.number;
            Assert.Equal(15, actual);
        }

        [Fact]
        public void TestFindFactorial()
        {
            // test factorial of 4, which is 24

            Calculator calc = new Calculator(4);
            int actual = calc.FindFactorial();
            Assert.Equal(24, actual);
        }

        [Theory]
        [InlineData(3,6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]

        public void TestFindFactorials(int value, int expected)
        {
            Calculator calc = new Calculator(value);
            int actual = calc.FindFactorial();
            Assert.Equal(expected, actual);
        }

    }
}