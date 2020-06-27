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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {

            PADARIA.BLL.CategoriaBLL dalCat = new PADARIA.BLL.CategoriaBLL();
            dtGrdCategoria.DataSource = "";
            dtGrdCategoria.DataSource = dalCat.select();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnlCategoria.Visible = !pnlCategoria.Visible;
            dtGrdCategoria.Visible = !dtGrdCategoria.Visible;
            txtNome.Text = "";
            lblIdValor.Text = "";
            btnAdicionar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(lblIdValor.Text);

            DialogResult resposta = MessageBox.Show("Deseja excluir a categoria" + txtNome.Text + "?", "Exclusão de categorias",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            PADARIA.BLL.CategoriaBLL dalCat = new PADARIA.BLL.CategoriaBLL();
            if (resposta == DialogResult.Yes)
            {
                dalCat.delete(idCategoria);
                dtGrdCategoria.DataSource = "";
                dtGrdCategoria.DataSource = dalCat.select();
                pnlCategoria.Visible = !pnlCategoria.Visible;
                dtGrdCategoria.Visible = !pnlCategoria.Visible;
                txtNome.Text = "";
                lblIdValor.Text = "";
                btnExcluir.Enabled = false;
                lblId.Visible = false;
                lblIdValor.Visible = false;
                btnAdicionar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlCategoria.Visible = !pnlCategoria.Visible;
            dtGrdCategoria.Visible = !dtGrdCategoria.Visible;
            txtNome.Text = "";
            lblIdValor.Text = "";
            btnExcluir.Enabled = false;
            lblId.Visible = false;
            lblIdValor.Visible = false;
            btnAdicionar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            PADARIA.MODEL.Categoria categoria = new PADARIA.MODEL.Categoria();
            categoria.nome = txtNome.Text;

            PADARIA.BLL.CategoriaBLL dalCat = new PADARIA.BLL.CategoriaBLL();

            if (lblIdValor.Text == "" || lblIdValor.Text == null)
            {
                if ((txtNome.Text == "" || txtNome.Text == null))
                {
                    MessageBox.Show("Não são permitidos campos vazios");
                }
                else
                {
                    dalCat.insert(categoria);
                }

            }
            else
            {
                if ((txtNome.Text == "" || txtNome.Text == null))
                {
                    MessageBox.Show("Não são permitidos campos vazios");
                }
                else
                {
                    categoria.id = Convert.ToInt32(lblIdValor.Text);
                    dalCat.update(categoria);
                }
            }


            dtGrdCategoria.DataSource = "";
            dtGrdCategoria.DataSource = dalCat.select();
            pnlCategoria.Visible = !pnlCategoria.Visible;
            dtGrdCategoria.Visible = !dtGrdCategoria.Visible;
            txtNome.Text = "";
            lblIdValor.Text = "";
            btnExcluir.Enabled = false;
            lblId.Visible = false;
            lblIdValor.Visible = false;
            btnAdicionar.Enabled = true;
        }

        private void dtGrdCategoria_DoubleClick(object sender, EventArgs e)
        {
            pnlCategoria.Visible = !pnlCategoria.Visible;
            dtGrdCategoria.Visible = !dtGrdCategoria.Visible;
            btnExcluir.Enabled = true;
            txtNome.Text = dtGrdCategoria.SelectedRows[0].Cells["nome"].Value.ToString();
            lblIdValor.Text = dtGrdCategoria.SelectedRows[0].Cells["id"].Value.ToString();
            lblId.Visible = true;
            lblIdValor.Visible = true;
            btnAdicionar.Enabled = false;
        }
    }
}
