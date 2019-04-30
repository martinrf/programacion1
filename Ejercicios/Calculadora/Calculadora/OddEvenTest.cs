using Xunit;

namespace Calculadora
{
    public class OddEvenTest
    {
        // para saber si un numero es par o no, el modulo 2 es 0 o el, resto de la division entera con 2 es 0.
        public string ParityCheck(int number)
        {
            var resto = number % 2;                        
            if (resto == 0)
            {
                return "Es Par";
            }
            else
            {
                return "Es Impar";
            }
        }

        public string SignCheck(int number)
        {
            var result = "";
            if (number > 0)
            {
                result = "Es Positivo";
            }
            else if (number == 0)
            {
                result = "Es Cero";
            }
            else if (number < 0)
            {
                result = "Es Negativo";                
            }
            return result;
        }

        [Fact]
        public void EsPositivo()
        {
            Assert.Equal("Es Positivo", SignCheck(2));
        }

        [Fact]
        public void EsNegativo()
        {
            Assert.Equal("Es Negativo", SignCheck(-1337));
        }

        [Fact]
        public void EsCero()
        {
            Assert.Equal("Es Cero", SignCheck(0));
        }

        [Fact]
        public void TwoIsEven()
        {
            Assert.Equal("Es Par", ParityCheck(2));
        }

        [Fact]
        public void FiveIsOdd()
        {
            Assert.Equal("Es Impar", ParityCheck(5));
        }
    }
}
