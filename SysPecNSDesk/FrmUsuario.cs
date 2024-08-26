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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            //carregando o combobox de niveis
            var niveis = Nivel.ObterLista();
            cmbNIvel.DataSource = niveis;
            cmbNIvel.DisplayMember = "Nome";
            cmbNIvel.ValueMember = "Id";

            //preenchendo o datagrid com os usuarios
            var lista = Usuario.ObterLista();
            DgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in lista)
            {
                DgvUsuarios.Rows.Add();
                DgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                DgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                DgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;
                DgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;
                DgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;

                cont++;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new();

        }
    }
}
