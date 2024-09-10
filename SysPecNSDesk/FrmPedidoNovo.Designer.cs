namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grbIdentificacao = new GroupBox();
            btnInserePedido = new Button();
            label4 = new Label();
            txtIdCliente = new TextBox();
            txtCliente = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            grbItens = new GroupBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBarras = new TextBox();
            txtDescricao = new TextBox();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            btnAddItem = new Button();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            txtTotalCompra = new TextBox();
            txtDescontoIten = new TextBox();
            txtDescontoItens = new TextBox();
            btnFechar = new Button();
            txtSubTotal = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(label4);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(txtCliente);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Location = new Point(34, 62);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(698, 175);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(456, 38);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(105, 67);
            btnInserePedido.TabIndex = 3;
            btnInserePedido.Text = "&Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 78);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 2;
            label4.Text = "Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(87, 78);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(85, 27);
            txtIdCliente.TabIndex = 1;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(178, 78);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(251, 27);
            txtCliente.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(87, 34);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(342, 27);
            txtUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 37);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuário";
            // 
            // grbItens
            // 
            grbItens.Controls.Add(textBox1);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBarras);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Enabled = false;
            grbItens.Location = new Point(34, 263);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(698, 313);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            grbItens.Enter += grbItens_Enter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Blue;
            textBox1.Location = new Point(592, 262);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(510, 266);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 12;
            label10.Text = "Total R$";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(474, 19);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 11;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(386, 19);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 10;
            label8.Text = "Quant.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(298, 19);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 9;
            label7.Text = "Valor Unit.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 19);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 8;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 19);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "Cód. Barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(471, 40);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(100, 23);
            txtDescontoItem.TabIndex = 6;
            txtDescontoItem.Text = "0";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(386, 40);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(58, 23);
            txtQuantidade.TabIndex = 5;
            txtQuantidade.Text = "1";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(308, 40);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(51, 23);
            txtValorUnit.TabIndex = 4;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(6, 40);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(121, 23);
            txtCodBarras.TabIndex = 3;
            txtCodBarras.Leave += txtCodBarras_Leave;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(154, 40);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(127, 23);
            txtDescricao.TabIndex = 2;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(6, 69);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(686, 187);
            dgvItensPedido.TabIndex = 1;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 200;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant.";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 80;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 80;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(605, 36);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 14);
            label1.Name = "label1";
            label1.Size = new Size(217, 45);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(779, 62);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 3;
            label2.Text = "Número";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.ForeColor = Color.Black;
            txtIdPedido.Location = new Point(779, 94);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.ReadOnly = true;
            txtIdPedido.Size = new Size(168, 25);
            txtIdPedido.TabIndex = 4;
            // 
            // txtTotalCompra
            // 
            txtTotalCompra.Location = new Point(798, 494);
            txtTotalCompra.Name = "txtTotalCompra";
            txtTotalCompra.ReadOnly = true;
            txtTotalCompra.Size = new Size(100, 23);
            txtTotalCompra.TabIndex = 14;
            // 
            // txtDescontoIten
            // 
            txtDescontoIten.Location = new Point(798, 447);
            txtDescontoIten.Name = "txtDescontoIten";
            txtDescontoIten.Size = new Size(100, 23);
            txtDescontoIten.TabIndex = 15;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(798, 403);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(100, 23);
            txtDescontoItens.TabIndex = 16;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(798, 532);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(100, 23);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "&Finalizar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(798, 350);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(819, 332);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 18;
            label11.Text = "SubTotal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(807, 385);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 18;
            label12.Text = "Desconto Itens ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(819, 429);
            label13.Name = "label13";
            label13.Size = new Size(60, 15);
            label13.TabIndex = 18;
            label13.Text = "Desconto ";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(828, 476);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 18;
            label14.Text = "Total ";
            label14.Click += label13_Click;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 588);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtSubTotal);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtDescontoIten);
            Controls.Add(txtTotalCompra);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Controls.Add(btnFechar);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtCliente;
        private Label label4;
        private TextBox txtIdCliente;
        private Button btnInserePedido;
        private DataGridView dgvItensPedido;
        private Button btnAddItem;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescontoItem;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private TextBox txtCodBarras;
        private TextBox txtDescricao;
        private TextBox textBox1;
        private Label label10;
        private TextBox txtTotalCompra;
        private TextBox txtDescontoIten;
        private TextBox txtDescontoItens;
        private Button btnFechar;
        private TextBox txtSubTotal;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
    }
}