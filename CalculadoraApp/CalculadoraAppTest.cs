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

        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();
            decimal number1 = 10.3m;
            decimal number2 = 20.2m;

            // Act
            decimal result = calculadora.Multiplicar(number1, number2);

            // Assert
            Assert.Equal(208.06m, result);
        }

        [Fact]
        public void ShouldDivideTwoNumbers()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();
            decimal number1 = 10.3m;
            decimal number2 = 20.2m;

            // Act
            decimal result = calculadora.Dividir(number1, number2);

            // Assert
            Assert.Equal(0.5099009900990099009900990099m, result);
        }


        [Fact]

        public void SouldSquareRootANumber()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();
            decimal number = 5.0m;
            decimal expected = 2.2360679774997896964091736687m;


            // Act
            decimal result = calculadora.RaizCuadrada(number);

            // Assert
            Assert.True(Math.Abs(expected-result) < 0.001m);
        }
    }
}
