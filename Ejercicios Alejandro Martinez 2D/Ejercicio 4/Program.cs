using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static bool esPerfecto(int n) {

            int acumuladorDivisores = 0;
            bool retorno = false;

            for (int i = 1; i < n; i++) {

                if (n % i == 0) {
                    acumuladorDivisores += i;

                    if (acumuladorDivisores > n) {
                        retorno = false;
                    }
                }
            }
            if (acumuladorDivisores == n) {
                retorno = true;
            } 
            return retorno;
        }
        static void Main(string[] args)
        {
            /*
              Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

              El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

              Escribir una aplicación que encuentre los 4 primeros números perfectos.
             */
            string numStr;
            int num;           

            Console.WriteLine("Ingrese num mayor a 0: (ej. 4): ");
            numStr = Console.ReadLine();

            num = int.Parse(numStr);

            for (int i = 1; i < num; i++)
            {
                if (esPerfecto(i))
                {
                    Console.WriteLine(i);
                }
            }

                        
        }
    }
}
