using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    internal class Class1
    {
        // Clase Auto
        public class Auto
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }
            public List<string> HistoriaDeReparaciones { get; set; }

            public Auto(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
                HistoriaDeReparaciones = new List<string>();
            }

            public void Reparar(string descripcion)
            {
                HistoriaDeReparaciones.Add(descripcion);
                GuardarHistorialDeReparaciones();
            }

            public void GuardarHistorialDeReparaciones()
            {
                string archivo = "historial.txt";

                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    foreach (string reparacion in HistoriaDeReparaciones)
                    {
                        sw.WriteLine(reparacion);
                    }
                }
            }

            public void LeerHistorialDeReparaciones()
            {
                string archivo = "historial.txt";

                if (File.Exists(archivo))
                {
                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        string reparacion;
                        while ((reparacion = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(reparacion);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }
            }
        }

        // Clase BMW
        public class BMW : Auto
        {
            public BMW(string marca, string modelo, int año) : base(marca, modelo, año)
            {
            }

            public void RepararBMW(string descripcion)
            {
                Reparar(descripcion);
                Console.WriteLine("Reparación realizada en BMW.");
            }
        }

    }
}
