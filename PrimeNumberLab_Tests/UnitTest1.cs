using PrimeNumberLab;
using Xunit.Sdk;

namespace PrimeNumberLab_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestConstructor()
        {
            // test constructor
            PrimeNumber num = new PrimeNumber(0);
            int actual = num.number;
            Assert.Equal(0, actual);
        }

        [Theory]        
        [InlineData(1,2)]
        [InlineData(2,3)]
        [InlineData(6,13)]
        [InlineData(22,79)]       

        public void TestgetPrimeNumber(int value, int expected)
        {
            // can't really test outliars because of the way that this works
            PrimeNumber num = new PrimeNumber(value);
            int actual = num.getPrimeNumber();
            Assert.Equal(expected, actual);
        }

    }
}