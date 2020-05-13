using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
     class DAOConsumoCliente
    {
        public void inserir(ConsumoCliente cons)
        {
            
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into ConsumoCliente" +
                "(precoproduto, precototal, nomeproduto, cliente, produto)" +
                " values(@precoproduto, @precototal, @nomeproduto, @cliente, @produto)");
            query.Connection = conn.Abrir();
           query.Parameters.Add("@precoproduto", SqlDbType.Decimal).Value = cons.precoproduto.ToString();
            query.Parameters.Add("@precototal", SqlDbType.Decimal).Value = cons.Precototal.ToString();
            query.Parameters.Add("@nomeproduto", SqlDbType.VarChar,100).Value = cons.nomeproduto;
            query.Parameters.Add("@cliente", SqlDbType.Int).Value = cons.cliente;
            query.Parameters.Add("@produto", SqlDbType.Int).Value = cons.produto;
            query.ExecuteNonQuery();
            conn.fechar();
        }

        public void inserirLista(Lista lis)
        {

            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Lista" +
                "(p_descricao, Id_produto, p_valorunit, p_total, Id_Cliente, hora, data)" +
                " values(@p_descricao, @Id_produto, @p_valorunit, @p_total, @Id_Cliente, @hora, @data)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@p_descricao", SqlDbType.VarChar).Value = lis.p_descricao;
            query.Parameters.Add("@Id_produto", SqlDbType.Int).Value = lis.Id_produto.ToString();
            query.Parameters.Add("@p_valorunit", SqlDbType.Decimal, 100).Value = lis.p_valorUnit.ToString();
            query.Parameters.Add("@p_total", SqlDbType.Decimal).Value = lis.p_total.ToString();
            query.Parameters.Add("@Id_Cliente", SqlDbType.Int).Value = lis.Id_Cliente.ToString();
            query.Parameters.Add("@hora", SqlDbType.VarChar).Value = lis.hora.ToString();
            query.Parameters.Add("@data", SqlDbType.VarChar).Value = lis.data.ToString();
            query.ExecuteNonQuery();
            conn.fechar();
        }


        public List<ConsumoCliente> listaConsumoClientes()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                " select Id_consumo, precoproduto, precototal, nomeproduto, cliente, produto from ConsumoCliente");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<ConsumoCliente> consumo = new List<ConsumoCliente>();
                    while (rs.Read())
                    {
                        ConsumoCliente cons = new ConsumoCliente();
                        cons.id_consumo = rs.GetInt32(0);
                        cons.precoproduto = rs.GetDecimal(1);
                        cons.Precototal = rs.GetDecimal(2);
                        cons.nomeproduto = rs.GetString(3);
                        cons.cliente = rs.GetInt32(4);
                        cons.produto = rs.GetInt32(5);

                        consumo.Add(cons);
                    }
                    conn.fechar();
                    return consumo;
                }
                conn.fechar();
                return null;
            }
        }

        public void alterar(ConsumoCliente cons)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                " Update ConsumoCliente set precoproduto = @precoproduto, precototal = @precototal, nomeproduto= @nomeproduto, cliente = @cliente, produto = @produto " +
                " where Id_consumo = @Id_consumo");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Id_consumo", SqlDbType.Int).Value = cons.id_consumo;
            query.Parameters.Add("@precoproduto", SqlDbType.Decimal).Value = cons.precoproduto;
            query.Parameters.Add("@precototal", SqlDbType.Decimal).Value = cons.Precototal;
            query.Parameters.Add("@nomeproduto", SqlDbType.VarChar).Value = cons.nomeproduto;
            query.Parameters.Add("@cliente", SqlDbType.Int).Value = cons.cliente;
            query.Parameters.Add("@produto", SqlDbType.Int).Value = cons.produto;

            query.ExecuteNonQuery();
            conn.fechar();
        }
        public void excluir(ConsumoCliente cons)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from ConsumoCliente where Id_consumo=@Id_consumo");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Id_consumo", SqlDbType.Int).Value = cons.id_consumo;
            query.ExecuteNonQuery();
            conn.fechar();
        }

        public void excluirLista(int num)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from Lista where Id_produto=@Id_produto");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Id_produto", SqlDbType.Int).Value = num;
            query.ExecuteNonQuery();
            conn.fechar();
        }

        public void excluirTudo()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from Lista");
            query.Connection = conn.Abrir();
            query.ExecuteNonQuery();
            conn.fechar();
        }


        public List<ConsumoCliente> listaConsumoProduto(String nome)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select Id_consumo, precoproduto, precototal, nomeproduto, cliente, produto from ConsumoCliente"+
                " where nomeproduto LIKE @nomeproduto");
            query.Parameters.Add("@nomeproduto", SqlDbType.VarChar).Value =
                                                        "%" + nome + "%";
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<ConsumoCliente> consumo = new List<ConsumoCliente>();
                    while (rs.Read())
                    {
                        ConsumoCliente c = new ConsumoCliente();
                        c.id_consumo = rs.GetInt32(0);
                        c.precoproduto = rs.GetDecimal(1);
                        c.Precototal= rs.GetDecimal(2);
                        c.nomeproduto = rs.GetString(3);
                        c.cliente = rs.GetInt32(4);
                        c.produto = rs.GetInt32(5);

                        consumo.Add(c);
                    }
                    conn.fechar();
                    return consumo;
                }
                conn.fechar();
                return null;
            }
        }
        


    }
}
