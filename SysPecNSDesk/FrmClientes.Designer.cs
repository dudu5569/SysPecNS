﻿namespace SysPecNSDesk
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
            textBox1 = new TextBox();
            txtBairro = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtLogradouro = new TextBox();
            txtCep = new TextBox();
            button2 = new Button();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label16 = new Label();
            comboBox1 = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            chkAtivo.Location = new Point(276, 288);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(41, 334);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(75, 23);
            btnConfirma.TabIndex = 11;
            btnConfirma.Text = "&Confirmar";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(160, 334);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnArquivar
            // 
            btnArquivar.Location = new Point(279, 334);
            btnArquivar.Name = "btnArquivar";
            btnArquivar.Size = new Size(75, 23);
            btnArquivar.TabIndex = 13;
            btnArquivar.Text = "&Arquivar";
            btnArquivar.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(398, 334);
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
            dtpCadastro.Location = new Point(41, 283);
            dtpCadastro.Name = "dtpCadastro";
            dtpCadastro.Size = new Size(200, 23);
            dtpCadastro.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(76, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 518);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(19, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(935, 475);
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
            tabPage1.Size = new Size(927, 447);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(txtComplemento);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Controls.Add(txtLogradouro);
            tabPage2.Controls.Add(txtCep);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(927, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Enderecos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 23);
            textBox1.TabIndex = 26;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(463, 197);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(249, 23);
            txtBairro.TabIndex = 25;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(612, 143);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 24;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(463, 143);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 23;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(73, 143);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(358, 23);
            txtLogradouro.TabIndex = 22;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(72, 82);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 21;
            // 
            // button2
            // 
            button2.Location = new Point(206, 308);
            button2.Name = "button2";
            button2.Size = new Size(101, 31);
            button2.TabIndex = 20;
            button2.Text = "&Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(71, 308);
            button1.Name = "button1";
            button1.Size = new Size(101, 31);
            button1.TabIndex = 19;
            button1.Text = "&Inserir";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Residencial", "Corporativo" });
            comboBox2.Location = new Point(207, 258);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(207, 240);
            label16.Name = "label16";
            label16.Size = new Size(98, 15);
            label16.TabIndex = 10;
            label16.Text = "Tipo de Endereço";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            comboBox1.Location = new Point(71, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(71, 240);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 8;
            label15.Text = "UF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(73, 179);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 7;
            label14.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(463, 179);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 6;
            label13.Text = "Bairro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(72, 64);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 5;
            label12.Text = "CEP";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(612, 125);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 4;
            label11.Text = "Complemento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(463, 125);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 3;
            label10.Text = "Número";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 125);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 2;
            label9.Text = "Loogradouro";
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
            tabPage2.PerformLayout();
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
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox comboBox1;
        private Label label15;
        private Label label16;
        private Button button2;
        private Button button1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private TextBox txtCep;
        private TextBox txtLogradouro;
        private TextBox txtBairro;
        private TextBox txtComplemento;
        private TextBox txtNumero;
    }
}