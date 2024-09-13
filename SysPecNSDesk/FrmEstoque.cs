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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
            CarregaGrid();
        }

        private void CarregaGrid(string nome = "")
        {
            //carregando o datagrid com o estoque
            var lista = Estoque.ObterLista();
            dgvEstoque.Rows.Clear();
            int cont = 0;
            foreach (var produtos in lista)
            {
                dgvEstoque.Rows.Add();
                dgvEstoque.Rows[cont].Cells[0].Value = produtos.produtoId.Descricao;
                dgvEstoque.Rows[cont].Cells[1].Value = produtos.Quantidade;
                dgvEstoque.Rows[cont].Cells[2].Value = produtos.Data_Ultimo_Movimento;

                cont++;
            }

        }



        private void FrmEstoque_Load(object sender, EventArgs e)
        {
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostra a quantidade que saiu no último movimento
            int quantidade = 0;
            int posicaolinha = dgvEstoque.CurrentRow.Index;
            quantidade = Convert.ToInt32(dgvEstoque.Rows[posicaolinha].Cells[1].Value);
            MessageBox.Show((quantidade.ToString()),"Saíram no ultimo movimento:");
        }
    }
}
