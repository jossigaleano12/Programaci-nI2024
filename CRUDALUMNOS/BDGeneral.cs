using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUDALUMNOS
{
    public class BDGeneral
    {
        public static SqlConnection BDConectar()
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-FPTB1T7\\SQLEXPRESS; DataBase= CRUDALUMNOS; Integrated Security= true");
           conn.Open();
        return conn;

        }
    }
}
