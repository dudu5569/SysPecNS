using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            var produtos = Categoria.ObterLista();
            cmbCategoria.DataSource = produtos;
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Nome";

            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produto.CodBar;
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[count].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[count].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[count].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[count].Cells[8].Value = produto.DataCad;

                count++;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(txtCodBarras.Text, txtDescricao.Text,
                double.Parse(txtValorUnit.Text), txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (int)npEstoqueMinimo.Value, double.Parse(txtDesconto.Text)
                );

            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto gravado com sucesso com o Id {produto.Id}");
                FrmProdutos_Load(sender, e);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtCodBarras.Clear();
                txtValorUnit.Clear();
                txtUnidadeVenda.Clear();
                txtDescricao.Clear();
                txtDesconto.Clear();
                npEstoqueMinimo.Value = 0;
                btnConsultar.Text = "&Obter por ID";
                txtID.Focus();
                txtID.ReadOnly = false;
            }
            else
            {
                if (txtID.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorId(int.Parse(txtID.Text));
                    txtCodBarras.Text = produto.CodBar;
                    txtValorUnit.Text = Convert.ToString(produto.ValorUnit);
                    txtDescricao.Text = produto.Descricao;
                    txtDesconto.Text = produto.ClasseDesconto.ToString();
                    txtUnidadeVenda.Text = produto.UnidadeVenda;
                    // npEstoqueMinimo.Value = produto.EstoqueMinimo;
                    cmbCategoria.SelectedIndex =
                         cmbCategoria.FindString(produto.Categoria.Nome);
                    btnEditar.Enabled = true;
                    btnConsultar.Text = "&Limpar";

                    btnConsultar.Click += (object sender, EventArgs e) =>
                    {
                        Limpou();
                    };
                    
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                int.Parse(txtID.Text),
                txtCodBarras.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)npEstoqueMinimo.Value,
                double.Parse(txtDesconto.Text),
                null, null
                );

            produto.Atualizar(); //grava as atualizações no banco

            MessageBox.Show($"Produto {produto.Id} - {produto.Descricao} atualizado com sucesso!");
            btnEditar.Enabled = false;
            txtID.ReadOnly = true;
            btnConsultar.Text = "&Consultar";
            LimpaControles();
            FrmProdutos_Load(sender, e);
        }

        private void LimpaControles()
        {
            txtCodBarras.Clear();
            txtValorUnit.Clear();
            txtUnidadeVenda.Clear();
            txtDescricao.Clear();
            txtDesconto.Clear();
            npEstoqueMinimo.Value = 0;
        }

        public void Limpou()
        {
            if (btnConsultar.Text == "&Limpar")
            {
                LimpaControles();
                txtID.Clear();
            }
        }
    }
}
