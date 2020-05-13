using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
   

    public class DAOAgendar
    {
        public bool tem;
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public void inserir(Agendar a)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Agenda" +
                "(id_cliente, data, hora, descricao, id_animal)" +
                " values(@id_cliente,@data, @hora, @descricao, @id_animal)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@id_cliente", SqlDbType.Int).Value = a.idCliente;
            query.Parameters.Add("@data", SqlDbType.VarChar).Value =a.data;
            query.Parameters.Add("@hora", SqlDbType.VarChar).Value = a.hora;
            query.Parameters.Add("@descricao", SqlDbType.VarChar).Value = a.descricao;
            query.Parameters.Add("@id_animal", SqlDbType.Int).Value = a.id_animal;

            query.ExecuteNonQuery();
            conn.fechar();
        }
            
        public List<Agendar> listaAgenda()
        {
            Conexao conn = new Conexao();
        SqlCommand query = new SqlCommand(
            "select Id, id_cliente, data, hora, descricao, id_animal from Agenda");
        query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Agendar>  agendar = new List<Agendar>();
                    while (rs.Read())
                    {
                        Agendar a = new Agendar();
                        a.id = rs.GetInt32(0);
                        a.idCliente = rs.GetInt32(1);
                        a.data = rs.GetString(2);
                        a.hora = rs.GetString(3);
                        a.descricao = rs.GetString(4);
                        a.id_animal = rs.GetInt32(5);
                        agendar.Add(a);
                    }
                    conn.fechar();
                    return agendar;
                }
               conn.fechar();
                return null;
            }
        }

        public void excluir(Agendar ag)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from  Agenda where Id = @Id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Id", SqlDbType.Int).Value = ag.id;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        
        public bool ConsultarAgenda(String data, String hora)
        {

            cmd.CommandText = @"select * from Agenda where data = @data and hora = @hora ";
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@hora", hora);

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
        public void alterar(Agendar age)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Agenda set id_cliente = @id_cliente, data = @data, hora = @hora, descricao = @descricao, id_animal = @id_animal " +
                " where Id= @Id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@Id", SqlDbType.Int).Value = age.id;
            query.Parameters.Add("@id_cliente", SqlDbType.Int).Value = age.idCliente;
            query.Parameters.Add("@data", SqlDbType.VarChar).Value = age.data;
            query.Parameters.Add("@hora", SqlDbType.VarChar).Value = age.hora;
            query.Parameters.Add("@descricao", SqlDbType.VarChar).Value = age.descricao;
            query.Parameters.Add("@id_animal", SqlDbType.Int).Value = age.id_animal;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public void deletargenda(String data)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from Agenda where data = @data");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@data", SqlDbType.VarChar).Value = data;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public List<Agendar> listaAgendaPornome(int id_cliente)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                " select Id, id_cliente, data, hora, descricao, id_animal from Agenda " +
                " where id_cliente LIKE @id_cliente");
            query.Parameters.Add("@id_cliente", SqlDbType.VarChar).Value =
                                                        "%" + id_cliente + "%";
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Agendar> agendar = new List<Agendar>();
                    while (rs.Read())
                    {
                        Agendar a = new Agendar();
                        a.id= rs.GetInt32(0);
                        a.idCliente = rs.GetInt32(1);
                        a.data = rs.GetString(2);
                        a.hora = rs.GetString(3);
                        a.descricao = rs.GetString(4);
                        a.id_animal = rs.GetInt32(5);
                        agendar.Add(a);
                    }
                    conn.fechar();
                    return agendar;
                }
                conn.fechar();
                return null;
            }
        }


    }

}
