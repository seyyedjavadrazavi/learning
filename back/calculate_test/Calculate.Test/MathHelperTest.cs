using ConsoleApp1;
using System;
using Xunit;

namespace Calculate.Test
{
    public class MathHelperTest
    {
        [Fact]
        public void IsEvenTest()
        {
            var cal = new MathFormulas();

            var x = 1;
            var y = 2;

            var res1 = cal.IsEven(x);
            var res2 = cal.IsEven(y);

            Assert.False(res1);
            Assert.True(res2);
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(-1, -4, -3)]
        public void DiffTest(int x, int y, int expectedValue)
        {
            var cal = new MathFormulas();

            var res = cal.Diff(x, y);

            Assert.Equal(res, expectedValue);
        }

        [Theory]
        [InlineData(new int[4] { 1, 2, 3, 4 }, 10)]
        public void SumTest(int[] values, int expectedValue)
        {
            var cal = new MathFormulas();

            var sum = cal.sum(values);

            Assert.Equal(sum, expectedValue);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void AddTest(int x, int y, int expectedValue)
        {
            var cal = new MathFormulas();

            var add = cal.Add(x, y);

            Assert.Equal(add, expectedValue);
        }

        [Theory]
        [InlineData(new int[4] { 1, 2, 3, 4 }, 2)]
        public void AverageTest(int[] values, int expectedValue)
        {
            var cal = new MathFormulas();

            var res = cal.Average(values);

            Assert.Equal(res, expectedValue);
        }


    }
}
