using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp.Core.Tests
{
    public class CalculadoraAppTest
    {
        [Fact]
        public void ShouldSumTwoNumbers()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();
            decimal number1 = 10.3m;
            decimal number2 = 20.2m;

            // Act
            var result = calculadora.Sumar(number1, number2);

            // Assert
            Assert.Equal(30.5m, result);

        }

        [Fact]
        public void SouldSubtractTwoNumbers()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();
            decimal number1 = 10.3m;
            decimal number2 = 20.2m;

            // Act
            decimal result = calculadora.Restar(number1, number2);

            // Assert
            Assert.Equal(-9.9m, result);
        }
    }
}
