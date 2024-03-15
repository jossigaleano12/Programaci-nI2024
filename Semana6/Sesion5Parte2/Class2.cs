using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion5Parte2
{
    internal class Class2
    {
        //Se crea una clase llamada caja
        class Caja
        {
            //Se declaran los datos de la caja
            public double Ancho { get; set; }
            public double ALto { get; set; }
            public double Profundidad { get; set; }

            //Se declaran las variables y tipo de entrada
            public Caja(double width, double height, double depth)
            {
                Ancho = width;
                ALto = height;
                Profundidad = depth;
            }
            //Se coloca el metodo voluman y lo que retornara
            public double Volume()
            {
                return Ancho * ALto * Profundidad;
            }
        }

        //Se crea el programa
        class Program
        {
            static void Main()
            {
                //se crea una lista de cajas
                List<Caja> boxes = new List<Caja>()
                {
                    //se colocan los datos de la caja en el orden que se declararon
                      new Caja(1, 2, 3),
                      new Caja(4, 5, 6),
                      new Caja(7, 8, 9)
                };

                //se calcula el volumen promedio de las cajas
                double totalVolume = 0;
                foreach (Caja box in boxes)
                {
                    totalVolume += box.Volume();
                }

                double averageVolume = totalVolume / boxes.Count;

                // se imprimen los resultados
                Console.WriteLine("Volumen total: " + totalVolume);
                Console.WriteLine("Volumen promedio: " + averageVolume);

                Console.ReadKey();
            }
        }
    }
}
