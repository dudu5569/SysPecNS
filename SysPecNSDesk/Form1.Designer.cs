namespace SysPecNSDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnConfirma = new Button();
            TxtNumero1 = new TextBox();
            lstResultado = new ListBox();
            cmbOperacao = new ComboBox();
            TxtNumero2 = new TextBox();
            Operação = new Label();
            numero1 = new Label();
            numero2 = new Label();
            SuspendLayout();
            // 
            // BtnConfirma
            // 
            BtnConfirma.BackColor = SystemColors.ButtonFace;
            BtnConfirma.Enabled = false;
            BtnConfirma.Location = new Point(411, 61);
            BtnConfirma.Name = "BtnConfirma";
            BtnConfirma.Size = new Size(100, 23);
            BtnConfirma.TabIndex = 0;
            BtnConfirma.Text = "&Confirma";
            BtnConfirma.UseVisualStyleBackColor = false;
            BtnConfirma.Click += btnConfirma_Click;
            // 
            // TxtNumero1
            // 
            TxtNumero1.BackColor = SystemColors.Menu;
            TxtNumero1.Location = new Point(199, 61);
            TxtNumero1.Name = "TxtNumero1";
            TxtNumero1.Size = new Size(100, 23);
            TxtNumero1.TabIndex = 1;
            TxtNumero1.TextChanged += textBox1_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(72, 103);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(181, 244);
            lstResultado.TabIndex = 2;
            // 
            // cmbOperacao
            // 
            cmbOperacao.BackColor = SystemColors.Menu;
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiciação", "Logaritimos" });
            cmbOperacao.Location = new Point(72, 61);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(121, 23);
            cmbOperacao.TabIndex = 3;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // TxtNumero2
            // 
            TxtNumero2.Location = new Point(305, 61);
            TxtNumero2.Name = "TxtNumero2";
            TxtNumero2.Size = new Size(100, 23);
            TxtNumero2.TabIndex = 4;
            TxtNumero2.TextChanged += TxtNumero2_TextChanged;
            // 
            // Operação
            // 
            Operação.AutoSize = true;
            Operação.BackColor = SystemColors.ActiveCaptionText;
            Operação.ForeColor = SystemColors.ButtonHighlight;
            Operação.Location = new Point(72, 34);
            Operação.Name = "Operação";
            Operação.Size = new Size(58, 15);
            Operação.TabIndex = 5;
            Operação.Text = "Operação";
            // 
            // numero1
            // 
            numero1.AutoSize = true;
            numero1.ForeColor = SystemColors.ButtonHighlight;
            numero1.Location = new Point(199, 34);
            numero1.Name = "numero1";
            numero1.Size = new Size(65, 15);
            numero1.TabIndex = 6;
            numero1.Text = "1º Número";
            // 
            // numero2
            // 
            numero2.AutoSize = true;
            numero2.ForeColor = SystemColors.ButtonHighlight;
            numero2.Location = new Point(305, 34);
            numero2.Name = "numero2";
            numero2.Size = new Size(65, 15);
            numero2.TabIndex = 7;
            numero2.Text = "2º Número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(943, 516);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Controls.Add(Operação);
            Controls.Add(TxtNumero2);
            Controls.Add(cmbOperacao);
            Controls.Add(lstResultado);
            Controls.Add(TxtNumero1);
            Controls.Add(BtnConfirma);
            ForeColor = SystemColors.ActiveCaptionText;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "Calculadora atualizada 2024";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConfirma;
        private TextBox TxtNumero1;
        private ListBox lstResultado;
        private ComboBox cmbOperacao;
        private TextBox TxtNumero2;
        private Label Operação;
        private Label numero1;
        private Label numero2;
    }
}
