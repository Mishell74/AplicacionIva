using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iva
{
    class Program
    {
        static void Main(string[] args)
        {
            operaciones impuesto = new operaciones();
            MenúIva menu = new MenúIva();
            Console.WriteLine("Ingrese el valor de su venta y la aplicación se la");
            Console.WriteLine("retorna con el total de IVA a pagar");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(solo aplicable a Guatemala con el 12% de IVA)");

            menu.MenúIva();
            int x;

            Console.WriteLine("Elija su opción");
            x = int.Parse(Console.ReadLine());



            if (x == 1)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ingrese su valor de venta:");
                    Console.WriteLine(impuesto.Iva(float.Parse(Console.ReadLine()), 0.12f));


                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Error, por favor digite el valor en datos numéricos:");
                    Console.WriteLine(impuesto.Iva(float.Parse(Console.ReadLine()), 0.12f));
                }

            }

            else if (x == 2)
            {
                Console.ReadKey();
            }

        }
    }
}