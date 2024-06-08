using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDALUMNOS
{
    public class Alumno
    {
        public int Id { get; set; }

        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set;}
        public string Grado { get; set; }

        public string Usuario {  get; set; }

        
        public Alumno(int Id, int Carnet, string Nombre, string Telefono, string Grado, string Usuario)
        {
            this.Id = Id;
            this.Carnet = Carnet;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Grado = Grado;
            this.Usuario = Usuario;
        }
    }
    

}
