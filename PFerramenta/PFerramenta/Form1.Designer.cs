namespace PFerramenta
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFerramenta = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtSiteOficial = new System.Windows.Forms.TextBox();
            this.txtDistribuicao = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFerramenta
            // 
            this.dgvFerramenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFerramenta.Location = new System.Drawing.Point(43, 12);
            this.dgvFerramenta.Name = "dgvFerramenta";
            this.dgvFerramenta.Size = new System.Drawing.Size(701, 95);
            this.dgvFerramenta.TabIndex = 0;
            this.dgvFerramenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(43, 140);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(238, 140);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(162, 20);
            this.txtFornecedor.TabIndex = 2;
            // 
            // txtSiteOficial
            // 
            this.txtSiteOficial.Location = new System.Drawing.Point(599, 140);
            this.txtSiteOficial.Name = "txtSiteOficial";
            this.txtSiteOficial.Size = new System.Drawing.Size(145, 20);
            this.txtSiteOficial.TabIndex = 3;
            // 
            // txtDistribuicao
            // 
            this.txtDistribuicao.Location = new System.Drawing.Point(427, 140);
            this.txtDistribuicao.Name = "txtDistribuicao";
            this.txtDistribuicao.Size = new System.Drawing.Size(146, 20);
            this.txtDistribuicao.TabIndex = 4;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(43, 209);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(277, 21);
            this.cbxCategoria.TabIndex = 5;
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Location = new System.Drawing.Point(43, 254);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(200, 20);
            this.dtpCadastro.TabIndex = 6;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(168, 349);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(325, 349);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(473, 349);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(625, 349);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtpCadastro);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtDistribuicao);
            this.Controls.Add(this.txtSiteOficial);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvFerramenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFerramenta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtSiteOficial;
        private System.Windows.Forms.TextBox txtDistribuicao;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}

