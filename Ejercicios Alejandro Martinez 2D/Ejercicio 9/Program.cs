using System;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Escribir un programa que imprima por consola un triángulo como el siguiente:

                                *
                               ***
                              *****
                             *******
                            *********
             */

            int cantidadReglones;
            int cantidadEspacios;
            int cantidadAstericos = 1;

            Console.WriteLine("Ingrese cantidad de reglones para el triangulo: ");
            cantidadReglones = int.Parse(Console.ReadLine());

            cantidadEspacios = cantidadReglones;

            for(int i = 0; i < cantidadReglones; i++) {
                for(int j = 0; j < cantidadEspacios; j++) {
                    Console.Write(" ");
                }
                for(int j = 0; j < cantidadAstericos; j++) {
                    Console.Write("*");
                }

                Console.WriteLine();
                cantidadAstericos += 2;
                cantidadEspacios -= 1;
            }

        }
    }
}
