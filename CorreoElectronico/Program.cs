using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CorreoElectronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Este es mi correo electrónico: josselinegaleano@gmail.com. " +
                "Cualquier duda tambien puede escribir al siguiente correo: Jossgaleano12@gmail.com." + 
                "Para una respuesta mas rapida puedes escribirme a: jgaleanoh@miumg.edu.gt";

            Regex emailRegex = new Regex(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");

            MatchCollection matches = emailRegex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
