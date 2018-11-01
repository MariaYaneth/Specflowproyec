using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example
{
    [TestClass]
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        
    }

        public int suma(int a, int b)
        {
            return a + b;
        }

        public int resta(int a, int b)
        {
            return a - b;
        }

        public int multiplicar(int a, int b)
        {
            return a * b;
        }
        public int dividir(int a, int b)
        {
            return a / b;
        }
    }
}
