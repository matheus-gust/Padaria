namespace SistemaPadaria
{
    partial class frmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.label1 = new System.Windows.Forms.Label();
            this.dtGrdVenda = new System.Windows.Forms.DataGridView();
            this.pnlVenda = new System.Windows.Forms.Panel();
            this.txtValorUnico = new System.Windows.Forms.TextBox();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.lblValorTotalNum = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.dtGrdCarrinho = new System.Windows.Forms.DataGridView();
            this.btnRmvProduto = new System.Windows.Forms.Button();
            this.btnAdProduto = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnlImagem = new System.Windows.Forms.Panel();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.dataConsultar = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesquisas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVenda)).BeginInit();
            this.pnlVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCarrinho)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de vendas";
            // 
            // dtGrdVenda
            // 
            this.dtGrdVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVenda.Location = new System.Drawing.Point(34, 223);
            this.dtGrdVenda.Name = "dtGrdVenda";
            this.dtGrdVenda.Size = new System.Drawing.Size(360, 183);
            this.dtGrdVenda.TabIndex = 11;
            // 
            // pnlVenda
            // 
            this.pnlVenda.Controls.Add(this.txtValorUnico);
            this.pnlVenda.Controls.Add(this.txtQntd);
            this.pnlVenda.Controls.Add(this.lblValorTotalNum);
            this.pnlVenda.Controls.Add(this.lblValorTotal);
            this.pnlVenda.Controls.Add(this.dtGrdCarrinho);
            this.pnlVenda.Controls.Add(this.btnRmvProduto);
            this.pnlVenda.Controls.Add(this.btnAdProduto);
            this.pnlVenda.Controls.Add(this.cmbProduto);
            this.pnlVenda.Controls.Add(this.cmbCliente);
            this.pnlVenda.Controls.Add(this.lblIdValor);
            this.pnlVenda.Controls.Add(this.lblId);
            this.pnlVenda.Controls.Add(this.label4);
            this.pnlVenda.Controls.Add(this.label5);
            this.pnlVenda.Controls.Add(this.label3);
            this.pnlVenda.Controls.Add(this.label2);
            this.pnlVenda.Controls.Add(this.btnCancelar);
            this.pnlVenda.Controls.Add(this.btnSalvar);
            this.pnlVenda.Location = new System.Drawing.Point(265, 44);
            this.pnlVenda.Name = "pnlVenda";
            this.pnlVenda.Size = new System.Drawing.Size(510, 381);
            this.pnlVenda.TabIndex = 12;
            this.pnlVenda.Visible = false;
            // 
            // txtValorUnico
            // 
            this.txtValorUnico.Enabled = false;
            this.txtValorUnico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtValorUnico.Location = new System.Drawing.Point(382, 73);
            this.txtValorUnico.Name = "txtValorUnico";
            this.txtValorUnico.Size = new System.Drawing.Size(63, 20);
            this.txtValorUnico.TabIndex = 18;
            this.txtValorUnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQntd
            // 
            this.txtQntd.Enabled = false;
            this.txtQntd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtQntd.Location = new System.Drawing.Point(158, 104);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(56, 20);
            this.txtQntd.TabIndex = 18;
            this.txtQntd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorTotalNum
            // 
            this.lblValorTotalNum.AutoSize = true;
            this.lblValorTotalNum.Location = new System.Drawing.Point(90, 313);
            this.lblValorTotalNum.Name = "lblValorTotalNum";
            this.lblValorTotalNum.Size = new System.Drawing.Size(13, 13);
            this.lblValorTotalNum.TabIndex = 17;
            this.lblValorTotalNum.Text = "0";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(27, 313);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(57, 13);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "Valor total:";
            // 
            // dtGrdCarrinho
            // 
            this.dtGrdCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdCarrinho.Location = new System.Drawing.Point(30, 168);
            this.dtGrdCarrinho.Name = "dtGrdCarrinho";
            this.dtGrdCarrinho.Size = new System.Drawing.Size(346, 142);
            this.dtGrdCarrinho.TabIndex = 15;
            this.dtGrdCarrinho.DoubleClick += new System.EventHandler(this.dtGrdCarrinho_DoubleClick);
            // 
            // btnRmvProduto
            // 
            this.btnRmvProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRmvProduto.BackgroundImage")));
            this.btnRmvProduto.Location = new System.Drawing.Point(451, 168);
            this.btnRmvProduto.Name = "btnRmvProduto";
            this.btnRmvProduto.Size = new System.Drawing.Size(45, 23);
            this.btnRmvProduto.TabIndex = 14;
            this.btnRmvProduto.UseVisualStyleBackColor = true;
            this.btnRmvProduto.Click += new System.EventHandler(this.btnRmvProduto_Click);
            // 
            // btnAdProduto
            // 
            this.btnAdProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdProduto.BackgroundImage")));
            this.btnAdProduto.Location = new System.Drawing.Point(451, 72);
            this.btnAdProduto.Name = "btnAdProduto";
            this.btnAdProduto.Size = new System.Drawing.Size(45, 23);
            this.btnAdProduto.TabIndex = 14;
            this.btnAdProduto.UseVisualStyleBackColor = true;
            this.btnAdProduto.Click += new System.EventHandler(this.btnAdProduto_Click);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(158, 72);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(218, 21);
            this.cmbProduto.TabIndex = 13;
            this.cmbProduto.SelectionChangeCommitted += new System.EventHandler(this.cmbProduto_SelectionChangeCommitted);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(158, 42);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(218, 21);
            this.cmbCliente.TabIndex = 13;
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Location = new System.Drawing.Point(52, 17);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(0, 13);
            this.lblIdValor.TabIndex = 5;
            this.lblIdValor.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(27, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id:";
            this.lblId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carrinho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(301, 342);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(34, 134);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(142, 34);
            this.btnRelatorio.TabIndex = 9;
            this.btnRelatorio.Text = "Gerar Relatorio";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(34, 82);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(142, 34);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pnlImagem
            // 
            this.pnlImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImagem.BackgroundImage")));
            this.pnlImagem.Location = new System.Drawing.Point(428, 32);
            this.pnlImagem.Name = "pnlImagem";
            this.pnlImagem.Size = new System.Drawing.Size(347, 374);
            this.pnlImagem.TabIndex = 13;
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Controls.Add(this.dataConsultar);
            this.pnlPesquisa.Controls.Add(this.btnLimpar);
            this.pnlPesquisa.Controls.Add(this.rdbData);
            this.pnlPesquisa.Controls.Add(this.rdbNome);
            this.pnlPesquisa.Controls.Add(this.btnPesquisar);
            this.pnlPesquisa.Controls.Add(this.label6);
            this.pnlPesquisa.Controls.Add(this.txtPesquisas);
            this.pnlPesquisa.Location = new System.Drawing.Point(194, 61);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(223, 123);
            this.pnlPesquisa.TabIndex = 14;
            // 
            // dataConsultar
            // 
            this.dataConsultar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataConsultar.Location = new System.Drawing.Point(9, 58);
            this.dataConsultar.Name = "dataConsultar";
            this.dataConsultar.Size = new System.Drawing.Size(191, 20);
            this.dataConsultar.TabIndex = 5;
            this.dataConsultar.Value = new System.DateTime(2020, 6, 27, 1, 15, 13, 0);
            this.dataConsultar.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(33, 87);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rdbData
            // 
            this.rdbData.AutoSize = true;
            this.rdbData.Location = new System.Drawing.Point(71, 30);
            this.rdbData.Name = "rdbData";
            this.rdbData.Size = new System.Drawing.Size(48, 17);
            this.rdbData.TabIndex = 3;
            this.rdbData.Text = "Data";
            this.rdbData.UseVisualStyleBackColor = true;
            this.rdbData.CheckedChanged += new System.EventHandler(this.rdbData_CheckedChanged);
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Checked = true;
            this.rdbNome.Location = new System.Drawing.Point(9, 30);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 3;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(126, 87);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pesquisa";
            // 
            // txtPesquisas
            // 
            this.txtPesquisas.Location = new System.Drawing.Point(9, 58);
            this.txtPesquisas.Name = "txtPesquisas";
            this.txtPesquisas.Size = new System.Drawing.Size(192, 20);
            this.txtPesquisas.TabIndex = 0;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.pnlImagem);
            this.Controls.Add(this.dtGrdVenda);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlVenda);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVenda)).EndInit();
            this.pnlVenda.ResumeLayout(false);
            this.pnlVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCarrinho)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGrdVenda;
        private System.Windows.Forms.Panel pnlVenda;
        private System.Windows.Forms.DataGridView dtGrdCarrinho;
        private System.Windows.Forms.Button btnAdProduto;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblValorTotalNum;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnRmvProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorUnico;
        private System.Windows.Forms.Panel pnlImagem;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesquisas;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dataConsultar;
    }
}