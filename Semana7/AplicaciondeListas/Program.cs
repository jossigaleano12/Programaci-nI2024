using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaciondeListas
{
    internal class Program
    {
        static List<string> tareas = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Mostrar tareas");
                Console.WriteLine("2. Agregar tareas");
                Console.WriteLine("3. Eliminar tareas");
                Console.WriteLine("4.Salir");

                Console.Write("Ingresa lo que quieres realizar: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        Mostrartareas();
                        break;
                    case 2:
                        Agregartareas();
                        break;
                    case 3:
                        Eliminartareas();
                        break;
                    case 4:
                        Console.WriteLine("Saliste del programa");
                        return;
                    default:
                        Console.WriteLine("Seleccion invalida.");
                        break;
                }
            }
        }

        static void Mostrartareas()
        {
            Console.WriteLine("Tareas:");
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }

        static void Agregartareas()
        {
            Console.Write("Agrega tu tarea: ");
            string tarea = Console.ReadLine();

            tareas.Add(tarea);

            Console.WriteLine("Haz agregado una tarea nueva!");
        }

        static void Eliminartareas()
        {
            Console.WriteLine("Que numero de tarea deseas eliminar?: ");
            int tarea = Convert.ToInt32(Console.ReadLine());

            if (tarea < 1 || tarea > tareas.Count)
            {
                Console.WriteLine("tarea invalido.");
                return;
            }

            tareas.RemoveAt(tarea - 1);

            Console.WriteLine("Tu tarea a sido eliminada!");
        }
    }
}
