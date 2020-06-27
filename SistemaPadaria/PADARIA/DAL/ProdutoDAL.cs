using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.DAL
{
    class ProdutoDAL
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Produto> select()
        {
            List<MODEL.Produto> lstProduto = new List<MODEL.Produto>();
            DAL.CategoriaDAL categoriaDal = new CategoriaDAL();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.nome = dados["nome"].ToString();
                    produto.idCategoria = Convert.ToInt32(dados["idCategoria"].ToString());
                    produto.valor = float.Parse(dados["valor"].ToString());
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.categoria = categoriaDal.selectByID(produto.idCategoria).nome;
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Falha ao listar Produto");
            }
            finally
            {
                conexao.Close();
            }
            return lstProduto;
        }

        public void insert(MODEL.Produto produto)
        {
            Console.WriteLine(produto.idCategoria + produto.nome + produto.valor + produto.quantidade);
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Produtos VALUES (@idCategoria, @quantidade, @nome, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@idCategoria", produto.idCategoria);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Falha ao adicionar Produto");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void update(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Produtos SET nome=@nome, idCategoria=@idCategoria, valor=@valor, quantidade=@quantidade ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            cmd.Parameters.AddWithValue("@idCategoria", produto.idCategoria);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Falha ao alterar Produto");
            }
            finally
            {
                conexao.Close();
            }
        }

        public MODEL.Produto selectByID(int id)
        {
            MODEL.Produto produto = new MODEL.Produto();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Produtos WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.nome = dados["nome"].ToString();
                    produto.idCategoria = Convert.ToInt32(dados["idCategoria"].ToString());
                    produto.valor = float.Parse(dados["valor"].ToString());
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                }

            }
            catch
            {
                Console.WriteLine("Falha ao listar Produto");
            }
            finally
            {
                conexao.Close();
            }
            return produto;
        }

        public void delete(int idProduto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Produtos  WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idProduto);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remoção  de Produto...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
