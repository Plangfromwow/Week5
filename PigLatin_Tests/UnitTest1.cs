using PigLatin;

namespace PigLatin_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestIsVowel1()
        {
            bool actual = Translator.isVowel('a');
            Assert.True(actual);
        }
        [Fact]
        public void TestIsVowel2()
        {
            bool actual = Translator.isVowel('e');
            Assert.True(actual);
        }
        [Fact]
        public void TestIsVowel3()
        {
            bool actual = Translator.isVowel('i');
            Assert.True(actual);
        }
        [Fact]
        public void TestIsVowel4()
        {
            bool actual = Translator.isVowel('o');
            Assert.True(actual);
        }
        [Fact]
        public void TestIsVowel5()
        {
            bool actual = Translator.isVowel('u');
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

        [Fact]
        public void PigLatin1()
        {
            string actual = Translator.PigLatinize("banana");
            Assert.Equal("ananabay", actual);
        }
        [Fact]
        public void PigLatin2()
        {
            string actual = Translator.PigLatinize("eat");
            Assert.Equal("eatyay", actual);
        }

        [Fact]
        public void PigLatinEmptyString()
        {
            string actual = Translator.PigLatinize("");
            Assert.Equal("Sorry, please enter a valid word.", actual);
        }
    }
}