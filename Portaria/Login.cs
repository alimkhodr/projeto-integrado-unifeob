using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Portaria
{
    public partial class Login : Form
    {
        private int id;

        private void Comanda_Load(object sender, EventArgs e)
        {
            id = 1;

            txt_tipo.Items.Clear();
            txt_tipo.Items.Add("");
            txt_tipo.Items.Add("USUÁRIO");
            txt_tipo.Items.Add("ADMINISTRADOR");
        }

        public Login()
        {
            InitializeComponent();
        }


        public void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_tipo.Text == "")
            {
                MessageBox.Show("Selecione o tipo.");
                return;
            }
            else if (txt_tipo.Text == "USUÁRIO")
            {
                if (txt_senha.Text == "1331")
                {
                    Modulo.tipo = 2;
                    new Tela_Inicial().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha inválida.");
                    return;
                }
            }
            else if (txt_tipo.Text == "ADMINISTRADOR")
            {
                if (txt_senha.Text == "ExpBar10" || txt_senha.Text == "9")
                {
                    Modulo.tipo = 1;
                    new Tela_Inicial().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha inválida.");
                    return;
                }
            }
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_salvar_Click(sender, e);
            }
        }
    }
}