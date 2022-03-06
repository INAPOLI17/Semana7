using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Semana7
{
    public class Conexión
    {
        SqlConnection cone = new SqlConnection(@"Data Source=DESKTOP-QUV81SK;Initial Catalog=Musica;Integrated Security=True");

        public DataTable mostrar(string strsql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(strsql, cone);
        }

    }
}
