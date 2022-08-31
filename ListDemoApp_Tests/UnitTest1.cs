using ListDemoApp;

namespace ListDemoApp_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestRemoveLargest()
        {
            List<int> input = new List<int>() { 5, 6, 3, 20 };
            List<int> expected = new List<int>() { 5, 6, 3 };

            List<int> actual = MyLists.RemoveLargest(input);

            Assert.Equal(expected, actual);

        }
        // test ideas. 
        // basic 
        // double greatest
        // empty list 
        // all the same 
        // only one 

        [Theory]
        [InlineData(new int[] { 5, 20, 6, 3 }, new int[] { 5, 6, 3 })]
        [InlineData(new int[] { 5, 20, 6, 20, 3 }, new int[] { 5, 6, 20, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 5, 5, 5, 5 }, new int[] { 5, 5, 5 })]
        [InlineData(new int[] { 5 }, new int[] { })]
        public void RemoveLargestTheory(int[] valuesarray, int[] expectedarray)
        {
            List<int> values = new List<int>(valuesarray);
            List<int> expected = new List<int>(expectedarray);

            List<int> actual = MyLists.RemoveLargest(values);

            Assert.Equal(expected, actual);


        }
    }
}