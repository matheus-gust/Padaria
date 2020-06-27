namespace SistemaPadaria
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.dtGrdCategoria = new System.Windows.Forms.DataGridView();
            this.pnlCategoria = new System.Windows.Forms.Panel();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCategoria)).BeginInit();
            this.pnlCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrdCategoria
            // 
            this.dtGrdCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdCategoria.Location = new System.Drawing.Point(319, 91);
            this.dtGrdCategoria.Name = "dtGrdCategoria";
            this.dtGrdCategoria.Size = new System.Drawing.Size(397, 183);
            this.dtGrdCategoria.TabIndex = 6;
            this.dtGrdCategoria.DoubleClick += new System.EventHandler(this.dtGrdCategoria_DoubleClick);
            // 
            // pnlCategoria
            // 
            this.pnlCategoria.Controls.Add(this.lblIdValor);
            this.pnlCategoria.Controls.Add(this.lblId);
            this.pnlCategoria.Controls.Add(this.label1);
            this.pnlCategoria.Controls.Add(this.txtNome);
            this.pnlCategoria.Controls.Add(this.btnCancelar);
            this.pnlCategoria.Controls.Add(this.btnSalvar);
            this.pnlCategoria.Location = new System.Drawing.Point(273, 124);
            this.pnlCategoria.Name = "pnlCategoria";
            this.pnlCategoria.Size = new System.Drawing.Size(488, 120);
            this.pnlCategoria.TabIndex = 8;
            this.pnlCategoria.Visible = false;
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Location = new System.Drawing.Point(413, 34);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(0, 13);
            this.lblIdValor.TabIndex = 5;
            this.lblIdValor.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(388, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id:";
            this.lblId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(164, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(215, 68);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(308, 68);
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
            this.txtTitulo.Location = new System.Drawing.Point(55, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(359, 39);
            this.txtTitulo.TabIndex = 7;
            this.txtTitulo.Text = "Controle de categorias";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(62, 195);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(142, 34);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(62, 140);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(142, 34);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.dtGrdCategoria);
            this.Controls.Add(this.pnlCategoria);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCategoria)).EndInit();
            this.pnlCategoria.ResumeLayout(false);
            this.pnlCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdCategoria;
        private System.Windows.Forms.Panel pnlCategoria;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
    }
}