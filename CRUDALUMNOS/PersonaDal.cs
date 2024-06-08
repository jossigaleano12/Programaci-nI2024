using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDALUMNOS
{
    public class PersonaDal

    {
        public static int AgregarAlumno(Alumno alumno)
        {
            int retorna = 0;
            using (SqlConnection conn = BDGeneral.BDConectar())
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                string query = "insert into Alumnos (Carnet,Nombre,Telefono,Grado,Usuario) values('" + alumno.Carnet +"', "+alumno.Nombre+",'"+alumno.Telefono+ "', '"+alumno.Grado+ "', '"+alumno.Usuario+"')";
                SqlCommand comando = new SqlCommand(query, conn);
                retorna = comando.ExecuteNonQuery();

            }
            return retorna;
        }
        public static List<Alumno> PresentarGrid()
        {
            List<Alumno> Lista = new List<Alumno>();
            using (SqlConnection conec = BDGeneral.BDConectar())
            {
                string query = "select *from Alumnos";
                SqlCommand sqlCommand = new SqlCommand(query, conec);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.Id = reader.GetInt32(0);
                    alumno.Carnet = reader.GetInt32(1);
                    alumno.Nombre = reader.GetString(2);
                    alumno.Telefono = reader.GetString(3);
                    alumno.Grado = reader.GetString(4);
                    alumno.Usuario = reader.GetString(5);

                    Lista.Add(alumno);

                }
                conec.Close();
                return Lista;
            }
        }
        public static int Modificar(Alumno alumno)
        {
            int result = 0;
            using(SqlConnection connection = BDGeneral.BDConectar())
            {
                string query = "update Alumno set Carnet ='" + alumno.Carnet + "',Nombre = '" + alumno.Nombre + "',numero = '" + alumno.Telefono + "',numero = '" + alumno.Grado + "',numero = '" + alumno.Usuario + "' where id=" +alumno.Id+" ";
                SqlCommand sqlCommand1 = new SqlCommand(query, connection);
            result = sqlCommand1.ExecuteNonQuery();
                connection.Close();


            }
            return result;
        }
        public static int EliminarPersona(int id)
        {
            int retorna = 0;
            using (SqlConnection conn = BDGeneral.BDConectar())
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                string query = "delete from Persona where id="+id+"";
                SqlCommand comando = new SqlCommand(query, conn);
                retorna = comando.ExecuteNonQuery();

            }
            return retorna;
        }
    }
}
