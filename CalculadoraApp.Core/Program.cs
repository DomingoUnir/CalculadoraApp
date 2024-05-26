using System;

namespace CalculadoraApp.Core
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Elige una opción:");
        Console.WriteLine("1. Sumar dos números");
        Console.WriteLine("2. Restar dos números");
        Console.WriteLine("3. Multiplicar dos números");
        Console.WriteLine("4. Dividir dos números");
        Console.WriteLine("5. Obtener la raíz cuadrada de un número");
        Console.Write("Opción: ");

        int opcion = Convert.ToInt32(Console.ReadLine());
        decimal num1, num2, resultado;

        Calculadora calculadora = new Calculadora();

        switch (opcion)
        {
            case 1:
                Console.Write("Introduce el primer número: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Introduce el segundo número: ");
                num2 = Convert.ToDecimal(Console.ReadLine());
                resultado = calculadora.Sumar(num1, num2);
                Console.WriteLine("El resultado es " + resultado);
                break;
            case 2:
                Console.Write("Introduce el primer número: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Introduce el segundo número: ");
                num2 = Convert.ToDecimal(Console.ReadLine());
                resultado = calculadora.Restar(num1, num2);
                Console.WriteLine("El resultado es " + resultado);
                break;
            case 3:
                Console.Write("Introduce el primer número: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Introduce el segundo número: ");
                num2 = Convert.ToDecimal(Console.ReadLine());
                resultado = calculadora.Multiplicar(num1, num2);
                Console.WriteLine("El resultado es " + resultado);
                break;
            case 4:
                Console.Write("Introduce el primer número: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Introduce el segundo número: ");
                num2 = Convert.ToDecimal(Console.ReadLine());
                if (num2 != 0)
                {
                    resultado = calculadora.Dividir(num1, num2);
                    Console.WriteLine("El resultado es " + resultado);
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero");
                }
                break;
            case 5:
                Console.Write("Introduce un número: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                if (num1 >= 0)
                {
                    resultado = calculadora.RaizCuadrada(num1);
                    Console.WriteLine("El resultado es " + resultado);
                }
                else
                {
                    Console.WriteLine("No se puede obtener la raíz cuadrada de un número negativo");
                }
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}
}
