namespace ControleEstoque1
{
    partial class frmProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCategoriaProduto = new System.Windows.Forms.TextBox();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.ViewProduto = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNovo
            // 
            this.bntNovo.FlatAppearance.BorderSize = 0;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(86, 132);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(176, 20);
            this.txtIDProduto.TabIndex = 7;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(86, 158);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(176, 20);
            this.txtNomeProduto.TabIndex = 8;
            // 
            // txtCategoriaProduto
            // 
            this.txtCategoriaProduto.Location = new System.Drawing.Point(86, 184);
            this.txtCategoriaProduto.Name = "txtCategoriaProduto";
            this.txtCategoriaProduto.Size = new System.Drawing.Size(176, 20);
            this.txtCategoriaProduto.TabIndex = 9;
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(86, 210);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(176, 20);
            this.txtValorProduto.TabIndex = 10;
            // 
            // ViewProduto
            // 
            this.ViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewProduto.Location = new System.Drawing.Point(16, 251);
            this.ViewProduto.Name = "ViewProduto";
            this.ViewProduto.Size = new System.Drawing.Size(772, 150);
            this.ViewProduto.TabIndex = 11;
            this.ViewProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewProduto_CellDoubleClick);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewProduto);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.txtCategoriaProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProduto";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtIDProduto, 0);
            this.Controls.SetChildIndex(this.txtNomeProduto, 0);
            this.Controls.SetChildIndex(this.txtCategoriaProduto, 0);
            this.Controls.SetChildIndex(this.txtValorProduto, 0);
            this.Controls.SetChildIndex(this.ViewProduto, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCategoriaProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.DataGridView ViewProduto;
    }
}
