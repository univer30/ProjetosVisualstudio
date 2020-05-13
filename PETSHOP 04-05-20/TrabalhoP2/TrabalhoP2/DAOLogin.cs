using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrabalhoP2
{
    class DAOLogin
    {
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void inserir(Login l)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Login" +
                "(id,usuario,senha, bloq)" +
                "values(@id,@usuario, @senha, @bloq)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@id", SqlDbType.Int).Value = l.id;
            query.Parameters.Add("@usuario", SqlDbType.VarChar).Value = l.usuario;
            query.Parameters.Add("@senha", SqlDbType.VarChar).Value = l.senha;
            query.Parameters.Add("@bloq", SqlDbType.VarChar).Value = l.bloq;
            query.ExecuteNonQuery();
            conn.fechar();
        }


        public void alterarBloq(int Id, String bloq)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Login set bloq = @bloq where Id = @Id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            query.Parameters.Add("@bloq", SqlDbType.VarChar).Value = bloq;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public void excluir(Login l)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from Login where id = @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@id", SqlDbType.Int).Value = l.id;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public List<Login> listaTodosLogin()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id, usuario, senha, bloq from Login");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Login> login = new List<Login>();
                    while (rs.Read())
                    {
                        Login l = new Login();
                        l.id = rs.GetInt32(0);
                        l.usuario = rs.GetString(1);
                        l.senha = rs.GetString(2);
                        l.bloq = rs.GetString(3);

                        login.Add(l);
                    }
                    conn.fechar();
                    return login;
                }
                conn.fechar();
                return null;
            }
        }


            public bool Login(Login c)
        {

            cmd.CommandText = @"select * from Login where usuario = @usuario and senha = @senha ";
            cmd.Parameters.AddWithValue("@usuario", c.usuario);
            cmd.Parameters.AddWithValue("@Senha", c.senha);
            try
            {
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
               
            }
            catch (SqlException)
            {


            }
            return tem;
           
        }

        public bool bloq(String bloq, int id)
        {

            cmd.CommandText = @"select * from Login where bloq = @bloq and Id = @Id ";
            cmd.Parameters.AddWithValue("@bloq", bloq);
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {


            }
            return tem;
        }

        public List<Login> listaLogin(String nome)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id,usuario, senha, bloq from Login" +
                " where usuario LIKE @usuario");
            query.Parameters.Add("@usuario", SqlDbType.VarChar).Value =
                                                        "%" + nome + "%";
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Login> login = new List<Login>();
                    while (rs.Read())
                    {
                        Login l = new Login();
                       l.id = rs.GetInt32(0);
                        l.usuario = rs.GetString(1);
                        l.senha = rs.GetString(2);
                        l.bloq = rs.GetString(3);
                     
                        login.Add(l);
                    }
                    conn.fechar();
                    return login;
                }
                conn.fechar();
                return null;
            }
        }

        public void alterar(Login l)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Login set usuario = @usuario, senha = @senha " +
                "where id = @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@id", SqlDbType.Int).Value = l.id;
            query.Parameters.Add("@usuario", SqlDbType.VarChar).Value = l.usuario;
            query.Parameters.Add("@senha", SqlDbType.VarChar).Value = l.senha;

            query.ExecuteNonQuery();
            conn.fechar();
        }




    }
    }

