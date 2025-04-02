using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace Portaria
{
    public partial class Tela_Inicial : Form
    {
        private void Tela_Inicial_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_sair, "Sair");
        }

        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
            new Login().Show();
        }

        private void btn_comanda_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Inserir().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Comandas().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Clientes().Show();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            int tipo = Modulo.ObterTipo();
            if (tipo == 2)
            {
                MessageBox.Show("Sem privilégios");
            }
            else
            {
                Close();
                new Tela_Relatorio().Show();
            }
        }
    }
}
