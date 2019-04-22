using System;
using Xunit;

namespace Calculadora
{
    public class MultiplicateTests
    {
        public int Multiplicate(int first, int second)
        {
            return first * second;
        }

        [Fact]
        public void OneTimesOneIsOne()
        {
            Assert.Equal(1, Multiplicate(1, 1));
        }

        [Fact]
        public void OneTimesTwoIsTwo()
        {
            Assert.Equal(2, Multiplicate(1, 2));
        }

        [Fact]
        public void FiveTimesElevenIsFiftyFive()
        {
            Assert.Equal(55, Multiplicate(5, 11));
        }
    }
}
