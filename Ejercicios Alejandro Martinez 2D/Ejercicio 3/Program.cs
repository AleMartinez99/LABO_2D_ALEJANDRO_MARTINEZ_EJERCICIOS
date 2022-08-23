using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.              
            */

            string numStr;
            int num;
            bool esNumero;
            string respuestaStr;
            int respuesta = 0;


            Console.WriteLine("Ingrese un num (ej:3): ");
            numStr = Console.ReadLine();

            while (!(esNumero = int.TryParse(numStr, out num)) && respuesta != 1)
            {

                Console.WriteLine("El dato ingresado no es numero, desea escribirlo devuelta?");
                Console.WriteLine("1 - SALIR");
                Console.WriteLine("Otra tecla - SEGUIR");
                respuestaStr = Console.ReadLine();
                respuesta = int.Parse(respuestaStr);

                if (respuesta == 1)
                {
                    Console.WriteLine("Salio");
                }
                else
                {
                    Console.WriteLine("Reingresando NUMERO: ");
                    numStr = Console.ReadLine();
                }

            }
            for (int i = 2; i < num + 1; i++)
            {
                if (esPar(i))
                {
                    Console.WriteLine(i);
                }

            }
        }

        static bool esPar(int numero)
        {

            for (int i = 2; i < numero; i++)
            {

                if ((numero % i) == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
