using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.DAL
{
    class VendaDAL
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Venda> select()
        {
            List<MODEL.Venda> lstVendas = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Vendas";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    
                    MODEL.Venda venda = new MODEL.Venda();
                    venda.id = Convert.ToInt32(dados["id"].ToString());
                    venda.idCliente = Convert.ToInt32(dados["idCliente"].ToString());
                    venda.valorTotal = Convert.ToInt32(dados["valorTotal"].ToString());
                    string data = dados["data"].ToString();
                    string[] data1 = data.Split(new char[] { ' ' });

                    venda.data = data1[0];

                    lstVendas.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("Falha ao listar venda");
            }
            finally
            {
                conexao.Close();
            }
            return lstVendas;
        }

        public void insert(MODEL.Venda venda, List<MODEL.ProdutoVenda> produtoVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Vendas values (@idCliente, @valorTotal, @data); SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", venda.idCliente);
            cmd.Parameters.AddWithValue("@valorTotal", venda.valorTotal);
            cmd.Parameters.AddWithValue("@data", venda.data);
            try
            {
                conexao.Open();
                int idVenda = Convert.ToInt32(cmd.ExecuteScalar());
                for(int i = 0; i < produtoVenda.Count; i++)
                {
                    this.insertProdutoVenda(idVenda, produtoVenda[i]);
                }
            }
            catch
            {
                Console.WriteLine("Falha ao adicionar Venda");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void insertProdutoVenda(int idVenda, MODEL.ProdutoVenda produtoVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Vendas_Produto values (@idVendas, @idProduto, @quantidade, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idVendas", idVenda);
            cmd.Parameters.AddWithValue("@idProduto", produtoVenda.id);
            cmd.Parameters.AddWithValue("@quantidade", produtoVenda.quantidade);
            cmd.Parameters.AddWithValue("@valor", produtoVenda.valorTotal);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Falha ao adicionar Venda");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void update(MODEL.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Vendas SET idCliente=@idCliente, valorTotal=@valorTotal ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", venda.id);
            cmd.Parameters.AddWithValue("@idCliente", venda.idCliente);
            cmd.Parameters.AddWithValue("@valorTotal", venda.valorTotal);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Falha ao alterar Venda");
            }
            finally
            {
                conexao.Close();
            }
        }

        public MODEL.Venda selectByID(int id)
        {
            MODEL.Venda venda = new MODEL.Venda();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Vendas WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    venda.id = Convert.ToInt32(dados[0].ToString());
                    venda.idCliente = Convert.ToInt32(dados["idCliente"].ToString());
                    venda.valorTotal = Convert.ToInt32(dados["valorTotal"].ToString());
                    string data = dados["data"].ToString();
                    string[] data1 = data.Split(new char[] { ' ' });

                    venda.data = data1[0];
                }

            }
            catch
            {
                Console.WriteLine("Falha ao listar Venda");
            }
            finally
            {
                conexao.Close();
            }
            return venda;
        }

        public List<MODEL.Venda> selectByIDCliente(int idCliente)
        {
            List<MODEL.Venda> vendas = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Vendas WHERE idCliente=@idCliente;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Venda venda = new MODEL.Venda();
                    venda.id = Convert.ToInt32(dados[0].ToString());
                    venda.idCliente = Convert.ToInt32(dados["idCliente"].ToString());
                    venda.valorTotal = Convert.ToInt32(dados["valorTotal"].ToString());
                    string data = dados["data"].ToString();
                    string[] data1 = data.Split(new char[] { ' ' });

                    venda.data = data1[0];
                    vendas.Add(venda);
                }

            }
            catch
            {
                Console.WriteLine("Falha ao listar Venda");
            }
            finally
            {
                conexao.Close();
            }
            return vendas;
        }

        public List<MODEL.Venda> selectByData(string data)
        {
            List<MODEL.Venda> vendas = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Vendas WHERE data=@data;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", data);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                while (dados.Read())
                {
                    MODEL.Venda venda = new MODEL.Venda();
                    venda.id = Convert.ToInt32(dados[0].ToString());
                    venda.idCliente = Convert.ToInt32(dados["idCliente"].ToString());
                    venda.valorTotal = Convert.ToInt32(dados["valorTotal"].ToString());
                    string date = dados["data"].ToString();
                    string[] data1 = date.Split(new char[] { ' ' });

                    venda.data = data1[0];
                    vendas.Add(venda);
                }

            }
            catch
            {
                Console.WriteLine("Falha ao listar Venda");
            }
            finally
            {
                conexao.Close();
            }
            return vendas;
        }

        public void delete(int idVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Vendas  WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idVenda);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remoção  de Vendas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Venda> pesquisar(string pesquisaNome)
        {
            List<MODEL.Venda> lstVendas = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Vendas WHERE nome=nome";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Venda venda = new MODEL.Venda();
                    venda.id = Convert.ToInt32(dados[0].ToString());
                    venda.idCliente = Convert.ToInt32(dados["idCliente"].ToString());
                    venda.valorTotal = Convert.ToInt32(dados["valorTotal"].ToString());
                    lstVendas.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("Falha ao cadastrar venda");
            }
            finally
            {
                conexao.Close();
            }
            return lstVendas;
        }
    }
}
