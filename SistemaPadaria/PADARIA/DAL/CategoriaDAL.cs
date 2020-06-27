using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.DAL
{
    class CategoriaDAL
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Categoria> select()
        {
            List<MODEL.Categoria> lstCategorias = new List<MODEL.Categoria>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Categoria";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Categoria categoria = new MODEL.Categoria();
                    categoria.id = Convert.ToInt32(dados["id"].ToString());
                    categoria.nome = dados["nome"].ToString();
                    
                    lstCategorias.Add(categoria);
                }
            }
            catch
            {
                Console.WriteLine("Falha ao listar categorias");
            }
            finally
            {
                conexao.Close();
            }
            return lstCategorias;
        }

        public void insert(MODEL.Categoria categoria)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Categoria values (@nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", categoria.nome);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Falha ao adicionar Categoria");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void update(MODEL.Categoria categoria)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Categoria SET nome=@nome ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", categoria.id);
            cmd.Parameters.AddWithValue("@nome", categoria.nome);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Falha ao alterar categoria");
            }
            finally
            {
                conexao.Close();
            }
        }

        public MODEL.Categoria selectByID(int id)
        {
            MODEL.Categoria categoria = new MODEL.Categoria();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Categoria WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    categoria.id = Convert.ToInt32(dados[0].ToString());
                    categoria.nome = dados["nome"].ToString();
                }

            }
            catch
            {
                Console.WriteLine("Falha ao listar categoria");
            }
            finally
            {
                conexao.Close();
            }
            return categoria;
        }

        public void delete(int idCategoria)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Categoria  WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCategoria);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remoção  de categoria...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
