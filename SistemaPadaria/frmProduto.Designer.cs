namespace SistemaPadaria
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.dtGrdProduto = new System.Windows.Forms.DataGridView();
            this.pnlProduto = new System.Windows.Forms.Panel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdProduto)).BeginInit();
            this.pnlProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrdProduto
            // 
            this.dtGrdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdProduto.Location = new System.Drawing.Point(313, 75);
            this.dtGrdProduto.Name = "dtGrdProduto";
            this.dtGrdProduto.Size = new System.Drawing.Size(397, 228);
            this.dtGrdProduto.TabIndex = 6;
            this.dtGrdProduto.DoubleClick += new System.EventHandler(this.dtGrdProduto_DoubleClick);
            // 
            // pnlProduto
            // 
            this.pnlProduto.Controls.Add(this.cmbCategoria);
            this.pnlProduto.Controls.Add(this.lblIdValor);
            this.pnlProduto.Controls.Add(this.lblId);
            this.pnlProduto.Controls.Add(this.label3);
            this.pnlProduto.Controls.Add(this.label2);
            this.pnlProduto.Controls.Add(this.lblCategoria);
            this.pnlProduto.Controls.Add(this.label1);
            this.pnlProduto.Controls.Add(this.txtQntd);
            this.pnlProduto.Controls.Add(this.txtValor);
            this.pnlProduto.Controls.Add(this.txtNome);
            this.pnlProduto.Controls.Add(this.btnCancelar);
            this.pnlProduto.Controls.Add(this.btnSalvar);
            this.pnlProduto.Location = new System.Drawing.Point(265, 75);
            this.pnlProduto.Name = "pnlProduto";
            this.pnlProduto.Size = new System.Drawing.Size(488, 216);
            this.pnlProduto.TabIndex = 8;
            this.pnlProduto.Visible = false;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(166, 26);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(218, 21);
            this.cmbCategoria.TabIndex = 9;
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Location = new System.Drawing.Point(415, 68);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(0, 13);
            this.lblIdValor.TabIndex = 5;
            this.lblIdValor.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(390, 68);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id:";
            this.lblId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(35, 29);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtQntd
            // 
            this.txtQntd.Location = new System.Drawing.Point(166, 140);
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(218, 20);
            this.txtQntd.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(166, 105);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(218, 20);
            this.txtValor.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(166, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(219, 182);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(312, 182);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.txtTitulo.Location = new System.Drawing.Point(48, 24);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(338, 39);
            this.txtTitulo.TabIndex = 7;
            this.txtTitulo.Text = "Controle de Produtos";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(55, 159);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(142, 34);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(55, 104);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(142, 34);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(55, 215);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(142, 34);
            this.btnRelatorio.TabIndex = 9;
            this.btnRelatorio.Text = "Relatorio";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.dtGrdProduto);
            this.Controls.Add(this.pnlProduto);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdProduto)).EndInit();
            this.pnlProduto.ResumeLayout(false);
            this.pnlProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdProduto;
        private System.Windows.Forms.Panel pnlProduto;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.Button btnRelatorio;
    }
}