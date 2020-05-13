using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class DAOFuncionario
    {
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void inserir(Funcionario f)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Funcionario" +
                "( IdFuncionario, nomeFuncionario, cpfFuncionario, endFuncionario, cidFuncionario, estFuncionario, emailFuncionario, telefone1Funcionario, telefone2Funcionario)" +
                "values(@IdFuncionario, @nomeFuncionario, @cpfFuncionario, @endFuncionario, @cidFuncionario, @estFuncionario, @emailFuncionario, @telefone1Funcionario, @telefone2Funcionario)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@IdFuncionario", SqlDbType.VarChar).Value = f.idFuncionario;
            query.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = f.nomeFuncionario;
            query.Parameters.Add("@cpffuncionario", SqlDbType.VarChar).Value = f.cpfFuncionario;
            query.Parameters.Add("@endFuncionario", SqlDbType.VarChar).Value = f.endFuncionario;
            query.Parameters.Add("@cidFuncionario", SqlDbType.VarChar).Value = f.cidFuncionario;
            query.Parameters.Add("@estFuncionario", SqlDbType.VarChar).Value =f.estFuncionario;
            query.Parameters.Add("@emailFuncionario", SqlDbType.VarChar).Value = f.emailFuncionario;
            query.Parameters.Add("@telefone1Funcionario", SqlDbType.VarChar).Value = f.telefone1Funcionario;
            query.Parameters.Add("@telefone2Funcionario", SqlDbType.VarChar).Value = f.telefone2Funcionario;


            query.ExecuteNonQuery();
            conn.fechar();
        }
        public List<Funcionario> listaTodosFuncionarios()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select IdFuncionario, nomeFuncionario, cpfFuncionario, endFuncionario, cidFuncionario, estFuncionario, emailFuncionario,telefone1Funcionario, telefone2Funcionario from Funcionario");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Funcionario> func = new List<Funcionario>();
                    while (rs.Read())
                    {
                        Funcionario f = new Funcionario();
                        f.idFuncionario = rs.GetInt32(0);
                       f.nomeFuncionario = rs.GetString(1);
                        f.cpfFuncionario = rs.GetString(2);
                        f.endFuncionario = rs.GetString(3);
                        f.cidFuncionario = rs.GetString(4);
                        f.estFuncionario = (String)rs.GetString(5);
                        f.emailFuncionario = rs.GetString(6);
                        f.telefone1Funcionario = rs.GetString(7);
                        f.telefone2Funcionario = rs.GetString(8);
                        func.Add(f);
                    }
                    conn.fechar();
                    return func;
                }
                conn.fechar();
                return null;
            }
        }
        public List<Funcionario> listaFuncionarioPorNome(String nome)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select IdFuncionario, nomeFuncionario, cpfFuncionario, endFuncionario, cidFuncionario, estFuncionario, emailFuncionario, telefone1Funcionario, telefone2Funcionario from Funcionario" +
                " where nomeFuncionario LIKE @nomeFuncionario");
            query.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value =
                                                        "%" + nome + "%";
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Funcionario> funcionario = new List<Funcionario>();
                    while (rs.Read())
                    {
                        Funcionario f = new Funcionario();
                        f.idFuncionario = rs.GetInt32(0);
                        f.nomeFuncionario = rs.GetString(1);
                        f.cpfFuncionario = rs.GetString(2);
                        f.endFuncionario = rs.GetString(3);
                        f.cidFuncionario = rs.GetString(4);
                        f.estFuncionario = (String)rs.GetString(5);
                        f.emailFuncionario = (String)rs.GetString(5);
                        f.telefone1Funcionario = (String)rs.GetString(5);
                        f.telefone2Funcionario = (String)rs.GetString(5);

                        funcionario.Add(f);
                    }
                    conn.fechar();
                    return funcionario;
                }
                conn.fechar();
                return null;
            }
        }
        public void alterar(Funcionario f)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Funcionario set nomeFuncionario = @nomeFuncionario, cpfFuncionario = @cpfFuncionario, endFuncionario = @endFuncionario, cidFuncionario = @cidFuncionario ,emailFuncionario = @emailFuncionario, telefone1Funcionario = @telefone1Funcionario, telefone2Funcionario = @telefone2Funcionario " +
                "where IdFuncionario = @IdFuncionario");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@IdFuncionario", SqlDbType.Int).Value = f.idFuncionario;
            query.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = f.nomeFuncionario;
            query.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar).Value = f.cpfFuncionario;
            query.Parameters.Add("@endFuncionario", SqlDbType.VarChar).Value = f.endFuncionario;
            query.Parameters.Add("@cidFuncionario", SqlDbType.VarChar).Value = f.cidFuncionario;
            //query.Parameters.Add("@estFuncionario", SqlDbType.VarChar).Value = f.estFuncionario;
            query.Parameters.Add("@emailFuncionario", SqlDbType.VarChar).Value = f.emailFuncionario;
            query.Parameters.Add("@telefone1Funcionario", SqlDbType.VarChar).Value = f.telefone1Funcionario;
            query.Parameters.Add("@telefone2Funcionario", SqlDbType.VarChar).Value = f.telefone2Funcionario;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public void excluir(Funcionario f)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from Funcionario where IdFuncionario = @IdFuncionario");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@IdFuncionario", SqlDbType.Int).Value = f.idFuncionario;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public bool bloq(String bloq, int id)
        {

           
            return tem;
        }



    }
}
