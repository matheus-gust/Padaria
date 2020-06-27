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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            PADARIA.BLL.CategoriaBLL categoria = new PADARIA.BLL.CategoriaBLL();
            PADARIA.BLL.ProdutoBLL dalProd = new PADARIA.BLL.ProdutoBLL();
            cmbCategoria.DisplayMember = "nome";
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DataSource = categoria.select();
            cmbCategoria.SelectedItem = null;
            dtGrdProduto.DataSource = "";
            dtGrdProduto.DataSource = dalProd.select();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnlProduto.Visible = !pnlProduto.Visible;
            dtGrdProduto.Visible = !dtGrdProduto.Visible;
            cmbCategoria.SelectedItem = null;
            txtValor.Text = "";
            txtNome.Text = "";
            txtQntd.Text = "";
            btnAdicionar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(lblIdValor.Text);

            DialogResult resposta = MessageBox.Show("Deseja excluir o Produto " + txtNome.Text + "?", "Exclusão de produtos",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            PADARIA.BLL.ProdutoBLL dalProd = new PADARIA.BLL.ProdutoBLL();
            if (resposta == DialogResult.Yes)
            {
                dalProd.delete(idProduto);
                dtGrdProduto.DataSource = "";
                dtGrdProduto.DataSource = dalProd.select();
                pnlProduto.Visible = !pnlProduto.Visible;
                dtGrdProduto.Visible = !dtGrdProduto.Visible;
                txtValor.Text = "";
                lblIdValor.Text = "";
                txtNome.Text = "";
                txtQntd.Text = "";
                cmbCategoria.SelectedItem = null;
                btnExcluir.Enabled = false;
                lblId.Visible = false;
                lblIdValor.Visible = false;
                btnAdicionar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlProduto.Visible = !pnlProduto.Visible;
            dtGrdProduto.Visible = !dtGrdProduto.Visible;
            txtValor.Text = "";
            txtNome.Text = "";
            txtQntd.Text = "";
            lblIdValor.Text = "";
            cmbCategoria.SelectedItem = null;
            btnExcluir.Enabled = false;
            lblId.Visible = false;
            lblIdValor.Visible = false;
            btnAdicionar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PADARIA.MODEL.Produto produto = new PADARIA.MODEL.Produto();
            produto.nome = txtNome.Text;
            produto.idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            produto.quantidade = Convert.ToInt32(txtQntd.Text);
            produto.valor = float.Parse(txtValor.Text);

            PADARIA.BLL.ProdutoBLL dalProd = new PADARIA.BLL.ProdutoBLL();

            if (lblIdValor.Text == "" || lblIdValor.Text == null)
            {
                if ((txtQntd.Text == "" || txtQntd.Text == null) || 
                    (txtNome.Text == "" || txtNome.Text == null) ||
                    (txtValor.Text == "" || txtValor.Text == null) ||
                    (cmbCategoria.SelectedItem == null))
                {
                    MessageBox.Show("Não são permitidos campos vazios");
                }
                else
                {
                    dalProd.insert(produto);
                }

            }
            else
            {
                if ((txtQntd.Text == "" || txtQntd.Text == null) ||
                    (txtNome.Text == "" || txtNome.Text == null) ||
                    (txtValor.Text == "" || txtValor.Text == null) ||
                    (cmbCategoria.SelectedItem == null))
                {
                    MessageBox.Show("Não são permitidos campos vazios");
                }
                else
                {
                    produto.id = Convert.ToInt32(lblIdValor.Text);
                    dalProd.update(produto);
                }
            }


            dtGrdProduto.DataSource = "";
            dtGrdProduto.DataSource = dalProd.select();
            pnlProduto.Visible = !pnlProduto.Visible;
            dtGrdProduto.Visible = !dtGrdProduto.Visible;
            txtValor.Text = "";
            txtNome.Text = "";
            lblIdValor.Text = "";
            txtQntd.Text = "";
            cmbCategoria.SelectedItem = null;
            btnExcluir.Enabled = false;
            lblId.Visible = false;
            lblIdValor.Visible = false;
            btnAdicionar.Enabled = true;
        }

        private void dtGrdProduto_DoubleClick(object sender, EventArgs e)
        {
            pnlProduto.Visible = !pnlProduto.Visible;
            dtGrdProduto.Visible = !dtGrdProduto.Visible;
            btnExcluir.Enabled = true;
            cmbCategoria.SelectedValue = dtGrdProduto.SelectedRows[0].Cells["idCategoria"].Value.ToString();
            txtNome.Text = dtGrdProduto.SelectedRows[0].Cells["nome"].Value.ToString();
            txtValor.Text = dtGrdProduto.SelectedRows[0].Cells["valor"].Value.ToString();
            txtQntd.Text = dtGrdProduto.SelectedRows[0].Cells["quantidade"].Value.ToString();
            lblIdValor.Text = dtGrdProduto.SelectedRows[0].Cells["id"].Value.ToString();
            lblId.Visible = true;
            lblIdValor.Visible = true;
            btnAdicionar.Enabled = false;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RELATORIOS.RelGerais.relProdutos();
        }
    }
}
