using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class DAOBanco
    {

        public void inserir(Banco b)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Banco" +
                "(BancoN, TipoConta, Agencia, Conta, Saldo)" +
                " values(@BancoN, @TipoConta, @Agencia, @Conta, @Saldo)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@BancoN", SqlDbType.VarChar).Value =b.BancoN;
            query.Parameters.Add("@TipoConta", SqlDbType.VarChar).Value =b.tipoconta;
            query.Parameters.Add("@Agencia", SqlDbType.VarChar).Value = b.agencia;
            query.Parameters.Add("@Conta", SqlDbType.VarChar).Value = b.conta;
            query.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = b.saldo;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public void alterar(Banco b)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Banco set Saldo = @Saldo " +
                " where id= @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Id", SqlDbType.Int).Value = b.id;
            query.Parameters.Add("@saldo", SqlDbType.Decimal).Value =b.saldo;
            query.ExecuteNonQuery();
            conn.fechar();
        }
    }

}
