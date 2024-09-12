using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
                if (usuario.Id > 0 && usuario.Ativo)
                {
                    if (usuario.Ativo)
                    {
                        Program.UsuarioLogado = usuario;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu usuário está inativo. \nProdure a gerência.");
                        Application.Exit();
                    }//fim do if de ativo
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos ou inexistentes \nProcure a gerência.");
                    //Application.Exit();
                    txtEmail.Focus();
                }//fim do if da verificação do id do usuário

            }
            else
            {
                MessageBox.Show("Você deve preencher email e senha");
                txtEmail.Focus();
            }
        }//fim evento click logar

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
