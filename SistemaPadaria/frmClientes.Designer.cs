namespace SistemaPadaria
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.dtGrdCliente = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCliente)).BeginInit();
            this.pnlCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrdCliente
            // 
            this.dtGrdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdCliente.Location = new System.Drawing.Point(309, 97);
            this.dtGrdCliente.Name = "dtGrdCliente";
            this.dtGrdCliente.Size = new System.Drawing.Size(397, 183);
            this.dtGrdCliente.TabIndex = 1;
            this.dtGrdCliente.DoubleClick += new System.EventHandler(this.dtGrdCliente_DoubleClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(55, 140);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(142, 34);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.txtTitulo.Location = new System.Drawing.Point(48, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(318, 39);
            this.txtTitulo.TabIndex = 2;
            this.txtTitulo.Text = "Controle de clientes";
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblIdValor);
            this.pnlCliente.Controls.Add(this.lblId);
            this.pnlCliente.Controls.Add(this.label4);
            this.pnlCliente.Controls.Add(this.label3);
            this.pnlCliente.Controls.Add(this.label2);
            this.pnlCliente.Controls.Add(this.label1);
            this.pnlCliente.Controls.Add(this.txtTelefone);
            this.pnlCliente.Controls.Add(this.txtCpf);
            this.pnlCliente.Controls.Add(this.txtEndereco);
            this.pnlCliente.Controls.Add(this.txtNome);
            this.pnlCliente.Controls.Add(this.btnCancelar);
            this.pnlCliente.Controls.Add(this.btnSalvar);
            this.pnlCliente.Location = new System.Drawing.Point(264, 83);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(488, 209);
            this.pnlCliente.TabIndex = 3;
            this.pnlCliente.Visible = false;
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Location = new System.Drawing.Point(422, 14);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(0, 13);
            this.lblIdValor.TabIndex = 5;
            this.lblIdValor.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(397, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id:";
            this.lblId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(173, 51);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(218, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(173, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(213, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(306, 159);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(55, 195);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(142, 34);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(173, 90);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(218, 20);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(173, 126);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(218, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.dtGrdCliente);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCliente)).EndInit();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdCliente;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
    }
}