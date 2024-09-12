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


                txtIdCliente.Text = cliente.Id.ToString();

                txtIDCliente.Text = cliente.Id.ToString();

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnInsereEndereco_Click(object sender, EventArgs e)
        {
            Endereco endereco = new(
                Cliente.ObterPorId(int.Parse(txtIDCliente.Text)),
                txtCep.Text,
                txtLogradouro.Text,
                txtNumero.Text,
                txtComplemento.Text,
                txtBairro.Text,
                txtCidade.Text,
                cmbUf.Text,
                cmbTipoEndereco.Text
                );
            endereco.Inserir();
            if (endereco.Id > 0) MessageBox.Show("Endereço adicionado com sucesso!");
            else MessageBox.Show("Falha ao gravar endereço!");
            txtCep.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtBairro.Clear();

        }

        private void btnEscolherCliente_Click(object sender, EventArgs e)
        {
            txtIDCliente.ReadOnly = false;
        }

        private void btnEscolherCliente_Click_1(object sender, EventArgs e)
        {
            // txtID = int.Parse(txtID.Text);
        }

        private void btnIREndereco_Click(object sender, EventArgs e)
        {
            this.tabpage1.SelectedTab = tabEndereco;

        }
    }
}
