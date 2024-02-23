using System;

public class Persona
{
    public string Nombre { get; private set; }
    public string Apellido { get; private set; }
    public DateTime FechaNacimiento { get; private set; }
    public string Telefono { get; private set; }
    public string Direccion { get; private set; }

    public Persona(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion)
    {
        ValidarNombre(nombre);
        ValidarApellido(apellido);
        ValidarFechaNacimiento(fechaNacimiento);
        ValidarTelefono(telefono);
        ValidarDireccion(direccion);

        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        Telefono = telefono;
        Direccion = direccion;
    }

    private void ValidarNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre no puede estar vacío.");
        }
    }

    private void ValidarApellido(string apellido)
    {
        if (string.IsNullOrWhiteSpace(apellido))
        {
            throw new ArgumentException("El apellido no puede estar vacío.");
        }
    }

    private void ValidarFechaNacimiento(DateTime fechaNacimiento)
    {
        if (fechaNacimiento > DateTime.Now)
        {
            throw new ArgumentException("La fecha de nacimiento no puede ser mayor a la fecha actual.");
        }
    }

    private void ValidarTelefono(string telefono)
    {
        if (string.IsNullOrWhiteSpace(telefono))
        {
            throw new ArgumentException("El teléfono no puede estar vacío.");
        }
    }

    private void ValidarDireccion(string direccion)
    {
        if (string.IsNullOrWhiteSpace(direccion))
        {
            throw new ArgumentException("La dirección no puede estar vacía.");
        }
    }
}

public class Alumno : Persona
{
    public string Carnet { get; private set; }
    public DateTime FechaIngreso { get; private set; }

    public Alumno(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string carnet, DateTime fechaIngreso)
        : base(nombre, apellido, fechaNacimiento, telefono, direccion)
    {
        ValidarCarnet(carnet);
        ValidarFechaIngreso(fechaIngreso);

        Carnet = carnet;
        FechaIngreso = fechaIngreso;
    }

    private void ValidarCarnet(string carnet)
    {
        if (string.IsNullOrWhiteSpace(carnet))
        {
            throw new ArgumentException("El carnet no puede estar vacío.");
        }
    }

    private void ValidarFechaIngreso(DateTime fechaIngreso)
    {
        if (fechaIngreso > DateTime.Now)
        {
            throw new ArgumentException("La fecha de ingreso no puede ser mayor a la fecha actual.");
        }
    }
}

public class Profesor : Persona
{
    public string Especialidad { get; private set; }
    public DateTime FechaIngreso { get; private set; }

    private void ValidarFechaIngreso(DateTime fechaIngreso)
    {
        if (fechaIngreso > DateTime.Now)
        {
            throw new ArgumentException("La fecha de ingreso no puede ser mayor a la fecha actual.");
        }
    }



    public Profesor(string nombre, string apellido, DateTime fechaNacimiento, string telefono, string direccion, string especialidad, DateTime fechaIngreso)
        : base(nombre, apellido, fechaNacimiento, telefono, direccion)
    {
        ValidarFechaIngreso(fechaIngreso);

        Especialidad = especialidad;
        FechaIngreso = fechaIngreso;
    }
}

