using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerP
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int opcion;
                double saldo = 1000;
                double cantidad;

                Console.WriteLine("Bienvenido al Cajero Automático");
                Console.WriteLine("1. Verificar saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Salir");

                do
                {
                    Console.Write("Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Su saldo es: " + saldo);
                            break;
                        case 2:
                            Console.Write("Ingrese la cantidad a depositar: ");
                            cantidad = double.Parse(Console.ReadLine());
                            saldo += cantidad;
                            Console.WriteLine("Depósito realizado con éxito");
                            break;
                        case 3:
                            Console.Write("Ingrese la cantidad a retirar: ");
                            cantidad = double.Parse(Console.ReadLine());
                            if (cantidad > saldo)
                            {
                                Console.WriteLine("No tiene suficiente saldo para retirar esta cantidad");
                            }
                            else
                            {
                                saldo -= cantidad;
                                Console.WriteLine("Retiro realizado con éxito");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del Cajero Automático");
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                }   while (opcion != 4);
        }
    }

}
