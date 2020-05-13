using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class DAOProduto
    {
        public void inserir(Produto p)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Produto" +
                "(nomeproduto, precoproduto, qtde)" +
                " values(@nomeproduto, @precoproduto, @qtde)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@nomeproduto", SqlDbType.VarChar).Value = p.nomeproduto;
            query.Parameters.Add("@precoproduto", SqlDbType.Decimal).Value = p.Precoproduto;
            query.Parameters.Add("@qtde", SqlDbType.Int).Value = p.qtde;
            query.ExecuteNonQuery();
            conn.fechar();
        }

        public List<Produto> listaProdutos()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select idProduto, nomeproduto, precoproduto, qtde from Produto");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Produto> produtos = new List<Produto>();
                    while (rs.Read())
                    {
                        Produto p = new Produto();
                        p.idproduto = rs.GetInt32(0);
                        p.nomeproduto = rs.GetString(1);
                        p.Precoproduto = rs.GetDecimal(2);
                        p.qtde = rs.GetInt32(3);
                        produtos.Add(p);
                    }
                    conn.fechar();
                    return produtos;
                }
                conn.fechar();
                return null;
            }
        }

        public void alterar(Produto p)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Produto set nomeproduto = @nomeproduto, precoproduto = @precoproduto, qtde = @qtde " +
                " where idproduto= @idproduto");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@idproduto", SqlDbType.Int).Value = p.idproduto;
            query.Parameters.Add("@nomeproduto", SqlDbType.VarChar).Value = p.nomeproduto;
            query.Parameters.Add("@precoproduto", SqlDbType.Decimal).Value = p.Precoproduto;
            query.Parameters.Add("@qtde", SqlDbType.Int).Value = p.qtde;

            query.ExecuteNonQuery();
            conn.fechar();
        }
        public void excluir(Produto p)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from Produto where idproduto = @idproduto");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@idproduto", SqlDbType.Int).Value = p.idproduto;
            query.ExecuteNonQuery();
            conn.fechar();
        }

        public List<Produto> listaProdutoPorNome(String nome)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                " select idproduto, nomeproduto, precoproduto, qtde from Produto " +
                " where nomeproduto LIKE @nomeproduto");
            query.Parameters.Add("@nomeproduto", SqlDbType.VarChar).Value=
                                                        "%" + nome + "%";
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Produto> produtos = new List<Produto>();
                    while (rs.Read())
                    {
                        Produto p = new Produto();
                        p.idproduto = rs.GetInt32(0);
                        p.nomeproduto = rs.GetString(1);
                        p.Precoproduto = rs.GetDecimal(2);
                        p.Precoproduto = rs.GetInt32(3);
                        produtos.Add(p);
                    }
                    conn.fechar();
                    return produtos;
                }
                conn.fechar();
                return null;
            }
        }
        public void alterarQtde(Produto p)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Produto set qtde = @qtde " +
                " where idproduto= @idproduto");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@qtde", SqlDbType.Int).Value = p.qtde;
            query.ExecuteNonQuery();
            conn.fechar();
        }

    }
}
