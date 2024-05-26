using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp.Core.Tests
{
    public class CalculadoraAppTest
    {

        public void ShouldSumTwoNumbers()
        {
            // Arrange
            var calculadora = new CalculadoraApp();
            var number1 = 10;
            var number2 = 20;

            // Act
            var result = calculadora.Somar(number1, number2);

            // Assert
            Assert.AreEqual(30, result);
        }
    }
}
