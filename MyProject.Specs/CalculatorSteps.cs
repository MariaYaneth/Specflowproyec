using Example;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace MyProject.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private int result;
        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
        [Then(@"the result de la suma")]
        public int Retur_suma(int A,int B)
        {
            result = calculator.suma(A,B);
            return result;
        }
        [Then(@"the result de la resta")]
        public int Retur_resta(int A, int B)
        {
            result = calculator.resta(A, B);
            return result;
        }
        [Then(@"the result de la multiplicacion")]
        public int Retur_multiplicar(int A, int B)
        {
            result = calculator.multiplicar(A, B);
            return result;
        }
        [Then(@"the result de la division")]
        public int Retur_dividir(int A, int B)
        {
            result = calculator.dividir(A, B);
            return result;
        }
    }
}
