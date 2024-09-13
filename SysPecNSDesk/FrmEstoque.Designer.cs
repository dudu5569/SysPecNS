namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            label1 = new Label();
            dgvEstoque = new DataGridView();
            clnIdProduto = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnMovimento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 58);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Controle de Estoque";
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { clnIdProduto, clnQuantidade, clnMovimento });
            dgvEstoque.Location = new Point(79, 149);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(603, 251);
            dgvEstoque.TabIndex = 1;
            dgvEstoque.CellContentClick += dgvEstoque_CellContentClick;
            // 
            // clnIdProduto
            // 
            clnIdProduto.Frozen = true;
            clnIdProduto.HeaderText = "Produto";
            clnIdProduto.Name = "clnIdProduto";
            clnIdProduto.ReadOnly = true;
            clnIdProduto.Width = 200;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade de Saída";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 200;
            // 
            // clnMovimento
            // 
            clnMovimento.Frozen = true;
            clnMovimento.HeaderText = "Data Último Movimento";
            clnMovimento.MinimumWidth = 50;
            clnMovimento.Name = "clnMovimento";
            clnMovimento.ReadOnly = true;
            clnMovimento.Width = 200;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEstoque);
            Controls.Add(label1);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn clnIdProduto;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnMovimento;
    }
}