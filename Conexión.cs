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
        SqlConnection cone = new SqlConnection(@"Data Source=(local);Initial Catalog=Musica;Integrated Security=True");

        public DataTable mostrar(string strsql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(strsql, cone);
            ds.Fill(dt);
            return dt; 
        }

        public void inupmusic(Musica newmusic)
        {
            SqlCommand cmd = new SqlCommand("sp_inup_musica", cone);
            cone.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo", newmusic.id);
            cmd.Parameters.AddWithValue("@nombre", newmusic.nombre);
            cmd.Parameters.AddWithValue("@album", newmusic.albúm);
            cmd.Parameters.AddWithValue("@artista", newmusic.artista);

            cmd.ExecuteNonQuery();
            cone.Close();

        }

    }
}
