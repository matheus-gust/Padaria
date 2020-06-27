using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPadaria.PADARIA.DAL
{
    public class ClienteDAL
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cliente> select()
        {
            List<MODEL.Cliente> lstClientes = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(dados[0].ToString()); //dados["id"]
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.cpf = dados["cpf"].ToString();
                    lstClientes.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Falha ao cadastrar cliente");
            }
            finally
            {
                conexao.Close();
            }
            return lstClientes;
        }

        public void insert(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values (@nome, @endereco, @telefone, @cpf);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Falha ao adicionar cliente");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void update(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Cliente SET nome=@nome, endereco=@endereco, telefone=@telefone, cpf=@cpf ";
            sql += " WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Falha ao alterar cliente");
            }
            finally
            {
                conexao.Close();
            }
        }

        public MODEL.Cliente selectByID(int id)
        {
            MODEL.Cliente cliente = new MODEL.Cliente();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Cliente WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    cliente.id = Convert.ToInt32(dados[0].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.cpf = dados["cpf"].ToString();
                }

            }
            catch
            {
                Console.WriteLine("Falha ao listar cliente");
            }
            finally
            {
                conexao.Close();
            }
            return cliente;
        }

        public void delete(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Cliente  WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idCliente);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remoção  de clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public MODEL.Cliente selectByNome(string nome)
        {
            MODEL.Cliente cliente = new MODEL.Cliente();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Cliente WHERE nome=@nome;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read())
                {
                    cliente.id = Convert.ToInt32(dados[0].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.telefone = dados["telefone"].ToString();
                    cliente.cpf = dados["cpf"].ToString();
                }

            }
            catch
            {
                Console.WriteLine("Falha ao listar cliente");
            }
            finally
            {
                conexao.Close();
            }
            return cliente;
        }
    }
}
