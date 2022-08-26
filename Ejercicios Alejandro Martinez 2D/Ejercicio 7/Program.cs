using System;

namespace Ejercicio_7
{
    internal class Program
    {
        static int Main(string[] args)
        {
            /*
            Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas).
            Hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
             */

            const int valorAntiguedad = 150;
            const float porcentajeDescuento = 1.13f;

            int valorHora;
            int antiguedad;
            int cantidadHorasTrabajadas;
            int importeACobrar;
            float importeACobrarConDescuento;
            int aumentoPorAntiguedad;

            int rta = 0;
            bool respuesta = true;

            while (true) {

                Console.WriteLine("Ingrese el vlaor de la hora");
                valorHora = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese años de antiguedad");
                antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Cantidad de horas trabajadas");
                cantidadHorasTrabajadas = int.Parse(Console.ReadLine());

                importeACobrar = valorHora * cantidadHorasTrabajadas;

                aumentoPorAntiguedad = antiguedad * valorAntiguedad;

                importeACobrar = aumentoPorAntiguedad + importeACobrar;
                importeACobrarConDescuento = (float) importeACobrar / porcentajeDescuento;

                Console.WriteLine("Ingrese '1' para ingresar otro empleado");
                int.Parse(Console.ReadLine());

                if(rta != 1) {
                    respuesta = false;
                }

                // INFORMES.

            }
        }
    }
}
