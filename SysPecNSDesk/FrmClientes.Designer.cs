namespace SysPecNSDesk
{
    partial class FrmClientes
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
            txtID = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            txtCpf = new TextBox();
            txtTelefone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            chkAtivo = new CheckBox();
            btnConfirma = new Button();
            btnEditar = new Button();
            btnArquivar = new Button();
            btnRestaurar = new Button();
            label6 = new Label();
            label7 = new Label();
            dtpNascimento = new DateTimePicker();
            dtpCadastro = new DateTimePicker();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // txtID
            // 
            txtID.Location = new Point(41, 27);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(49, 23);
            txtID.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(148, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(236, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 63);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(41, 81);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(113, 23);
            txtCpf.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(217, 81);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(151, 23);
            txtTelefone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 63);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 122);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 23);
            txtEmail.TabIndex = 9;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(398, 288);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(41, 356);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(75, 23);
            btnConfirma.TabIndex = 11;
            btnConfirma.Text = "&Confirmar";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(168, 356);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnArquivar
            // 
            btnArquivar.Location = new Point(293, 356);
            btnArquivar.Name = "btnArquivar";
            btnArquivar.Size = new Size(75, 23);
            btnArquivar.TabIndex = 13;
            btnArquivar.Text = "&Arquivar";
            btnArquivar.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(398, 356);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(75, 23);
            btnRestaurar.TabIndex = 14;
            btnRestaurar.Text = "&Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 173);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 15;
            label6.Text = "Data de Nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 265);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 16;
            label7.Text = "Data de Cadastro";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(43, 191);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(200, 23);
            dtpNascimento.TabIndex = 17;
            // 
            // dtpCadastro
            // 
            dtpCadastro.Format = DateTimePickerFormat.Short;
            dtpCadastro.Location = new Point(43, 283);
            dtpCadastro.Name = "dtpCadastro";
            dtpCadastro.Size = new Size(200, 23);
            dtpCadastro.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(76, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 518);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(57, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(574, 439);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtID);
            tabPage1.Controls.Add(dtpCadastro);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnArquivar);
            tabPage1.Controls.Add(dtpNascimento);
            tabPage1.Controls.Add(btnRestaurar);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtCpf);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(chkAtivo);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btnConfirma);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(566, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(566, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Enderecos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(554, 150);
            dataGridView1.TabIndex = 0;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 592);
            Controls.Add(groupBox1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtCpf;
        private TextBox txtTelefone;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private CheckBox chkAtivo;
        private Button btnConfirma;
        private Button btnEditar;
        private Button btnArquivar;
        private Button btnRestaurar;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpNascimento;
        private DateTimePicker dtpCadastro;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
    }
}