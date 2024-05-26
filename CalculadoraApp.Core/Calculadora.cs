namespace CalculadoraApp.Core
{
    public class Calculadora
    {
        public Calculadora()
        {
        }

        public decimal Sumar(decimal numero1, decimal numero2)
        {
            return numero1 + numero2;
        }

        public decimal Restar(decimal numero1, decimal numero2)
        {
            return numero1 - numero2;
        }

        public decimal Multiplicar(decimal numero1, decimal numero2)
        {
            return numero1 * numero2;
        }

        public decimal Dividir(decimal numero1, decimal numero2)
        {
            return numero1 / numero2;
        }

        public decimal RaizCuadrada(decimal number)
        {
            // This will be the nearest 
            // perfect square to s
            int pSq = 0;

            //This is the sqrt of pSq
            int N = 0;

            // Find the nearest perfect square to s
            for (int i = (int)(number); i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    if (j * j == i)
                    {
                        pSq = i;
                        N = j;
                        break;
                    }
                }

                if (pSq > 0)
                    break;
            }

            // calculate d 
            decimal d = number - pSq;

            // calculate P
            decimal P = d / (2.0m * N);

            // calculate A
            decimal A = N + P;

            // calculate sqrt(S).
            decimal sqrt_of_s = A - ((P * P) / (2.0m * A));

            return sqrt_of_s;
        }


    }
}