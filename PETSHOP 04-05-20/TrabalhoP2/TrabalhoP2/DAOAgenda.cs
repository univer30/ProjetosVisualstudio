using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class DAOAgenda
    {
        public void inserir(Agenda a)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Agenda" +
                "(descricao,idcliente, data, hora)" +
                " values(@descricao, @idcliente, @data, @hora)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@descricao", SqlDbType.VarChar).Value = a.descricao;
            query.Parameters.Add("@idcliente", SqlDbType.Int).Value = a.id;
            query.Parameters.Add("@data", SqlDbType.VarChar).Value = a.data;
            query.Parameters.Add("@hora", SqlDbType.VarChar).Value = a.hora;


            query.ExecuteNonQuery();
            conn.fechar();
        }

    }
}
