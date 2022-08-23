using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            string numStr;
            int numero;
            int max = int.MaxValue;
            int min = int.MinValue;
            int acumulador = 0;
            float prom;

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Ingrese num");
                numStr = Console.ReadLine();
                numero = int.Parse(numStr);

                if (numero > max || i == 0)
                {
                    max = numero;
                }
                if (numero < min || i == 0)
                {
                    min = numero;
                }

                acumulador += numero;
            }

            prom = (float)acumulador / 5;

            Console.WriteLine("El max: " + max);
            Console.WriteLine("El min: " + min);
            Console.WriteLine("El prom: " + prom);
        }
    }
}
