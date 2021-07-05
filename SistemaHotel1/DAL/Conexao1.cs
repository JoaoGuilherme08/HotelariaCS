using System.Data.SqlClient;

namespace SistemaHotel1.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
       
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-7LHG7KM\SQLEXPRESS; Initial Catalog=Hotel; Integrated Security=True";

        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}


