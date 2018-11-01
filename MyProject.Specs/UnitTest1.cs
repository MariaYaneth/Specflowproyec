using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Specs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaSuma()
        {
            var calculator = new CalculatorSteps();
            var result = calculator.Retur_suma(7, 6);
            Assert.AreEqual(13, result);
        }
        [TestMethod]
        public void PruebaResta()
        {
            var calculator = new CalculatorSteps();
            var result = calculator.Retur_resta(7, 6);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void PruebaMultiplicar()
        {
            var calculator = new CalculatorSteps();
            var result = calculator.Retur_multiplicar(7, 6);
            Assert.AreEqual(42, result);
        }
        [TestMethod]
        public void PruebaDividir()
        {
            var calculator = new CalculatorSteps();
            var result = calculator.Retur_dividir(12, 6);
            Assert.AreEqual(2, result);
        }
    }
}
