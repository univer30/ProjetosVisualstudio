using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class DAOPagamento
    {
        public void inserir(Pagamento p)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Pagamento" +
                "(nomecliente, dinheiro, cartao, cheque, ticket, descontos, outros, troco, total, idCliente, data, hora)" +
                " values(@nomecliente, @dinheiro, @cartao, @cheque, @ticket, @descontos, @outros, @troco, @total, @idCliente, @data, @hora)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@nomecliente", SqlDbType.VarChar).Value = p.nomecliente;
            query.Parameters.Add("@dinheiro", SqlDbType.Decimal).Value = p.dinheiro;
            query.Parameters.Add("@cartao", SqlDbType.Decimal).Value = p.cartao;
            query.Parameters.Add("@cheque", SqlDbType.Decimal).Value = p.cheque;      
            query.Parameters.Add("@ticket", SqlDbType.Decimal).Value = p.ticket;
            query.Parameters.Add("@descontos", SqlDbType.Decimal).Value = p.descontos;
            query.Parameters.Add("@outros", SqlDbType.Decimal).Value = p.outros;
            query.Parameters.Add("@troco", SqlDbType.Decimal).Value = p.troco;
            query.Parameters.Add("@total", SqlDbType.Decimal).Value = p.Total;
            query.Parameters.Add("@idCliente", SqlDbType.Int).Value = p.idCliente;
            query.Parameters.Add("@data", SqlDbType.VarChar).Value = p.data;
            query.Parameters.Add("@hora", SqlDbType.VarChar).Value = p.hora;
            query.ExecuteNonQuery();
            conn.fechar();
        }

        public List<Pagamento> listaPagamento()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select nomecliente, dinheiro, cartao, cheque, ticket, descontos, outros, troco, total,  idCliente, data, hora from Pagamento");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Pagamento> pagamento = new List<Pagamento>();
                    while (rs.Read())
                    {
                        Pagamento p = new Pagamento();
                        p.nomecliente = rs.GetString(0);
                        p.dinheiro = rs.GetDecimal(1);
                        p.cartao = rs.GetDecimal(2);
                        p.cheque = rs.GetDecimal(3);
                        p.ticket = rs.GetDecimal(4);
                        p.descontos = rs.GetDecimal(5);
                        p.outros = rs.GetDecimal(6);
                        p.troco = rs.GetDecimal(7);
                        p.Total = rs.GetDecimal(8);
                        p.idCliente = rs.GetInt32(9);
                        p.data= rs.GetString(10);
                        p.hora = rs.GetString(11);
                       
                        pagamento.Add(p);
                    }
                    conn.fechar();
                    return pagamento;
                }
                conn.fechar();
                return null;
            }
        }

    }
}
