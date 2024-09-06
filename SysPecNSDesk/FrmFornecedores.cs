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
    public partial class FrmFornecedores : Form
    {
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                txtRazaoSocial.Text,
                txtFantasia.Text,
                txtCnpj.Text,
                txtContato.Text,
                txtTelefone.Text,
                txtEmail.Text
                );

            fornecedor.Inserir();
            if (fornecedor.Id > 0)
            {
                txtId.Text = fornecedor.Id.ToString();
                MessageBox.Show($"O fornecedor com o id `{fornecedor.Id}, foi inserido com sucesso!");
                txtCnpj.Clear();
                txtContato.Clear();
                txtEmail.Clear();
                txtFantasia.Clear();
                txtRazaoSocial.Clear();
                txtTelefone.Clear();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                int.Parse(txtId.Text),
                txtRazaoSocial.Text,
                txtFantasia.Text,
                txtCnpj.Text,
                txtContato.Text,
                txtTelefone.Text,
                txtEmail.Text
                );
            fornecedor.Atualizar();
            MessageBox.Show($"Fornecedor com o id {fornecedor.Id}, foi alterado com sucesso!");
            btnEditar.Enabled = false;
            btnConsulta.Text = "&Consulta";
            LimpaControles();
        }


        private void LimpaControles()
        {
            txtRazaoSocial.Clear();
            txtFantasia.Clear();
            txtCnpj.Clear();
            txtContato.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (btnConsulta.Text == "&Consulta")
            {
                txtRazaoSocial.Clear();
                txtFantasia.Clear();
                txtCnpj.Clear();
                txtContato.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsulta.Text = "&Obter por ID";
            }
        }

        private void dgvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int posicaolinha = dgvFornecedores.CurrentRow.Index;
            id = Convert.ToInt32(dgvFornecedores.Rows[posicaolinha].Cells[0].Value);
            MessageBox.Show(id.ToString());
        }
    }
}
