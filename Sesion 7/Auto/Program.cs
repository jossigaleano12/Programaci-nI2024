using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Auto.Class1;

namespace Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW("BMW", "Serie 3", 2015);
            bmw.RepararBMW("Cambio de aceite");
            bmw.RepararBMW("Cambio de frenos");
            bmw.LeerHistorialDeReparaciones();
        }
    }
}
