using Diamond;

namespace Diamond_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestOneLine()
        {
            string actual = DrawDiamond.OneLine('C', 'A');
            string expected = "..A..";
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestDraw1()
        {
            string actual = DrawDiamond.OneLine('E', 'C');
            string expected = "..C...C..";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('E','A',"....A....")]
        [InlineData('E','B',"...B.B...")]
        [InlineData('E','C',"..C...C..")]

        public void TestDrawTheory(char dletter, char rletter, string expected)
        {
            string actual = DrawDiamond.OneLine(dletter, rletter);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalcPadding()
        {
            int actual = DrawDiamond.CalcPadding('E','C');
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('E', 'A', 4)]
        [InlineData('E','C',2)]
        [InlineData('E','B',3)]
        [InlineData('E', 'D', 1)]
        public void CalcPaddingTheory(char dletter, char rletter, int expected)
        {
            int actual = DrawDiamond.CalcPadding(dletter, rletter);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalcSpacing()
        {
            int actual = DrawDiamond.calcSpacing('C');
            Assert.Equal(3, actual);
        }

        [Theory]
        [InlineData('C',3)]
        [InlineData('D',5)]
        [InlineData('A',0)]
        [InlineData('B', 1)]
        [InlineData('Z',49)]

        public void CalcSpacingTheory(char value, int expected)
        {
            int actual = DrawDiamond.calcSpacing(value);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMakeSpaces()
        {
            string actual = DrawDiamond.MakeSpaces(2);
            Assert.Equal("..", actual);
        }


        [Theory]
        [InlineData(3,"...")]
        [InlineData(4,"....")]
        [InlineData(8,"........")]

        public void MakeSpacesTheory(int value, string expected)
        {
            string actual = DrawDiamond.MakeSpaces(value);
            Assert.Equal(expected, actual);
        }
    }
}