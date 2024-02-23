using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Crear instancias de Alumno
            var alumno1 = new Alumno("Juan", "Pérez", new DateTime(1995, 12, 15), "555-5555", "Calle 123", "12345678", new DateTime(2020, 8, 1));
            Console.WriteLine("Alumno 1 creado correctamente.");

            var alumno2 = new Alumno("Ana", "Gómez", new DateTime(2000, 6, 20), "555-1234", "Calle 456", "19483927", new DateTime(2021, 1, 1));
            Console.WriteLine("Alumno 2 creado correctamente.");

            // Crear instancias de Profesor
            var profesor1 = new Profesor("María", "García", new DateTime(1980, 5, 20), "555-5555", "Calle 456", "Programación", new DateTime(2015, 1, 1));
            Console.WriteLine("Profesor 1 creado correctamente.");

            var profesor2 = new Profesor("Carlos", "López", new DateTime(1975, 11, 25), "555-9876", "Calle 789", "Matemáticas", new DateTime(2010, 7, 15));
            Console.WriteLine("Profesor 2 creado correctamente.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
