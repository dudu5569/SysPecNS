namespace SysPecNSDesk
{
    partial class FrmFornecedores
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtId = new TextBox();
            btnConsulta = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtContato = new TextBox();
            txtCnpj = new TextBox();
            txtFantasia = new TextBox();
            txtRazaoSocial = new TextBox();
            tabPage2 = new TabPage();
            dgvFornecedores = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnRazao = new DataGridViewTextBoxColumn();
            clnFantasia = new DataGridViewTextBoxColumn();
            clnCnpj = new DataGridViewTextBoxColumn();
            clnContato = new DataGridViewTextBoxColumn();
            clntelefone = new DataGridViewTextBoxColumn();
            spemail = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(448, 48);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 0;
            label1.Text = "Fornecedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 32);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 88);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Razão social";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 158);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Nome Fantasia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 225);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 4;
            label5.Text = "CNPJ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(247, 225);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "Contato";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 88);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(387, 158);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(85, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(948, 442);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inserir Fornecedores";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(16, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(926, 414);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtId);
            tabPage1.Controls.Add(btnConsulta);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtContato);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtCnpj);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtFantasia);
            tabPage1.Controls.Add(txtRazaoSocial);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(918, 386);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inserir";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(48, 50);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(62, 23);
            txtId.TabIndex = 8;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(307, 317);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(75, 23);
            btnConsulta.TabIndex = 15;
            btnConsulta.Text = "&Consulta";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(183, 317);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(59, 317);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(387, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(387, 115);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(171, 23);
            txtTelefone.TabIndex = 12;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(247, 243);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(100, 23);
            txtContato.TabIndex = 12;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(48, 243);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(141, 23);
            txtCnpj.TabIndex = 11;
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(48, 176);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(280, 23);
            txtFantasia.TabIndex = 10;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(48, 115);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(280, 23);
            txtRazaoSocial.TabIndex = 9;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvFornecedores);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(918, 386);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.AllowUserToAddRows = false;
            dgvFornecedores.AllowUserToDeleteRows = false;
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Columns.AddRange(new DataGridViewColumn[] { clnId, clnRazao, clnFantasia, clnCnpj, clnContato, clntelefone, spemail });
            dgvFornecedores.Location = new Point(24, 26);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.ReadOnly = true;
            dgvFornecedores.RowHeadersVisible = false;
            dgvFornecedores.Size = new Size(888, 354);
            dgvFornecedores.TabIndex = 0;
            dgvFornecedores.CellContentClick += dgvFornecedores_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 80;
            // 
            // clnRazao
            // 
            clnRazao.Frozen = true;
            clnRazao.HeaderText = "Razão Social";
            clnRazao.Name = "clnRazao";
            clnRazao.ReadOnly = true;
            clnRazao.Width = 150;
            // 
            // clnFantasia
            // 
            clnFantasia.Frozen = true;
            clnFantasia.HeaderText = "Nome Fantasia";
            clnFantasia.Name = "clnFantasia";
            clnFantasia.ReadOnly = true;
            clnFantasia.Width = 150;
            // 
            // clnCnpj
            // 
            clnCnpj.Frozen = true;
            clnCnpj.HeaderText = "CNPJ";
            clnCnpj.Name = "clnCnpj";
            clnCnpj.ReadOnly = true;
            clnCnpj.Width = 120;
            // 
            // clnContato
            // 
            clnContato.Frozen = true;
            clnContato.HeaderText = "Contato";
            clnContato.Name = "clnContato";
            clnContato.ReadOnly = true;
            clnContato.Width = 120;
            // 
            // clntelefone
            // 
            clntelefone.Frozen = true;
            clntelefone.HeaderText = "Telefone";
            clntelefone.Name = "clntelefone";
            clntelefone.ReadOnly = true;
            clntelefone.Width = 120;
            // 
            // spemail
            // 
            spemail.Frozen = true;
            spemail.HeaderText = "Email";
            spemail.Name = "spemail";
            spemail.ReadOnly = true;
            spemail.Width = 150;
            // 
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 547);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmFornecedores";
            Text = "Inserir Novo Fornecedor";
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtContato;
        private TextBox txtCnpj;
        private TextBox txtFantasia;
        private TextBox txtRazaoSocial;
        private TextBox txtId;
        private Button btnConsulta;
        private Button btnEditar;
        private Button btnInserir;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvFornecedores;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnRazao;
        private DataGridViewTextBoxColumn clnFantasia;
        private DataGridViewTextBoxColumn clnCnpj;
        private DataGridViewTextBoxColumn clnContato;
        private DataGridViewTextBoxColumn clntelefone;
        private DataGridViewTextBoxColumn spemail;
    }
}