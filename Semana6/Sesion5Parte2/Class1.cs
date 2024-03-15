using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion5Parte2
{
    internal class Class1
    {
        public class Rectangulo
        {
            private readonly int Alto;
            private readonly int Largo;
            public int SuperficieFrontal { get { return Alto * Largo; } }

            public Rectangulo(int alto, int largo)
            {
                Alto = alto;
                Largo = largo;
            }
        }
    }
}
