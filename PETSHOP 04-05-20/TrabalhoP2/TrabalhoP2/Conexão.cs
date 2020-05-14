using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class Conexao
    {
        SqlConnection conn;
        String fonte = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago\source\repos\ProjetosVisualstudio\PETSHOP 04-05-20\TrabalhoP2\TrabalhoP2\Loja.mdf;Integrated Security=True";
        
        public Conexao()
        {
            conn = new SqlConnection(fonte);
        }

        public SqlConnection Abrir()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }
        public void fechar()
        {
            conn.Close();
        }

    }
}
