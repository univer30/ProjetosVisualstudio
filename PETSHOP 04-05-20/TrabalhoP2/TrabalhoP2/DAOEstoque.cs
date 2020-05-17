using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
  public class DAOEstoque
    {

        public void inserir(Estoque e)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Estoque" +
                "(Data, Descricao, unidade, entrada, Saida, estoqminimo, precoun )" +
                " values(@Data, @Descricao, @unidade, @entrada, @Saida, @estoqminimo, @precoun)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Data", SqlDbType.VarChar).Value = e.Data;
            query.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = e.Descricao;
            query.Parameters.Add("@unidade", SqlDbType.Int).Value = e.Unidade;
            query.Parameters.Add("@entrada", SqlDbType.VarChar).Value =e.Entrada;
            query.Parameters.Add("@Saida", SqlDbType.VarChar).Value = e.Saida;
            query.Parameters.Add("@estoqminimo", SqlDbType.Int).Value = e.Estoqminimo;
            query.Parameters.Add("@precoun", SqlDbType.Int).Value = e.precoun;



            query.ExecuteNonQuery();
            conn.fechar();
        }


        public void alterar(Estoque e)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Estoque set unidade = @unidade " +
                " where Descricao = @Descricao");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@unidade", SqlDbType.Int).Value = e.Unidade;
            query.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = e.Descricao;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public void alterar2(Estoque e)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Estoque set unidade = @unidade,  " +
                " where Descricao = @Descricao");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@unidade", SqlDbType.Int).Value = e.Unidade;
         
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public List<Estoque> listaEstoque()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id, Data, Descricao, unidade, entrada, saida, estoqminimo, precoun  from Estoque ");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Estoque> estoques = new List<Estoque>();
                    while (rs.Read())
                    {
                        Estoque e = new Estoque();
                        e.id = rs.GetInt32(0);
                        e.Data= rs.GetString(1);
                       e.Descricao = rs.GetString(2);
                        e.Unidade= rs.GetInt32(3);
                       e.Entrada = rs.GetString(4);
                        e.Saida = rs.GetString(5);
                        e.Estoqminimo = rs.GetInt32(6);
                        e.precoun = rs.GetDecimal(7);
                     




                        estoques.Add(e);
                    }
                    conn.fechar();
                    return estoques;
                }
                conn.fechar();
                return null;
            }
        }
        public List<Estoque> listaEstoquePorDataEntrada(String data)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                " select id, Data, Descricao, unidade, entrada, saida, estoqminimo, precoun from Estoque " +
                " where entrada LIKE @entrada");
            query.Parameters.Add("@entrada", SqlDbType.VarChar).Value =
                                                        "%" + data + "%";
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
                        e.Descricao = rs.GetString(2);
                        e.Unidade = rs.GetInt32(3);
                        e.Entrada = rs.GetString(4);
                        e.Saida = rs.GetString(5);
                        e.Estoqminimo = rs.GetInt32(6);
                        e.precoun = rs.GetDecimal(7);
                        estoque.Add(e);
                    }
                    conn.fechar();
                    return estoque;
                }
                conn.fechar();
                return null;
            }
        }
        public List<Estoque> listaEstoquePorDataSaida(String data)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                " select id, Data, Descricao, unidade, entrada, Saida, estoqminimo, precoun from Estoque " +
                " where saida LIKE @Saida");
            query.Parameters.Add("@Saida", SqlDbType.VarChar).Value =
                                                        "%" + data + "%";
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
                        e.Descricao = rs.GetString(2);
                        e.Unidade = rs.GetInt32(3);
                        e.Entrada = rs.GetString(4);
                        e.Saida = rs.GetString(5);
                        e.Estoqminimo = rs.GetInt32(6);
                        e.precoun = rs.GetDecimal(7);
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
