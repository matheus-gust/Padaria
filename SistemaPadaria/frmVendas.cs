using SistemaPadaria.PADARIA.MODEL;
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
    public partial class frmVendas : Form
    {

        List<PADARIA.MODEL.ProdutoVenda> produtosCarrinho = new List<PADARIA.MODEL.ProdutoVenda>();
        string produtoARemover = "";
        string linhaRemover = "";

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            PADARIA.BLL.ClienteBLL clienteBLL = new PADARIA.BLL.ClienteBLL();
            PADARIA.BLL.ProdutoBLL produtoBLL = new PADARIA.BLL.ProdutoBLL();
            PADARIA.BLL.VendasBLL vendasBLL = new PADARIA.BLL.VendasBLL(); 
            List<PADARIA.MODEL.Produto> produtos = new List<PADARIA.MODEL.Produto>();

            produtos = produtoBLL.select();
            for(int i = 0; i < produtos.Count; i++)
            {
                if(produtos[i].quantidade <= 0)
                {
                    produtos.RemoveAt(i);
                }
            }

            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = clienteBLL.select();
            cmbCliente.SelectedItem = null;

            cmbProduto.DisplayMember = "nome";
            cmbProduto.ValueMember = "id";
            cmbProduto.DataSource = produtos;
            cmbProduto.SelectedItem = null;

            dtGrdVenda.DataSource = "";
            dtGrdVenda.DataSource = vendasBLL.select();
            
        }

        private void btnAdProduto_Click(object sender, EventArgs e)
        {
            if((cmbProduto.SelectedValue != null) 
                && (txtQntd.Text != "" && Convert.ToInt32(txtQntd.Text) > 0))
            {
                PADARIA.BLL.ProdutoBLL produtoBLL = new PADARIA.BLL.ProdutoBLL();
                PADARIA.MODEL.Produto produto = produtoBLL.selectByID(Convert.ToInt32(cmbProduto.SelectedValue));
                if (produto.quantidade - Convert.ToInt32(txtQntd.Text) >= 0)
                {
                    float valorTotal = float.Parse(lblValorTotalNum.Text);
                    PADARIA.MODEL.ProdutoVenda produtoVenda = PADARIA.MODEL.ProdutoVenda.Converter(produto, int.Parse(txtQntd.Text));

                    lblValorTotalNum.Text = (valorTotal + (produto.valor * int.Parse(txtQntd.Text))).ToString();
                    
                    bool jaInserido = false;

                    for(int i = 0; i < this.produtosCarrinho.Count; i++)
                    {
                        if(this.produtosCarrinho[i].id == produtoVenda.id)
                        {
                            jaInserido = true;
                            this.produtosCarrinho[i].quantidade += produtoVenda.quantidade;
                            this.produtosCarrinho[i].valorTotal += produtoVenda.quantidade * produto.valor;


                        }
                    }

                    if(jaInserido == false)
                    {
                        produtosCarrinho.Add(produtoVenda);
                    }

                    dtGrdCarrinho.DataSource = "";
                    dtGrdCarrinho.DataSource = produtosCarrinho;

                    cmbProduto.SelectedItem = null;
                    txtQntd.Text = "";
                    txtValorUnico.Text = "";
                    txtQntd.Enabled = false;

                } else
                {
                    MessageBox.Show("Estoque insulficiente" + " atualmente " + produto.quantidade);
                }
            } else
            {
                MessageBox.Show("Produtos ou quantidades não especificadas");
            }
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnlVenda.Visible = true;
            btnRelatorio.Enabled = false;
            dtGrdVenda.Visible = false;
            pnlImagem.Visible = false;
            pnlPesquisa.Visible = false;
            
        }

        private void cmbProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PADARIA.BLL.ProdutoBLL produtoBLL = new PADARIA.BLL.ProdutoBLL();
            PADARIA.MODEL.Produto produto = produtoBLL.selectByID(Convert.ToInt32(cmbProduto.SelectedValue));
            txtQntd.Enabled = true;
            txtValorUnico.Text = "R$ " + produto.valor.ToString();
        }

        private void btnRmvProduto_Click(object sender, EventArgs e)
        {
            if (this.produtoARemover != "")
            {
                float valorTotal = float.Parse(lblValorTotalNum.Text);
                for (int i = 0; i < this.produtosCarrinho.Count; i++)
                {
                    if(dtGrdCarrinho.Rows[i].Cells["id"].Value.ToString() == this.produtoARemover 
                        && this.linhaRemover == dtGrdCarrinho.Rows[i].Index.ToString())
                    {
                        valorTotal -= produtosCarrinho[i].valorTotal;
                        produtosCarrinho.RemoveAt(i);
                    }
                }
                produtoARemover = "";
                dtGrdCarrinho.DataSource = "";
                dtGrdCarrinho.DataSource = this.produtosCarrinho;
                lblValorTotalNum.Text = valorTotal.ToString();
            } else
            {
                MessageBox.Show("Selecione o item a remover");
            }
        }

        private void dtGrdCarrinho_DoubleClick(object sender, EventArgs e)
        {
            this.produtoARemover = dtGrdCarrinho.SelectedRows[0].Cells["id"].Value.ToString();
            this.linhaRemover = dtGrdCarrinho.SelectedRows[0].Index.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PADARIA.BLL.VendasBLL vendasBLL = new PADARIA.BLL.VendasBLL();
            this.zerarValores();
            pnlVenda.Visible = false;
            pnlImagem.Visible = true;
            dtGrdVenda.Visible = true;
            pnlPesquisa.Visible = true;
            dtGrdVenda.DataSource = "";
            dtGrdVenda.DataSource = vendasBLL.select();
        }

        private void zerarValores()
        {
            cmbCliente.SelectedItem = null;
            cmbProduto.SelectedItem = null;
            txtQntd.Text = "";
            txtValorUnico.Text = "";
            dtGrdCarrinho.DataSource = "";
            lblValorTotalNum.Text = "0";
            btnRelatorio.Enabled = true;
            lblIdValor.Text = "";
            this.produtoARemover = "";
            this.produtosCarrinho = new List<PADARIA.MODEL.ProdutoVenda>();
            this.linhaRemover = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(cmbCliente.SelectedValue != null && this.produtosCarrinho.Count > 0)
            {
                PADARIA.BLL.VendasBLL vendaBll = new PADARIA.BLL.VendasBLL();
                PADARIA.MODEL.Venda venda = new PADARIA.MODEL.Venda();
                venda.idCliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                venda.valorTotal = Convert.ToInt32(lblValorTotalNum.Text);
                venda.data = DateTime.Now.Date.ToString();
                vendaBll.insert(venda, this.produtosCarrinho);

                this.zerarValores();
                pnlVenda.Visible = false;
                dtGrdVenda.Visible = true;
                pnlImagem.Visible = true;
                dtGrdVenda.DataSource = "";
                pnlPesquisa.Visible = true;
                dtGrdVenda.DataSource = vendaBll.select();
            } else
            {
                MessageBox.Show("Cliente e/ou carrinho vazios");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txtPesquisas.Text != null && txtPesquisas.Text != "" || dataConsultar.Value != null)
            {
                PADARIA.BLL.VendasBLL vendasBLL = new PADARIA.BLL.VendasBLL();

                if(rdbNome.Checked == true)
                {
                    List<PADARIA.MODEL.VendaConsulta> vendas = vendasBLL.pesquisar(txtPesquisas.Text);

                    if (vendas.Count <= 0)
                    {
                        MessageBox.Show("Nenhuma venda com esse cliente encontrado");
                    }
                    else
                    {
                        dtGrdVenda.DataSource = "";
                        dtGrdVenda.DataSource = vendas;
                    }
                } else if (rdbData.Checked == true) {
                    List<PADARIA.MODEL.VendaConsulta> vendas = vendasBLL.pesquisarPorData(dataConsultar.Value.Year + "-" + dataConsultar.Value.Month + "-" + dataConsultar.Value.Day);
                    if (vendas.Count <= 0)
                    {
                        MessageBox.Show("Nenhuma venda com essa data encontrado");
                    } else
                    {
                        dtGrdVenda.DataSource = "";
                        dtGrdVenda.DataSource = vendas;
                    }
                } else
                {
                    MessageBox.Show("Selecione o campo de pesquisa");
                }
                
            } else
            {
                MessageBox.Show("Campo de pesquisa vazio");
            }
        }

        private void rdbData_CheckedChanged(object sender, EventArgs e)
        {
            rdbNome.Checked = false;
            txtPesquisas.Visible = false;
            dataConsultar.Visible = true;
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            rdbData.Checked = false;
            dataConsultar.Visible = false;
            txtPesquisas.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            PADARIA.BLL.VendasBLL vendasBLL = new PADARIA.BLL.VendasBLL();
            txtPesquisas.Text = "";
            dtGrdVenda.DataSource = "";
            dtGrdVenda.DataSource = vendasBLL.select();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RELATORIOS.RelGerais.relVendas();
        }
    }
}
