using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace Portaria
{
    public partial class Tela_Inserir : Form
    {
        SQLiteConnection conexaobd;
        SQLiteCommand comandoSQL;

        int id;
        int COD_FORM;
        string nome;
        string telefone;
        string descricao;
        string situacao;

        int id_comanda;
        int comanda;
        string pagamento;
        private void Tela_Inicial_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_sair, "Voltar a Tela Inicial");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lista();
            Preencher_Comanda();
            txt_pagamento.Items.Clear();
            txt_pagamento.Items.Add("");
            txt_pagamento.Items.Add("CARTÃO");
            txt_pagamento.Items.Add("DINHEIRO");
            txt_pagamento.Items.Add("VIP");

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["PAGAMENTO"].Visible = false;
            dataGridView1.Columns["ID_COMANDA"].Visible = false;
            id = 0;
        }

        public Tela_Inserir()
        {
            InitializeComponent();
            conexaobd = new SQLiteConnection("Data Source=banco\\bd_expediente.db;Version=3;");
            comandoSQL = new SQLiteCommand();
        }

        //listagem
        public void lista()
        {
            try
            {
                string telefoneSemMascara = new string(txt_tel.Text.Where(char.IsDigit).ToArray());
                conexaobd.Open();
                comandoSQL.Connection = conexaobd;

                comandoSQL.CommandText = "SELECT CLT_ID,CLT_NOME,CLT_TELEFONE,(SELECT CMD_NUMERO FROM TAB_COMANDAS WHERE CMD_SAIDA IS NULL AND CMD_CLIENTE = CLT_ID) AS COMANDA, ";
                comandoSQL.CommandText += "(SELECT CMD_PAGAMENTO FROM TAB_COMANDAS WHERE CMD_SAIDA IS NULL AND CMD_CLIENTE = CLT_ID) AS PAGAMENTO, ";
                comandoSQL.CommandText += "(SELECT CMD_ID FROM TAB_COMANDAS WHERE CMD_SAIDA IS NULL AND CMD_CLIENTE = CLT_ID) AS ID_COMANDA, ";
                comandoSQL.CommandText += "CLT_DESCRICAO,CLT_SITUACAO FROM TAB_CLIENTE WHERE ('" + txt_nome.Text + "' = '' OR CLT_NOME LIKE '" + txt_nome.Text + "%') ";
                comandoSQL.CommandText += "AND ('" + telefoneSemMascara + "' = '' OR (REPLACE(REPLACE(REPLACE(CLT_TELEFONE, '(', ''), ') ', ''), '-', '') LIKE '%" + telefoneSemMascara + "%')) ";
                comandoSQL.CommandText += "ORDER BY COMANDA IS NULL, COMANDA, CLT_NOME COLLATE NOCASE";
                using (SQLiteDataReader reader = comandoSQL.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();

                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add("ID", "ID");
                        dataGridView1.Columns.Add("NOME", "NOME");
                        dataGridView1.Columns.Add("TELEFONE", "TELEFONE");
                        dataGridView1.Columns.Add("COMANDA", "COMANDA");
                        dataGridView1.Columns.Add("PAGAMENTO", "PAGAMENTO");
                        dataGridView1.Columns.Add("ID_COMANDA", "ID_COMANDA");
                        dataGridView1.Columns.Add("DESCRICAO", "DESCRICAO");
                        dataGridView1.Columns.Add("SITUACAO", "SITUACAO");

                        dataGridView1.Columns[7].Width = 40;
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        }
                    }

                    while (reader.Read())
                    {
                        object[] row = new object[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = reader[i];
                        }
                        dataGridView1.Rows.Add(row);
                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["SITUACAO"].Value != null)
                        {
                            string situacaoValue = row.Cells["SITUACAO"].Value.ToString();
                            if (situacaoValue == "OK")
                            {
                                row.Cells["SITUACAO"].Style.BackColor = Color.FromArgb(0, 191, 99);
                            }
                            else if (situacaoValue == "NÃO OK")
                            {
                                row.Cells["SITUACAO"].Style.BackColor = Color.FromArgb(255, 49, 49);
                            }
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

        //dois cliques na lista
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                nome = selectedRow.Cells["NOME"].Value != null ? selectedRow.Cells["NOME"].Value.ToString() : string.Empty;
                telefone = selectedRow.Cells["TELEFONE"].Value != null ? selectedRow.Cells["TELEFONE"].Value.ToString() : string.Empty;
                descricao = selectedRow.Cells["DESCRICAO"].Value != null ? selectedRow.Cells["DESCRICAO"].Value.ToString() : string.Empty;
                situacao = selectedRow.Cells["SITUACAO"].Value != null ? selectedRow.Cells["SITUACAO"].Value.ToString() : string.Empty;

                object idComandaValue = selectedRow.Cells["ID_COMANDA"].Value;
                if (idComandaValue != DBNull.Value)
                {
                    id_comanda = Convert.ToInt32(idComandaValue);
                }
                else
                {
                    id_comanda = 0;
                }


                object ComandaValue = selectedRow.Cells["COMANDA"].Value;
                if (ComandaValue != DBNull.Value)
                {
                    comanda = Convert.ToInt32(ComandaValue);
                    txt_comanda.Text = comanda.ToString();
                }
                else
                {
                    comanda = 0;
                    txt_comanda.Text = "";
                }
                pagamento = selectedRow.Cells["PAGAMENTO"].Value != null ? selectedRow.Cells["PAGAMENTO"].Value.ToString() : string.Empty;

                if (id == 0)
                {
                    Limpar();
                }
                else
                {
                    btn_salvar.Text = "EDITAR";

                    txt_nome.Text = nome;
                    txt_tel.Text = telefone;
                    txt_desc.Text = descricao;

                    txt_pagamento.Text = pagamento;
                }
            }
        }

        //Preenche a combo box de comandas
        protected void Preencher_Comanda()
        {
            txt_comanda.Items.Clear();
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

        //Validar Formato do Telefone
        private bool ValidarFormatoTelefone(string telefone)
        {
            string padrao = @"^\(\d{2}\)\s\d{5}-\d{4}$";
            return Regex.IsMatch(telefone, padrao);
        }

        //Salvar
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Preencha o nome.");
                return;
            }
            if (txt_tel.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o telefone.");
                return;
            }
            if (txt_comanda.Text == "" || txt_comanda.Text == "0")
            {
                MessageBox.Show("Preencha a comanda.");
                return;
            }
            if (txt_pagamento.Text == "")
            {
                MessageBox.Show("Preencha o método de pagamento.");
                return;
            }

            string telefone = txt_tel.Text;

            if (!ValidarFormatoTelefone(telefone))
            {
                MessageBox.Show("Formato de telefone inválido. Use o formato (00) 00000-0000.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btn_salvar.Text == "SALVAR")
            {
                //faz o id
                try
                {
                    conexaobd.Open();
                    comandoSQL.Connection = conexaobd;
                    comandoSQL.CommandText = "SELECT CLT_ID FROM TAB_CLIENTE ORDER BY CLT_ID DESC LIMIT 1";

                    using (SQLiteDataReader reader = comandoSQL.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            COD_FORM = Convert.ToInt32(reader["CLT_ID"]) + 1;
                        }
                        else
                        {
                            COD_FORM = 1;
                        }
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

                //verifica comanda
                try
                {
                    string comandaValue = string.IsNullOrWhiteSpace(txt_comanda.Text) ? "NULL" : "'" + txt_comanda.Text + "'";
                    conexaobd.Open();
                    comandoSQL.Connection = conexaobd;
                    comandoSQL.CommandText = "SELECT CMD_NUMERO FROM TAB_COMANDAS WHERE CMD_NUMERO = '" + txt_comanda.Text + "' AND CMD_SAIDA IS NULL";
                    using (SQLiteDataReader reader = comandoSQL.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Já existe uma comanda com este número.");
                            conexaobd.Close();
                            return;
                        }
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

                //insere cliente
                try
                {
                    conexaobd.Open();
                    comandoSQL.Connection = conexaobd;
                    comandoSQL.CommandText = "INSERT INTO TAB_CLIENTE (CLT_ID,CLT_NOME,CLT_TELEFONE,CLT_DESCRICAO,CLT_SITUACAO) VALUES ('" + COD_FORM + "','" + txt_nome.Text + "', '" + txt_tel.Text + "', '" + txt_desc.Text + "','OK')";
                    comandoSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexaobd.Close();
                }
                //insere comanda
                try
                {
                    conexaobd.Open();
                    comandoSQL.Connection = conexaobd;
                    comandoSQL.CommandText = "INSERT INTO TAB_COMANDAS (CMD_CLIENTE, CMD_NUMERO, CMD_PAGAMENTO, CMD_ENTRADA) VALUES ('" + COD_FORM + "', '" + txt_comanda.Text + "', '" + txt_pagamento.Text + "', '" + DateTime.Now + "')";
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Cliente salvo e comanda iniciada com sucesso!");
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
            else
            {
                if (id_comanda == 0)
                {
                    //verifica comanda
                    try
                    {
                        string comandaValue = string.IsNullOrWhiteSpace(txt_comanda.Text) ? "NULL" : "'" + txt_comanda.Text + "'";
                        conexaobd.Open();
                        comandoSQL.Connection = conexaobd;
                        comandoSQL.CommandText = "SELECT CMD_NUMERO FROM TAB_COMANDAS WHERE CMD_NUMERO = '" + txt_comanda.Text + "' AND CMD_CLIENTE != " + id + " AND CMD_SAIDA IS NULL";
                        using (SQLiteDataReader reader = comandoSQL.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Já existe uma comanda com este número.");
                                conexaobd.Close();
                                return;
                            }
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
                    //edita cliente
                    try
                    {
                        conexaobd.Open();
                        comandoSQL.Connection = conexaobd;
                        comandoSQL.CommandText = "UPDATE TAB_CLIENTE SET CLT_NOME = '" + txt_nome.Text + "', CLT_TELEFONE = '" + txt_tel.Text + "', CLT_DESCRICAO = '" + txt_desc.Text + "' WHERE CLT_ID = '" + id + "'";
                        comandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexaobd.Close();
                    }

                    //insere comanda
                    try
                    {
                        conexaobd.Open();
                        comandoSQL.Connection = conexaobd;
                        comandoSQL.CommandText = "INSERT INTO TAB_COMANDAS (CMD_CLIENTE, CMD_NUMERO, CMD_PAGAMENTO, CMD_ENTRADA) VALUES ('" + id + "', '" + txt_comanda.Text + "', '" + txt_pagamento.Text + "', '" + DateTime.Now + "')";
                        comandoSQL.ExecuteNonQuery();
                        MessageBox.Show("Cliente editado e comanda iniciada com sucesso!");
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
                else
                {
                    //verifica comanda
                    try
                    {
                        string comandaValue = string.IsNullOrWhiteSpace(txt_comanda.Text) ? "NULL" : "'" + txt_comanda.Text + "'";
                        conexaobd.Open();
                        comandoSQL.Connection = conexaobd;
                        comandoSQL.CommandText = "SELECT CMD_NUMERO FROM TAB_COMANDAS WHERE CMD_NUMERO = '" + txt_comanda.Text + "' AND CMD_CLIENTE != " + id + " AND CMD_SAIDA IS NULL";
                        using (SQLiteDataReader reader = comandoSQL.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Já existe uma comanda com este número.");
                                conexaobd.Close();
                                return;
                            }
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
                    //edita cliente
                    try
                    {
                        conexaobd.Open();
                        comandoSQL.Connection = conexaobd;
                        comandoSQL.CommandText = "UPDATE TAB_CLIENTE SET CLT_NOME = '" + txt_nome.Text + "', CLT_TELEFONE = '" + txt_tel.Text + "', CLT_DESCRICAO = '" + txt_desc.Text + "' WHERE CLT_ID = '" + id + "'";
                        comandoSQL.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexaobd.Close();
                    }

                    //edita comanda
                    try
                    {
                        conexaobd.Open();
                        comandoSQL.Connection = conexaobd;
                        comandoSQL.CommandText = "UPDATE TAB_COMANDAS SET CMD_NUMERO = '" + txt_comanda.Text + "', CMD_PAGAMENTO = '" + txt_pagamento.Text + "' WHERE CMD_ID = '" + id_comanda + "'";
                        comandoSQL.ExecuteNonQuery();
                        MessageBox.Show("Cliente editado e comanda editada com sucesso!");
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
            }
            Limpar();
            lista();
            Preencher_Comanda();
        }

        //limpar
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        protected void Limpar()
        {
            id = 0;
            nome = null;
            telefone = null;
            descricao = null;
            situacao = null;

            id_comanda = 0;
            comanda = 0;
            COD_FORM = 0;
            pagamento = null;

            btn_salvar.Text = "SALVAR";

            txt_nome.Text = "";
            txt_tel.Text = "";
            txt_desc.Text = "";

            txt_comanda.Text = "";
            txt_pagamento.Text = "";
        }

        //Pesquisar
        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void txt_desc_TextChanged(object sender, EventArgs e)
        {
            lista();
        }

        //KeyPress
        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_salvar_Click(sender, e);
            }
        }

        private void txt_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_salvar_Click(sender, e);
            }
        }

        private void txt_comanda_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_salvar_Click(sender, e);
            }
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_salvar_Click(sender, e);
            }
        }

        private void txt_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipo = Modulo.ObterTipo();
            if (tipo == 2)
            {
                if (txt_pagamento.SelectedItem != null && txt_pagamento.SelectedItem.ToString() == "VIP")
                {
                    txt_pagamento.SelectedIndex = -1;
                }
            }
        }

        private void txt_tel_Click(object sender, EventArgs e)
        {
            if ((txt_tel.Text == "(  )      -"))
            {
                txt_tel.Text = "";
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Inicial().Show();
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
