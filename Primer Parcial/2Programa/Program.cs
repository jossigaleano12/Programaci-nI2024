using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double numero;
            double suma = 0;
            int numeros = 0;

            Console.WriteLine("Ingrese números (ingrese 0 para terminar):");

            do
            {
             Console.Write("Ingrese un número: ");
             numero = double.Parse(Console.ReadLine());

              if (numero != 0)
              {
               suma += numero;
               numeros++;
              }
            } while (numero != 0);

            if (numeros > 0)
            {
                double promedio = suma / numeros;
                Console.WriteLine("La suma de los números ingresados es: " + suma);
                Console.WriteLine("El promedio de los números ingresados es: " + promedio);
            }
            else
            {
             Console.WriteLine("No se ingresaron números");
            }
            
        }
    }
    
}
