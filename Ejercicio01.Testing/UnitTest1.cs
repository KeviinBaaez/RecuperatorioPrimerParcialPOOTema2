using Ejercicio01.Entidades;
using Ejercicio04.Entidades;

namespace Ejercicio01.Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RadioEsValido()
        {

            int radio = 5;
            Cilindro cilindro = new Cilindro(radio, 10);
            Assert.IsTrue(radio > 0);
        }
        [TestMethod]
        public void AlturaEsValida()
        {

            int Altura = 5;
            Cilindro cilindro = new Cilindro(10, Altura);
            Assert.IsTrue(Altura > 0);
        }

        [TestMethod]
        public void NumeroEsValido()
        {

            int numero = 35;
            NumeroDivCincoSiete n = new NumeroDivCincoSiete(numero);
            Assert.IsTrue(numero > 0);
        }
        public void EsDivisible()
        {

            int numero = 35;
            NumeroDivCincoSiete n = new NumeroDivCincoSiete(numero);
            Assert.IsTrue(numero%5==0 && numero%7==0);
        }
    }
}