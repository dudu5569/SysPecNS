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
            groupBox1 = new GroupBox();
            btnInserePedido = new Button();
            label4 = new Label();
            txtIdCliente = new TextBox();
            txtCliente = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInserePedido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(34, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 175);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "1";
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(458, 82);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(75, 23);
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
            // groupBox2
            // 
            groupBox2.Location = new Point(34, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(698, 225);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens de Pedido";
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
            txtIdPedido.Size = new Size(168, 25);
            txtIdPedido.TabIndex = 4;
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 521);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtCliente;
        private Label label4;
        private TextBox txtIdCliente;
        private Button btnInserePedido;
    }
}