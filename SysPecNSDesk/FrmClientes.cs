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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtCpf.Text,
                txtTelefone.Text,
                txtEmail.Text,
                dtpNascimento.Value,
                dtpCadastro.Value = DateTime.Now
                ); 
            cliente.Adicionar_Cliente();
            if (cliente.Id > 0)
            {
                txtID.Text = cliente.Id.ToString();
                MessageBox.Show($"O cliente {cliente.Nome}, foi inserido com sucesso " +
                    $"com o Id {cliente.Id}");
                txtID.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
                txtTelefone.Clear();
                dtpNascimento.
            }
        }
    }
}
