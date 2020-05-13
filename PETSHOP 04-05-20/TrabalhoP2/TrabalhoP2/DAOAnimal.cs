using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoP2
{
    class DAOAnimal
    {
        public void inserir(Animal a)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Insert into Animal" +
                "(nome, raca, cor, cliente )" +
                " values(@nome, @raca, @cor, @cliente)");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@nome", SqlDbType.VarChar).Value = a.nome;
            query.Parameters.Add("@raca", SqlDbType.VarChar).Value = a.raca;
            query.Parameters.Add("@cor", SqlDbType.VarChar).Value = a.cor;
            query.Parameters.Add("@cliente", SqlDbType.Int).Value = a.Cliente;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public List<Animal> listaAnimal()
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "select id, nome, raca, cor, cliente from Animal ");
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Animal> animal = new List<Animal>();
                    while (rs.Read())
                    {
                        Animal an = new Animal();
                        an.id = rs.GetInt32(0);
                        an.nome = rs.GetString(1);
                        an.raca = rs.GetString(2);
                        an.cor = rs.GetString(3);
                        an.Cliente = rs.GetInt32(4);
                        animal.Add(an);
                    }
                    conn.fechar();
                    return animal;
                }
                conn.fechar();
                return null;
            }
        }
        public void alterar(Animal an)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Update Animal set nome = @nome, raca = @raca, cor=@cor, cliente=@cliente " +
                " where id= @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@id", SqlDbType.Int).Value = an.id;
            query.Parameters.Add("@nome", SqlDbType.VarChar).Value = an.nome;
            query.Parameters.Add("@raca", SqlDbType.VarChar).Value = an.raca;
            query.Parameters.Add("@cor", SqlDbType.VarChar).Value = an.raca;
            query.Parameters.Add("@cliente", SqlDbType.Int).Value = an.Cliente;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public void excluir(Animal a)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                "Delete from Animal where id = @id");
            query.Connection = conn.Abrir();
            query.Parameters.Add("@id", SqlDbType.Int).Value = a.id;
            query.ExecuteNonQuery();
            conn.fechar();
        }
        public List<Animal> listaAnimalPorNome(String nome)
        {
            Conexao conn = new Conexao();
            SqlCommand query = new SqlCommand(
                " select id, nome, raca, cor, cliente from Animal " +
                " where nome LIKE @nome");
            query.Parameters.Add("@nome", SqlDbType.VarChar).Value =
                                                        "%" + nome + "%";
            query.Connection = conn.Abrir();
            using (SqlDataReader rs = query.ExecuteReader())
            {
                if (rs.HasRows)
                {
                    List<Animal> animal = new List<Animal>();
                    while (rs.Read())
                    {
                        Animal a = new Animal();
                        a.id = rs.GetInt32(0);
                        a.nome = rs.GetString(1);
                        a.raca = rs.GetString(2);
                        a.cor = rs.GetString(3);
                        a.Cliente = rs.GetInt32(4);
                        animal.Add(a);
                    }
                    conn.fechar();
                    return animal;
                }
                conn.fechar();
                return null;
            }
        }

    

}


}
