using System;

namespace Ejercicio_8
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

            // Console.WriteLine("*");
            // Console.WriteLine("***");
            //Console.WriteLine("*****");
            //Console.WriteLine("*******");
            //Console.WriteLine("*********");

            int cantidadDeReglones;            
            int largo = 1;

            Console.WriteLine("Ingrese cantidad de reglones para el triangulo: ");
            cantidadDeReglones = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < cantidadDeReglones; i++) {
                for(int j = 0; j < largo; j++) {
                    Console.Write("*");
                }
                largo += 2;
                Console.WriteLine();
            }                           
        }
    }
}
