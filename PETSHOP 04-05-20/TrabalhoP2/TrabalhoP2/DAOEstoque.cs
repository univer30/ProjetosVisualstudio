using System;
using System.Collections.Generic;
using System.Data;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class DAOEstoque
    {
        public void inserir(int id_produto, String descricao, int unidade, Decimal valorUnitario, String entrada, String saida,int estoqueM , String dataAcesso )
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Estoque" +
                "(Data, descricao, unidade, entrada, saida, estoqueMinimo,saldoAtual,id_produto)" +
                " values(@Data, @descricao, @unidade, @entrada, @saida, @estoqueMinimo, @saldoAtual, @id_produto)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Data", SqlDbType.VarChar).Value =dataAcesso;
            query.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
            query.Parameters.Add("@unidade", SqlDbType.VarChar).Value = unidade;
            query.Parameters.Add("@entrada", SqlDbType.VarChar).Value = entrada;
            query.Parameters.Add("@saida", SqlDbType.VarChar).Value = saida;
            query.Parameters.Add("@estoqueMinimo", SqlDbType.Int).Value = estoqueM;
            query.Parameters.Add("@saldoAtual", SqlDbType.Decimal).Value = valorUnitario;
            query.Parameters.Add("@id_produto", SqlDbType.Int).Value = id_produto;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public List<Estoque> listaEstoque()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select cod, Data, descricao, unid, said,  estoqMin, saldoAt, id_produto from Estoque");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Estoque> estoque = new List<Estoque>();
                    while (rs.Read())
                    {
                        Estoque e = new Estoque();
                       e.id = rs.GetInt32(0);
                        e.Data = rs.GetString(1);
                        e.descricao = rs.GetString(2);
                        e.entrada = rs.GetString(2);
                        e.saida = rs.GetString(4);
                        e.estoqueminimo = rs.GetInt32(5);
                        e.saldoAtual = rs.GetDecimal(6);
                        e.id_produto = rs.GetInt32(7);
                        estoque.Add(e);
                    }
                    conn.fechar();
                    return estoque;
                }
                conn.fechar();
                return null;
            }
        }

    }

}
