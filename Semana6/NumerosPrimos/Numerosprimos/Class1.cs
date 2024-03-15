using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerosprimos
{
    internal class Class1
    {
        public void NumerosPrimos()
        {
            Console.Write("Ingrese un numero entero positivo: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 2)
            {
                Console.WriteLine("{0} no es un numero primo", num);
            }
            else
            {
                bool primo = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine("{0} es un numero primo", num);
                }
                else
                {
                    Console.WriteLine("{0} no es un numero primo", num);
                }
            }
        }
    }
}
