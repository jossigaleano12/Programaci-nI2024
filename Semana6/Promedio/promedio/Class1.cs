using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedio
{
    internal class Class1
    {
        public void Promedio()
        {
            int suma = 0;
            int Punteos = 0;
            double Promedio;

            while (true)
            {
                Console.Write("Ingrese una puntuación entre 1 y 10 (o escriba 'fin' para calcular el promedio): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "fin")
                {
                    if (Punteos == 0)
                    {
                        Console.WriteLine("No se ingresaron punteos.");
                    }
                    else
                    {
                        Promedio = (double)suma / Punteos;
                        Console.WriteLine("El promedio es {0}", Promedio);
                    }
                    break;
                }

                if (!int.TryParse(input, out int Puntos))
                {
                    Console.WriteLine("Solo se pueden ingresar numero o la palabra fin.");
                    continue;
                }

                if (Puntos < 1 || Puntos > 10)
                {
                    Console.WriteLine("La puntuación debe estar entre 1 y 10. Inténtalo de nuevo..");
                    continue;
                }

                suma += Puntos;
                Punteos++;
            }
        }
    }
}
