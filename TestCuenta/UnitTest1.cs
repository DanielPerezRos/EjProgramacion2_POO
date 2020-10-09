using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjProgramacion2_POO_4;
namespace TestCuenta
{
    [TestClass]
    public class TestCuenta
    {
        [TestMethod]
        public void PruebaPagos()
        {
            double balanceInicial = 11.99;
            double importeDebitado = 4.55; 
            double importeEsperado = 7.44;

            Cuenta unaCuenta = new Cuenta();
            unaCuenta.saldo = balanceInicial;
            unaCuenta.pago(importeDebitado);

            double actual = unaCuenta.saldo;
            Assert.AreEqual(importeEsperado, actual, 0.001, "La cuenta no tiene el saldo correcto");

        }

        [TestMethod]
        public void PruebaCobros()
        {
            double balanceInicial = 10;
            double importeAcreditado = 4.55;
            double importeEsperado = 14.55;

            Cuenta unaCuenta = new Cuenta();
            unaCuenta.saldo = balanceInicial;
            unaCuenta.recibirAbono(importeAcreditado);

            double actual = unaCuenta.saldo;
            Assert.AreEqual(importeEsperado, actual, 0.001, "La cuenta no tiene el saldo correcto");

        }
    }
}
