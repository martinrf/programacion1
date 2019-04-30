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

        public bool EsPerro()
        {
            return true;
        }

        public bool EsGato()
        {
            return false;
        }

        [Fact]
        public void OneTimesOneIsOne()
        {
            bool flag = true;
            bool Noflag = false;
            bool miVarBool = true;
            int miVarInt = 4;
            string miVarString = "";
            var miVarString2 = "";


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
