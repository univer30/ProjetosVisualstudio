using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class DAOCliente
    {
        public void inserir(Cliente c)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Cliente" +
                "(nomeCliente, cpfCliente, endCliente, cidCliente, estcliente)" +
                "values(@nomeCliente, @cpfCliente, @endCliente, @cidCliente, @estCliente)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@nomeCliente", SqlDbType.VarChar).Value = c.nomecliente;
            query.Parameters.Add("@cpfCliente", SqlDbType.VarChar).Value = c.cpfcliente;
            query.Parameters.Add("@endCliente", SqlDbType.VarChar).Value = c.endcliente;
            query.Parameters.Add("@cidCliente", SqlDbType.VarChar).Value = c.cidcliente;
            query.Parameters.Add("@estCliente", SqlDbType.VarChar).Value = c.estcliente;

            query.ExecuteNonQuery();
            conn.fechar();
        }

        public List<Cliente> listaTodosClientes()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select idCliente, nomeCliente, cpfCliente, endCliente, cidCliente, estCliente from Cliente");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Cliente> clientes = new List<Cliente>();
                    while (rs.Read())
                    {
                        Cliente c = new Cliente();
                        c.idcliente = rs.GetInt32(0);
                        c.nomecliente = rs.GetString(1);
                        c.cpfcliente = rs.GetString(2);
                        c.endcliente = rs.GetString(3);
                        c.cidcliente = rs.GetString(4);
                        c.estcliente = (String)rs.GetString(5);
                        clientes.Add(c);
                    }
                    conn.fechar();
                    return clientes;
                }
                conn.fechar();
                return null;
            }
        }

        public void alterar(Cliente c)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Cliente set nomeCliente = @nomeCliente, cpfCliente = @cpfCliente, endCliente = @endCliente, cidCliente = @cidCliente, estCliente = @estCliente " +
                "where idcliente = @idcliente");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@idcliente", SqlDbType.Int).Value = c.idcliente;
            query.Parameters.Add("@nomecliente", SqlDbType.VarChar).Value = c.nomecliente;
            query.Parameters.Add("@cpfcliente", SqlDbType.VarChar).Value = c.cpfcliente;
            query.Parameters.Add("@endcliente", SqlDbType.VarChar).Value = c.endcliente;
            query.Parameters.Add("@cidcliente", SqlDbType.VarChar).Value = c.cidcliente;
            query.Parameters.Add("@estcliente", SqlDbType.VarChar).Value = c.estcliente;

            query.ExecuteNonQuery();
            conn.fechar();
        }
        public void excluir(Cliente c)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from Cliente where idcliente = @idcliente");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@idcliente", SqlDbType.Int).Value = c.idcliente;
            query.ExecuteNonQuery();
            conn.fechar();
        }

        public List<Cliente> listaClientesPorNome(String nome)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select idcliente, nomecliente, cpfcliente, endcliente, cidcliente, estcliente from Cliente" +
                " where nomecliente LIKE @nomecliente");
            query.Parameters.Add("@nomecliente", SqlDbType.VarChar).Value =
                                                        "%" + nome + "%";
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Cliente> clientes = new List<Cliente>();
                    while (rs.Read())
                    {
                        Cliente c = new Cliente();
                        c.idcliente = rs.GetInt32(0);
                        c.nomecliente = rs.GetString(1);
                        c.cpfcliente = rs.GetString(2);
                        c.endcliente = rs.GetString(3);
                        c.cidcliente = rs.GetString(4);
                        c.estcliente = (String)rs.GetString(5);

                        clientes.Add(c);
                    }
                    conn.fechar();
                    return clientes;
                }
                conn.fechar();
                return null;
            }
        }
        
    }
}
