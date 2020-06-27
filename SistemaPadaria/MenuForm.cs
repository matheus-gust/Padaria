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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.MdiParent = this;
            categorias.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto produtos = new frmProduto();
            produtos.MdiParent = this;
            produtos.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas vendas = new frmVendas();
            vendas.MdiParent = this;
            vendas.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
