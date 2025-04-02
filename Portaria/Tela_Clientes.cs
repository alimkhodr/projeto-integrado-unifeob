using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace Portaria
{
    public partial class Tela_Clientes : Form
    {
        SQLiteConnection conexaobd;
        SQLiteCommand comandoSQL;
        private int id;
        int COD_FORM;
        string nome;
        string telefone;
        string descricao;
        string situacao;
        private void Tela_Inicial_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_sair, "Voltar a Tela Inicial");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lista();
            dataGridView1.Columns["ID"].Visible = false;
        }

        public Tela_Clientes()
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

                comandoSQL.CommandText = "SELECT CLT_ID, CLT_NOME,CLT_TELEFONE, CLT_DESCRICAO, (SELECT COUNT(*) FROM TAB_COMANDAS WHERE CMD_CLIENTE = CLT_ID) AS QUANTIDADE, CLT_SITUACAO FROM TAB_CLIENTE WHERE ('" + txt_nome.Text + "' = '' OR CLT_NOME LIKE '" + txt_nome.Text + "%') ";
                comandoSQL.CommandText += "AND ('" + telefoneSemMascara + "' = '' OR (REPLACE(REPLACE(REPLACE(CLT_TELEFONE, '(', ''), ') ', ''), '-', '') LIKE '%" + telefoneSemMascara + "%')) ";
                comandoSQL.CommandText += "ORDER BY CLT_NOME COLLATE NOCASE";
                using (SQLiteDataReader reader = comandoSQL.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();

                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add("ID", "ID");
                        dataGridView1.Columns.Add("NOME", "NOME");
                        dataGridView1.Columns.Add("TELEFONE", "TELEFONE");
                        dataGridView1.Columns.Add("DESCRICAO", "DESCRICAO");
                        dataGridView1.Columns.Add("FREQUENCIA", "FREQUENCIA");
                        dataGridView1.Columns.Add("SITUACAO", "SITUACAO");

                        DataGridViewTextBoxColumn rowNumberColumn = new DataGridViewTextBoxColumn();
                        rowNumberColumn.HeaderText = "";
                        dataGridView1.Columns.Insert(0, rowNumberColumn);
                        dataGridView1.Columns[0].Width = 40;
                        dataGridView1.Columns[5].Width = 50;
                        dataGridView1.Columns[6].Width = 60;

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

                    int rowNumber = 1;
                    while (reader.Read())
                    {
                        object[] row = new object[reader.FieldCount + 1];
                        row[0] = rowNumber;
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i + 1] = reader[i];
                        }
                        dataGridView1.Rows.Add(row);
                        rowNumber++;
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
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_desc.Text = "";
            txt_tel.Text = "";
            btn_salvar.Text = "SALVAR";
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedRows.Count;

            if (count == 0)
            {
                MessageBox.Show("Selecione pelo menos um cliente.");
                return;
            }

            DialogResult result = MessageBox.Show($"Deseja excluir {count} clientes(s) selecionado(s)?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conexaobd.Open();
                    comandoSQL.Connection = conexaobd;

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int cltId = Convert.ToInt32(row.Cells["ID"].Value);
                        comandoSQL.CommandText = "DELETE FROM TAB_CLIENTE WHERE CLT_ID = '" + cltId + "'";
                        comandoSQL.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cliente(s) excluído(s) com sucesso!");
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
            if ((txt_tel.Text == "(  )      -"))
            {
                txt_tel.Text = "";
            }
        }

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
                }
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
            }
            else
            {
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
            }
            Limpar();
            lista();
        }

        //Relatar
        private void btn_relatar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }
            if (situacao == "OK")
            {
                if (txt_desc.Text == "")
                {
                    MessageBox.Show("Descreva o cliente.");
                    return;
                }
                try
                {
                    conexaobd.Open();
                    comandoSQL.Connection = conexaobd;
                    comandoSQL.CommandText = "UPDATE TAB_CLIENTE SET CLT_SITUACAO = 'NÃO OK', CLT_DESCRICAO = '" + txt_desc.Text + "' WHERE CLT_ID = '" + id + "'";
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Cliente com irregularidades.");
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
            else
            {
                try
                {
                    conexaobd.Open();
                    comandoSQL.Connection = conexaobd;
                    comandoSQL.CommandText = "UPDATE TAB_CLIENTE SET CLT_SITUACAO = 'OK', CLT_DESCRICAO = '" + txt_desc.Text + "' WHERE CLT_ID = '" + id + "'";
                    comandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Cliente sem irregularidades.");
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
            Limpar();
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Close();
            new Tela_Inicial().Show();
        }

        private void btn_comanda_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Inserir().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Comandas().Show();
        }

        private void button2_Click(object sender, EventArgs e)
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
