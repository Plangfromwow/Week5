using Xunit;
using ClassReview;

namespace ClassReviewTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Rectangle r1 = new Rectangle(10.0m, 20.0m);
            decimal actual = r1.perim();
            Assert.Equal(60m, actual);

        }
        [Fact]
        public void TestArea()
        {
            Rectangle r1 = new Rectangle(10.0m, 20.0m);
            decimal actual = r1.area();
            Assert.Equal(200m, actual);
        }

        // fact means Test not sure why because Microsoft
        [Fact]

        public void TestCheckRange9()
        {
            // Rule - One test per test function

            bool actual = Misc.CheckRange(9);
            Assert.Equal(false,actual);

        }

        [Fact]
        public void TestCheckRange10()
        {
            // Rule - One test per test function

            bool actual = Misc.CheckRange(10);
            Assert.Equal(true, actual);

        }
        [Fact]
        public void TestCheckRange15()
        {
            // Rule - One test per test function

            bool actual = Misc.CheckRange(15);
            Assert.Equal(true, actual);

        }
        [Fact]
        public void TestCheckRange20()
        {
            // Rule - One test per test function

            bool actual = Misc.CheckRange(20);
            Assert.Equal(true, actual);

        }

        [Fact]
        public void TestCheckRange21()
        {
            // Rule - One test per test function

            bool actual = Misc.CheckRange(21);
            Assert.Equal(false, actual);

        }

        [Fact]
        public void TestPosNegMinus2()
        {
            int actual = Misc.PosNeg(-2);
            Assert.Equal(-1, actual);
        }
        [Fact]
        public void TestPosNegMinus1()
        {
            int actual = Misc.PosNeg(-1);
            Assert.Equal(-1, actual);
        }
        [Fact]
        public void TestPosNegZero()
        {
            int actual = Misc.PosNeg(0);
            Assert.Equal(0, actual);
        }
        [Fact]
        public void TestPosNeg1()
        {
            int actual = Misc.PosNeg(1);
            Assert.Equal(1, actual);
        }
        [Fact]
        public void TestPosNeg2()
        {
            int actual = Misc.PosNeg(2);
            Assert.Equal(1, actual);
        }
    }
}