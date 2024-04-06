using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculador.Class1;

namespace Calculador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia de la clase base
            Calculadora calculadora = new Calculadora();
            calculadora.Marca = "HP";
            calculadora.Serie = "1234";

            Console.WriteLine("Suma: " + calculadora.Sumar(5, 3));
            Console.WriteLine("Resta: " + calculadora.Restar(5, 3));
            Console.WriteLine("Multiplicación: " + calculadora.Multiplicar(5, 3));
            Console.WriteLine("División: " + calculadora.Dividir(5, 3));

            // Instancia de la subclase
            CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica();
            calculadoraCientifica.Marca = "Casio";
            calculadoraCientifica.Serie = "5678";

            Console.WriteLine("Potencia: " + calculadoraCientifica.Potencias(5, 3));
            Console.WriteLine("Raíz: " + calculadoraCientifica.Raiz(9));
            Console.WriteLine("Módulo: " + calculadoraCientifica.Modulo(5, 3));
            Console.WriteLine("Logaritmo: " + calculadoraCientifica.Logaritmo(1000));
        }
    }
}
