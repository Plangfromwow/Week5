using PigLatin;

namespace PigLatin_Tests
{
    public class UnitTest1
    {
        // we can test 5 letter seperately 

        //[Fact]
        //public void TestIsVowel1()
        //{
        //    bool actual = Translator.isVowel('a');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestIsVowel2()
        //{
        //    bool actual = Translator.isVowel('e');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestIsVowel3()
        //{
        //    bool actual = Translator.isVowel('i');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestIsVowel4()
        //{
        //    bool actual = Translator.isVowel('o');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestIsVowel5()
        //{
        //    bool actual = Translator.isVowel('u');
        //    Assert.True(actual);
        //}
        [Theory]
        [InlineData('a')]
        [InlineData('e')]
        [InlineData('i')]
        [InlineData('o')]
        [InlineData('u')]

        public void TestIsVowel(char value)
        {
            bool actual = Translator.isVowel(value);
            Assert.True(actual);
        }


        [Fact]
        public void TestIsVowel6()
        {
            bool actual = Translator.isVowel('s');
            Assert.False(actual);
        }
        [Fact]
        public void TestIsVowel7()
        {
            bool actual = Translator.isVowel('z');
            Assert.False(actual);
        }

        [Fact]
        public void TestStartsWithConst()
        {
            bool actual = Translator.StartsWithVowel("school");
            Assert.False(actual);
        }

        [Fact]
        public void TestStartsWithVowelA()
        {
            bool actual = Translator.StartsWithVowel("apple");
            Assert.True(actual);
        }

        [Fact]
        public void TestNumOfCons1()
        {
            int actual = Translator.NumberOfCons("banana");
            Assert.Equal(1, actual);
        }
        [Fact]
        public void TestNumOfCons2()
        {
            int actual = Translator.NumberOfCons("shout");
            Assert.Equal(2, actual);
        }
        [Fact]
        public void TestNumOfCons3()
        {
            int actual = Translator.NumberOfCons("school");
            Assert.Equal(3, actual);
        }

        [Fact]
        public void TestPLVowel1()
        {
            string actual = Translator.PigLatinVowels("apple");
            Assert.Equal("appleyay", actual);
        }

        [Fact]
        public void TestPLVowel2()
        {
            string actual = Translator.PigLatinVowels("every");
            Assert.Equal("everyyay",actual);
        }

        [Fact]
        public void TestPLCons1()
        {
            string actual = Translator.PigLatinCons("school");
            Assert.Equal("oolschay", actual);
        }

        [Fact]
        public void TestPLCons2()
        {
            string actual = Translator.PigLatinCons("banana");
            Assert.Equal("ananabay", actual);
        }

        //[Fact]
        //public void PigLatin1()
        //{
        //    string actual = Translator.PigLatinize("banana");
        //    Assert.Equal("ananabay", actual);
        //}
        //[Fact]
        //public void PigLatin2()
        //{
        //    string actual = Translator.PigLatinize("eat");
        //    Assert.Equal("eatyay", actual);
        //}

        [Theory]
        [InlineData("banana", "ananabay")] // the test case followed by expected result 
        [InlineData("eat", "eatyay")]

        public void TestPigLatinize(string value, string expected)
        {
            string actual = Translator.PigLatinize(value);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void PigLatinEmptyString()
        {
            string actual = Translator.PigLatinize("");
            Assert.Equal("Sorry, please enter a valid word.", actual);
        }
    }
}