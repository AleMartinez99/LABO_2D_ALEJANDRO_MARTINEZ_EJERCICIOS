using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".   

            string numStr;
            int num;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese num a: ");
            numStr = Console.ReadLine();
            num = int.Parse(numStr);

            while (num <= 0)
            {
                Console.WriteLine("ERROR... Ingrese num mayor a 0: ");
                numStr = Console.ReadLine();
                num = int.Parse(numStr);
            }

            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);

            Console.WriteLine("El cuadrado: " + cuadrado);
            Console.WriteLine("El cubo: " + cubo);
        }
    }
}
