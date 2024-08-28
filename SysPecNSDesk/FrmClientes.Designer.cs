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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 99);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 99);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // txtID
            // 
            txtID.Location = new Point(39, 117);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(49, 23);
            txtID.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(166, 117);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(236, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 158);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(39, 176);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(113, 23);
            txtCpf.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(215, 176);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(151, 23);
            txtTelefone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 158);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 212);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(39, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 23);
            txtEmail.TabIndex = 9;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(396, 234);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(39, 302);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(75, 23);
            btnConfirma.TabIndex = 11;
            btnConfirma.Text = "&Confirmar";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(166, 302);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnArquivar
            // 
            btnArquivar.Location = new Point(291, 302);
            btnArquivar.Name = "btnArquivar";
            btnArquivar.Size = new Size(75, 23);
            btnArquivar.TabIndex = 13;
            btnArquivar.Text = "&Arquivar";
            btnArquivar.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(396, 302);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(75, 23);
            btnRestaurar.TabIndex = 14;
            btnRestaurar.Text = "&Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 120);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 15;
            label6.Text = "Data de Nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(515, 212);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 16;
            label7.Text = "Data de Cadastro";
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(515, 138);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(200, 23);
            dtpNascimento.TabIndex = 17;
            // 
            // dtpCadastro
            // 
            dtpCadastro.Format = DateTimePickerFormat.Short;
            dtpCadastro.Location = new Point(515, 230);
            dtpCadastro.Name = "dtpCadastro";
            dtpCadastro.Size = new Size(200, 23);
            dtpCadastro.TabIndex = 18;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpCadastro);
            Controls.Add(dtpNascimento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnRestaurar);
            Controls.Add(btnArquivar);
            Controls.Add(btnEditar);
            Controls.Add(btnConfirma);
            Controls.Add(chkAtivo);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            ResumeLayout(false);
            PerformLayout();
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
    }
}