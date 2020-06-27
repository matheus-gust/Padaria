using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPadaria
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            PADARIA.BLL.ClienteBLL dalCli = new PADARIA.BLL.ClienteBLL();
            dtGrdCliente.DataSource = "";
            dtGrdCliente.DataSource = dalCli.select();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = !pnlCliente.Visible;
            dtGrdCliente.Visible = !dtGrdCliente.Visible;
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            lblIdValor.Text = "";
            btnAdicionar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlCliente.Visible = !pnlCliente.Visible;
            dtGrdCliente.Visible = !dtGrdCliente.Visible;
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            lblIdValor.Text = "";
            btnExcluir.Enabled = false;
            lblId.Visible = false;
            lblIdValor.Visible = false;
            btnAdicionar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PADARIA.MODEL.Cliente cliente = new PADARIA.MODEL.Cliente();
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.cpf = txtCpf.Text;


            PADARIA.BLL.ClienteBLL dalCli = new PADARIA.BLL.ClienteBLL();

            if(lblIdValor.Text == "" || lblIdValor.Text == null)
            {
                if ((txtEndereco.Text == "" || txtEndereco.Text == null) || 
                    (txtNome.Text == "" || txtNome.Text == null) ||
                    (txtCpf.Text == "" || txtCpf.Text == null) ||
                    (txtTelefone.Text == "" || txtTelefone.Text == null))
                {
                    MessageBox.Show("Não são permitidos campos vazios");
                } else
                {
                    dalCli.insert(cliente);

                    dtGrdCliente.DataSource = "";
                    dtGrdCliente.DataSource = dalCli.select();
                    pnlCliente.Visible = !pnlCliente.Visible;
                    dtGrdCliente.Visible = !dtGrdCliente.Visible;
                    txtEndereco.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtTelefone.Text = "";
                    lblIdValor.Text = "";
                    btnExcluir.Enabled = false;
                    lblId.Visible = false;
                    lblIdValor.Visible = false;
                    btnAdicionar.Enabled = true;
                }
                
            } else
            {
                if ((txtEndereco.Text == "" || txtEndereco.Text == null) || 
                    (txtNome.Text == "" || txtNome.Text == null) ||
                    (txtCpf.Text == "" || txtCpf.Text == null) ||
                    (txtTelefone.Text == "" || txtTelefone.Text == null))
                {
                    MessageBox.Show("Não são permitidos campos vazios");
                }
                else
                {
                    cliente.id = Convert.ToInt32(lblIdValor.Text);
                    dalCli.update(cliente);

                    dtGrdCliente.DataSource = "";
                    dtGrdCliente.DataSource = dalCli.select();
                    pnlCliente.Visible = !pnlCliente.Visible;
                    dtGrdCliente.Visible = !dtGrdCliente.Visible;
                    txtEndereco.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    lblIdValor.Text = "";
                    txtTelefone.Text = "";
                    btnExcluir.Enabled = false;
                    lblId.Visible = false;
                    lblIdValor.Visible = false;
                    btnAdicionar.Enabled = true;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(lblIdValor.Text);

            DialogResult resposta = MessageBox.Show("Deseja excluir o cliente" + txtNome.Text + "?", "Exclusão de clientes", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            PADARIA.BLL.ClienteBLL dalCli = new PADARIA.BLL.ClienteBLL();
            if (resposta == DialogResult.Yes)
            {
                dalCli.delete(idCliente);
                dtGrdCliente.DataSource = "";
                dtGrdCliente.DataSource = dalCli.select();
                pnlCliente.Visible = !pnlCliente.Visible;
                dtGrdCliente.Visible = !dtGrdCliente.Visible;
                txtEndereco.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                lblIdValor.Text = "";
                txtTelefone.Text = "";
                btnExcluir.Enabled = false;
                lblId.Visible = false;
                lblIdValor.Visible = false;
                btnAdicionar.Enabled = true;
            }
        }

        private void dtGrdCliente_DoubleClick(object sender, EventArgs e)
        {
            pnlCliente.Visible = !pnlCliente.Visible;
            dtGrdCliente.Visible = !dtGrdCliente.Visible;
            btnExcluir.Enabled = true;
            txtNome.Text = dtGrdCliente.SelectedRows[0].Cells["nome"].Value.ToString();
            txtEndereco.Text = dtGrdCliente.SelectedRows[0].Cells["endereco"].Value.ToString();
            lblIdValor.Text = dtGrdCliente.SelectedRows[0].Cells["id"].Value.ToString();
            txtTelefone.Text = dtGrdCliente.SelectedRows[0].Cells["telefone"].Value.ToString();
            txtCpf.Text = dtGrdCliente.SelectedRows[0].Cells["cpf"].Value.ToString();
            lblId.Visible = true;
            lblIdValor.Visible = true;
            btnAdicionar.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
