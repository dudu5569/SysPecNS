namespace SysPecNSDesk
{
    partial class FrmProdutos
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
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            txtDesconto = new TextBox();
            npEstoqueMinimo = new NumericUpDown();
            cmbCategoria = new ComboBox();
            txtDescricao = new TextBox();
            txtUnidadeVenda = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBarras = new TextBox();
            txtID = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodBarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnUnidVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(npEstoqueMinimo);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtUnidadeVenda);
            groupBox1.Controls.Add(txtValorUnit);
            groupBox1.Controls.Add(txtCodBarras);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(83, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(441, 273);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 20;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(327, 273);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(206, 273);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 18;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(37, 273);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 17;
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(525, 124);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(47, 23);
            npEstoqueMinimo.TabIndex = 16;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(203, 208);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(262, 23);
            cmbCategoria.TabIndex = 15;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(37, 208);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 13;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(363, 123);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(100, 23);
            txtUnidadeVenda.TabIndex = 11;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(203, 123);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 10;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(37, 123);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(100, 23);
            txtCodBarras.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(37, 67);
            txtID.Name = "txtID";
            txtID.Size = new Size(65, 23);
            txtID.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(203, 190);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 7;
            label9.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 190);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 6;
            label8.Text = "Descrição";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(203, 105);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 5;
            label7.Text = "Valor Unitário";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 105);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 4;
            label6.Text = "Estoque Mínimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 255);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 3;
            label5.Text = "Desconto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 105);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 2;
            label4.Text = "Unidade de Venda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 105);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 1;
            label3.Text = "Código de Barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 49);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 21);
            label1.Name = "label1";
            label1.Size = new Size(216, 46);
            label1.TabIndex = 1;
            label1.Text = "Produtos";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodBarras, clnDescricao, clnValorUnit, clnUnidVenda, clnCategoria, clnEstoqMinimo, clnDesconto, clnDataCad });
            dgvProdutos.Location = new Point(83, 416);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.ScrollBars = ScrollBars.Vertical;
            dgvProdutos.Size = new Size(711, 150);
            dgvProdutos.TabIndex = 2;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 80;
            // 
            // clnCodBarras
            // 
            clnCodBarras.Frozen = true;
            clnCodBarras.HeaderText = "Códigos de Barras";
            clnCodBarras.Name = "clnCodBarras";
            clnCodBarras.ReadOnly = true;
            clnCodBarras.Width = 150;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unitário";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 150;
            // 
            // clnUnidVenda
            // 
            clnUnidVenda.Frozen = true;
            clnUnidVenda.HeaderText = "Unidade de Venda";
            clnUnidVenda.Name = "clnUnidVenda";
            clnUnidVenda.ReadOnly = true;
            clnUnidVenda.Width = 150;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoqMinimo
            // 
            clnEstoqMinimo.Frozen = true;
            clnEstoqMinimo.HeaderText = "Estoque Mínimo";
            clnEstoqMinimo.Name = "clnEstoqMinimo";
            clnEstoqMinimo.ReadOnly = true;
            clnEstoqMinimo.Width = 150;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnDataCad
            // 
            clnDataCad.Frozen = true;
            clnDataCad.HeaderText = "Data Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 578);
            Controls.Add(dgvProdutos);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            Load += FrmProdutos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown npEstoqueMinimo;
        private ComboBox cmbCategoria;
        private TextBox txtDescricao;
        private TextBox txtUnidadeVenda;
        private TextBox txtValorUnit;
        private TextBox txtCodBarras;
        private TextBox txtID;
        private TextBox txtDesconto;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodBarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnUnidVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataCad;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
    }
}