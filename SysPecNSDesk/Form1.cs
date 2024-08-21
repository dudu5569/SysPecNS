using SysPecNSLib;
namespace SysPecNSDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TxtNumero1.Text.Length > 0 && cmbOperacao.SelectedIndex > 4)
            {
                BtnConfirma.Enabled = true;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            //Existem 3 tipos de onversões e, c#
            //CAST
            //PARSE
            //CONVERT
            //for(int i = 0 ; i < 10 ; i++)
            //{
            //    lstResultado.Items.Add($"{numero} x {i+1} = {numero * (i + 1)}"); //fazer tabuada do 1 ate 10
            //}

            string operacao = cmbOperacao.Text;
            int posicaoOperacao = cmbOperacao.SelectedIndex;
            double numero1 = 0;
            if (TxtNumero1.Text != string.Empty)
            {
                numero1 = Convert.ToDouble(TxtNumero1.Text);
            }


            double numero2 = 0;
            if (posicaoOperacao < 5)
            {
                if (TxtNumero2.Text != string.Empty)
                {
                    numero2 = Convert.ToDouble(TxtNumero2.Text);
                }

            }
            double resultado = 0;
            switch (posicaoOperacao)
            {
                case 0:
                    resultado = numero1 * numero2;
                    break;

                case 1:
                    resultado = numero1 / numero2;
                    break;

                case 2:
                    resultado = numero1 + numero2;
                    break;

                case 3:
                    resultado = numero1 - numero2;
                    break;

                case 4:
                    resultado = Math.Pow(numero1, numero2);
                    break;

                case 5:
                    resultado = Math.Sqrt(numero1);
                    break;

                case 6:
                    resultado = Math.Log(numero1);
                    break;
                default:
                    break;
            }
            lstResultado.Items.Add($"{operacao} - {posicaoOperacao} = {resultado} ");
            TxtNumero1.Clear();
            TxtNumero2.Clear();
            cmbOperacao.Focus();

        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperacao.SelectedIndex > 4)
            {
                TxtNumero2.Enabled = false;
            }
            else
            {
                TxtNumero2.Enabled = true;
            }
            TxtNumero1.Clear();
            TxtNumero2.Clear();
            TxtNumero1.Focus();
            BtnConfirma.Enabled = false;
        }

        private void TxtNumero2_TextChanged(object sender, EventArgs e)
        {
            if (TxtNumero2.Text.Length > 0)
            {
                BtnConfirma.Enabled = true;
            }
            else
            {
                BtnConfirma.Enabled = false;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(textBox1.Text, textBox2.Text);
            nivel.Inserir();
            MessageBox.Show("Nível gravado com succeso");
            button1.Enabled = false;

        }
    }
}
