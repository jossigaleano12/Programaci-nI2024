using System;

public class Alumno
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void ImprimirDetalles()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
    }
}

public class Registro
{
    static void Main(string[] args)
    {
        // Crear instancias de la clase Persona
        Alumno Alumno1 = new Alumno();
        Alumno1.Nombre = "Maria";
        Alumno1.Edad = 15;

        Alumno Alumno2 = new Alumno();
        Alumno2.Nombre = "Luis";
        Alumno2.Edad = 14;

        Alumno Alumno3=new Alumno();
        Alumno3.Nombre = "Daniela";
        Alumno3.Edad = 17;

        // Imprimir los detalles de las personas
        Alumno1.ImprimirDetalles();
        Console.WriteLine();

        Alumno2.ImprimirDetalles();
        Console.WriteLine();

        Alumno3.ImprimirDetalles();
        Console.WriteLine();
    }
}