using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

              El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

              Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
             */

           
            int aumento = 1;
            int numero;
            int contadorCentros = 0;
            
            int sumaAtras;
            int sumaAdelante;

            
            Console.Write("Ingrese un numero (ej. 5): ");
            numero = int.Parse(Console.ReadLine());

            
            while (aumento < numero)
            {
                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                
                for (int i = 1; i < aumento; i++)
                {
                    sumaAtras += i;
                }
                
                for (int j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante += j;
                }

                if (sumaAtras == sumaAdelante && contadorCentros < 4)
                {
                    Console.WriteLine("Es centro numerico: {0}", aumento);
                    Console.WriteLine(contadorCentros);
                    contadorCentros++;
                }
            }
            Console.ReadLine();

        }
    }
}
