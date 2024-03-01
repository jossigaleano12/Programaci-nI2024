using System;

namespace Tarea3
{
    internal class Desafío1
    {
        static void Main(string[] args)
        {
            //Pedir datos
            Console.WriteLine("Ingrese su nombre");
            string input0 = Console.ReadLine();
            Console.WriteLine("Ingreso del Primer Mes");
            string input1 = Console.ReadLine();
            Console.WriteLine("Ingreso del Segundo Mes");
            string input2 = Console.ReadLine();
            Console.WriteLine("Ingreso del Tercer Mes");
            string input3 = Console.ReadLine();

            //convirtir datos
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);
            int number3 = Convert.ToInt32(input3);
            string nombre =  input0;
            
            //calculando 
            int result = number1 + number2 + number3;
            int promedio = result/3;

            Console.WriteLine($"Hola " + nombre + " en total ganaste: " + result + " y promediaste " + promedio );
        }

    }
}
