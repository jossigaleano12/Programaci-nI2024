using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana6
{
    internal class numerosp
    {
        string name, city;
        int age;

        public void ingresarnumeros()
        {
            Console.Write("Escriba un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine("¡Le he pedido un número entero positivo!");
            }
            else
            {
                Console.WriteLine("Números pares desde 1 hasta " + numero + ":");

                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}


