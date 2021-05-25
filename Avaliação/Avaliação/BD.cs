using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Avaliação
{
    class BD
    {
        static SqlConnection conexao = new SqlConnection();
        static SqlCommand sql = new SqlCommand();
        public static SqlDataAdapter Inicializar()
        {
            SqlCommand sql = new SqlCommand();
            SqlConnection conexao = new SqlConnection();
           conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            sql.Connection = conexao;
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
            return adaptador;
       }
        public static int Executar(out SqlDataAdapter adaptador)
        {
           
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=provasenai;Integrated Security=True";
            sql.Connection = conexao;
            adaptador = Inicializar();
            int i = 0;
            conexao.Open();
            i = sql.ExecuteNonQuery();
            conexao.Close();
            return i;
        }
        public static int Executar()
        {
            return Executar(out SqlDataAdapter adaptador);
        }
        public static int EditarCliente(int id, Cliente c) 
        {
            SqlCommand sql = new SqlCommand();
            sql.CommandText = $"UPDATE Clientes SET Nome = @nome, Telefone = @telefone, Rua = @rua WHERE ID = @id";
            sql.Parameters.AddWithValue("@nome", c.Nome);
            sql.Parameters.AddWithValue("@telefone", c.Telefone);
            sql.Parameters.AddWithValue("@rua", c.Rua);
            sql.Parameters.AddWithValue("@id", id);
            int linhas = Executar();
            return linhas;
        }

    }
}
