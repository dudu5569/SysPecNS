﻿using SysPecNSLib;
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
    public partial class FrmPedidoNovo : Form
    {

        Produto produto;


        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;
        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                 Program.UsuarioLogado,
                 Cliente.ObterPorId(int.Parse(txtIdCliente.Text)),
                 0
                 );
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grbItens.Enabled = true;
            grbIdentificacao.Enabled = false;
            txtCodBarras.Focus();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void grbItens_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodBarras_Leave(object sender, EventArgs e)
        {
            if (txtCodBarras.TextLength > 0)
            {
                produto = Produto.ObterPorId(txtCodBarras.Text);
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString();
                txtValorUnit.ReadOnly = true;
                txtQuantidade.Focus();
                if (produto.ClasseDesconto == 0)
                {
                    txtDescontoItem.Enabled = false;
                }
                else
                {
                    txtDescontoItem.Enabled = true;
                    label4.Text += $"{produto.ValorUnit * produto.ClasseDesconto}";
                }
                txtValorUnit.ReadOnly = true;
                txtQuantidade.Focus();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );
            item.Insert();

            produto = new();
            txtDescontoItem.Text = "0";
            txtDescricao.Clear();
            txtValorUnit.Text = "0";
            txtQuantidade.Text = "1";
            txtCodBarras.Clear();
            txtCodBarras.Focus();

            PreencherGridItens();
        }

        private void PreencherGridItens()
        {
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
            dgvItensPedido.Rows.Clear();
            int linha = 0;
            double total = 0;
            double desconto = 0;
            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = linha + 1;
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit.ToString("#0.00");
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade;
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto;
                dgvItensPedido.Rows[linha].Cells[6].Value = (item.ValorUnit * item.Quantidade - item.Desconto).ToString("#0.00");
                linha++;

                total += item.ValorUnit * item.Quantidade - item.Desconto;
                desconto += item.Desconto;


            }

            textBox1.Text = total.ToString("#0.00");
            txtDescontoItens.Text = desconto.ToString("#0.00");


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            string estoque = "";
            int estoque_restante = 0;
            

                estoque = (item.Produto.EstoqueMinimo.ToString());

                estoque_restante = int.Parse(estoque) - Convert.ToInt32(item.Quantidade);
                if (estoque_restante <= 0)
                {
                    MessageBox.Show("Quantidade indisponível no estoque");
                }
                else
                {
                    Produto.Desconto_estoque(estoque_restante, int.Parse(item.Produto.CodBar));
                }

        }
    }
}
