using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador
{
    internal class Class1
    {
        // Clase Base
        public class Calculadora
        {
            // Atributos
            public string Marca { get; set; }
            public string Serie { get; set; }

            // Métodos
            public int Sumar(int a, int b)
            {
                return a + b;
            }

            public int Restar(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }

            public int Dividir(int a, int b)
            {
                if (b == 0)
                {
                    throw new System.DivideByZeroException();
                }
                return a / b;
            }
        }

        // SubClase
        public class CalculadoraCientifica : Calculadora
        {
            // Métodos
            public double Potencias(double a, double b)
            {
                return Math.Pow(a, b);
            }

            public double Raiz(double a)
            {
                return Math.Sqrt(a);
            }

            public double Modulo(double a, double b)
            {
                return a % b;
            }

            public double Logaritmo(double a)
            {
                return Math.Log10(a);
            }
        }
        
    }
}
