using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class DAOCaixa
    {

        public void inserir(Caixa c)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Caixa" +
                "(Data, descricao, Creditodebito, valor, SaldoConta, Subtotal)" +
                " values(@Data, @descricao, @Creditodebito, @valor, @SaldoConta, @Subtotal)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Data", SqlDbType.VarChar).Value =c.Data;
            query.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = c.descricao;
            query.Parameters.Add("@Creditodebito", SqlDbType.VarChar).Value =c.Creditodebito;
            query.Parameters.Add("@valor", SqlDbType.Decimal).Value = c.valor;
            query.Parameters.Add("@SaldoConta", SqlDbType.VarChar).Value = c.SaldoConta;
            query.Parameters.Add("@Subtotal", SqlDbType.VarChar).Value = c.Subtotal;

            query.ExecuteNonQuery();
            conn.fechar();
        }

        public List<Caixa> listaCaixa()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id, Data, Descricao, Creditodebito, valor, SaldoConta, Subtotal from Caixa");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Caixa> caixa = new List<Caixa>();
                    while (rs.Read())
                    {
                       Caixa ca = new Caixa();
                        ca.Id = rs.GetInt32(0);
                      ca.Data = rs.GetString(1);
                       ca.descricao = rs.GetString(2);
                        ca.Creditodebito = rs.GetString(3);
                        ca.valor = rs.GetDecimal(4);
                        ca.SaldoConta= rs.GetDecimal(5);
                        ca.Subtotal = rs.GetDecimal(6);

                       caixa.Add(ca);
                    }
                    conn.fechar();
                    return caixa;
                }
                conn.fechar();
                return null;
            }
        }
        public void alterarCaixa(int id, Decimal SaldoConta)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Caixa set SaldoConta = @SaldoConta " +
                " where id= @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            query.Parameters.Add("@saldoConta", SqlDbType.Decimal).Value = SaldoConta;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public List<Caixa> listaAnimalPorNome(String data)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                " select id, Data, descricao, creditodebito, valor, SaldoConta, Subtotal from Caixa " +
                " where Data LIKE @Data");
            query.Parameters.Add("@Data", SqlDbType.VarChar).Value =
                                                        "%" + data + "%";
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Caixa> caixa = new List<Caixa>();
                    while (rs.Read())
                    {
                        Caixa c = new Caixa();
                        c.Id = rs.GetInt32(0);
                        c.Data = rs.GetString(1);
                        c.descricao = rs.GetString(2);
                        c.Creditodebito = rs.GetString(3);
                        c.valor = rs.GetDecimal(4);
                        c.SaldoConta = rs.GetDecimal(5);
                        c.Subtotal = rs.GetDecimal(6);

                        caixa.Add(c);
                    }
                    conn.fechar();
                    return caixa;
                }
                conn.fechar();
                return null;
            }
        }
    }
}
