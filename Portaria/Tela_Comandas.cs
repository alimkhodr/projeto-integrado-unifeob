using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;

namespace Portaria
{
    public partial class Tela_Comandas : Form
    {
        SQLiteConnection conexaobd;
        SQLiteCommand comandoSQL;
        private int id;
        private void Tela_Inicial_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_sair, "Voltar a Tela Inicial");

            txt_pagamento.Items.Clear();
            txt_pagamento.Items.Add("");
            txt_pagamento.Items.Add("CARTÃO");
            txt_pagamento.Items.Add("DINHEIRO");
            txt_pagamento.Items.Add("VIP");

            Preencher_Comanda();

            lista();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["PAGAMENTO"].Visible = false;
        }

        public Tela_Comandas()
        {
            InitializeComponent();
            conexaobd = new SQLiteConnection("Data Source=banco\\bd_expediente.db;Version=3;");
            comandoSQL = new SQLiteCommand();
        }

        //listagem
        protected void lista()
        {
            try
            {
                string telefoneSemMascara = new string(txt_tel.Text.Where(char.IsDigit).ToArray());
                conexaobd.Open();
                comandoSQL.Connection = conexaobd;

                comandoSQL.CommandText = "SELECT CMD_ID,CLT_NOME,CLT_TELEFONE,CMD_NUMERO,strftime(CMD_ENTRADA),CMD_PAGAMENTO FROM TAB_CLIENTE LEFT JOIN TAB_COMANDAS ON CLT_ID = CMD_CLIENTE WHERE CMD_ENTRADA IS NOT NULL AND CMD_SAIDA IS NULL AND ('" + txt_nome.Text + "' = '' OR CLT_NOME LIKE '" + txt_nome.Text + "%') ";
                comandoSQL.CommandText += "AND ('" + txt_comanda.Text + "' = '' OR CMD_NUMERO LIKE '" + txt_comanda.Text + "%') AND ('" + txt_pagamento.Text + "' = '' OR CMD_PAGAMENTO LIKE '" + txt_pagamento.Text + "%')";
                comandoSQL.CommandText += "AND ('" + telefoneSemMascara + "' = '' OR (REPLACE(REPLACE(REPLACE(CLT_TELEFONE, '(', ''), ') ', ''), '-', '') LIKE '%" + telefoneSemMascara + "%')) ";
                comandoSQL.CommandText += "ORDER BY CMD_NUMERO IS NULL, CMD_NUMERO, CLT_NOME COLLATE NOCASE";
                using (SQLiteDataReader reader = comandoSQL.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();

                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add("ID", "ID");
                        dataGridView1.Columns.Add("NOME", "NOME");
                        dataGridView1.Columns.Add("TELEFONE", "TELEFONE");
                        dataGridView1.Columns.Add("COMANDA", "COMANDA");
                        dataGridView1.Columns.Add("ENTRADA", "ENTRADA");
                        dataGridView1.Columns.Add("PAGAMENTO", "PAGAMENTO");

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    while (reader.Read())
                    {
                        object[] row = new object[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader[i];
                        }
                        dataGridView1.Rows.Add(row);
                    }
                    txt_qtd.Text = "Quantidade: " + dataGridView1.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaobd.Close();
            }
        }

        //Preencher as Comanda disponiveis
        protected void Preencher_Comanda()
        {
            try
            {
                conexaobd.Open();
                comandoSQL.Connection = conexaobd;
                comandoSQL.CommandText = "SELECT CMD_NUMERO FROM TAB_COMANDAS WHERE CMD_ENTRADA IS NOT NULL AND CMD_SAIDA IS NULL";
                using (SQLiteDataReader reader = comandoSQL.ExecuteReader())
                {
                    List<int> numerosExistentes = new List<int>();
                    while (reader.Read())
                    {
                        if (reader["CMD_NUMERO"] != DBNull.Value)
                        {
                            numerosExistentes.Add(Convert.ToInt32(reader["CMD_NUMERO"]));
                        }
                    }
                    for (int i = 1; i <= 400; i++)
                    {
                        if (!numerosExistentes.Contains(i))
                        {
                            txt_comanda.Items.Add(i.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexaobd.Close();
            }
        }

        //limpar
        protected void Limpar()
        {
            id = 0;
            txt_nome.Text = "";
            txt_tel.Text = "";
            txt_comanda.Text = "";
            txt_pagamento.Text = "";
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        //Finalizar
        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;

            if (count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma comanda.");
                return;
            }

            DialogResult result = MessageBox.Show($"Deseja finalizar {count} comanda(s) selecionada(s)?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conexaobd.Open();
                    comandoSQL.Connection = conexaobd;

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int cmdId = Convert.ToInt32(row.Cells["ID"].Value);
                        comandoSQL.CommandText = "UPDATE TAB_COMANDAS SET CMD_SAIDA = '" + DateTime.Now + "' WHERE CMD_ID = '" + cmdId + "'";
                        comandoSQL.ExecuteNonQuery();
                    }
                    MessageBox.Show("Comanda(s) finalizada(s) com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexaobd.Close();
                }
                Limpar();
                lista();
            }
        }

        //Pesquisa
        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void txt_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista();
        }
        private void txt_comanda_TextChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;

            if (count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma comanda.");
                return;
            }

            DialogResult result = MessageBox.Show($"Deseja excluir {count} comanda(s) selecionada(s)?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conexaobd.Open();
                    comandoSQL.Connection = conexaobd;

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int cmdId = Convert.ToInt32(row.Cells["ID"].Value);
                        comandoSQL.CommandText = "DELETE FROM TAB_COMANDAS WHERE CMD_ID = '" + cmdId + "'";
                        comandoSQL.ExecuteNonQuery();
                    }
                    MessageBox.Show("Comanda(s) excluída(s) com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexaobd.Close();
                }
                Limpar();
                lista();
            }
        }

        private void txt_tel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tel.Text))
            {
                txt_tel.Text = "";
            }
        }

        //menu
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Inicial().Show();
        }

        private void btn_comanda_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Inserir().Show();
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
