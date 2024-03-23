using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    internal class CalculadoraDeDescuento
    {
        static void DescuentoAplicado(double[,] Compras)
        {
            for (int Cliente = 0; Cliente < 5; Cliente++)
            {
                double total = 0;
                for (int compra = 0; compra < 5; compra++)
                {
                    total += Compras[Cliente, compra];
                }

                double descuento = 0;

                if (total > 1000)
                {
                    descuento = total * 0.2;
                }
                else if (total > 100)
                {
                    descuento = total * 0.1;
                }

                Console.WriteLine($"Cliente {Cliente + 1} total: {total} - Descuento: {descuento} - Total a pagar: {total - descuento}");
            }
        }

        static void Main(string[] args)
        {
            double[,] Compras = new double[5, 5]
                                {
                                 { 121, 155, 181, 195, 231 },
                                 { 122, 154, 182, 194, 232 },
                                 { 123, 153, 183, 193, 233 },
                                 { 124, 152, 184, 192, 234 },
                                 { 125, 151, 185, 191, 235 }
                                };

            DescuentoAplicado(Compras);
        }
    }
}

