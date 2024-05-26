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
            var calculadora = new Calculadora();
            var number1 = 10.3;
            var number2 = 20.2;

            // Act
            var result = calculadora.Sumar(number1, number2);

            // Assert
            Assert.Equal(30.5, result);


        }
    }
}
