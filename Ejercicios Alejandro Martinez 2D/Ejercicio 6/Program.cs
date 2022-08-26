using System;

namespace Ejercicio_6
{
    internal class Program
    {
        static bool esBisiesto(int año) { 
        
            bool retorno = false;

            if (año % 4 == 0 || (año % 100 != 0 && año % 400 == 0))
            {
                retorno = true;
            }

            return retorno;
        }
        static void Main(string[] args)
        {
            /*
                Escribir un programa que determine si un año es bisiesto.

                Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

                Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
             */

            int añoInicio;
            int añoFin;

            Console.WriteLine("Ingrese año de inicio: ");
            añoInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese año de fin: ");
            añoFin = int.Parse(Console.ReadLine());           

            for (int i = añoInicio; i <= añoFin; i++) {

                if (esBisiesto(i)) {
                    Console.WriteLine("Año bisiesto: " + i);
                }
            }
        }
    }
}
