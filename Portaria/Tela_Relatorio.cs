using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using OfficeOpenXml;

namespace Portaria
{
    public partial class Tela_Relatorio : Form
    {
        SQLiteConnection conexaobd;
        SQLiteCommand comandoSQL;
        private void Tela_Inicial_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_sair, "Voltar a Tela Inicial");

            txt_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            lista();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public Tela_Relatorio()
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
                conexaobd.Open();
                comandoSQL.Connection = conexaobd;
                comandoSQL.CommandText = "SELECT CMD_ID,CLT_NOME,CLT_TELEFONE,CMD_NUMERO,CMD_PAGAMENTO,strftime(CMD_ENTRADA) FROM TAB_CLIENTE LEFT JOIN TAB_COMANDAS ON CLT_ID = CMD_CLIENTE ";
                comandoSQL.CommandText += "WHERE CMD_ENTRADA IS NOT NULL AND CMD_ENTRADA LIKE '" + txt_data.Text + "%' ORDER BY strftime('%Y-%m-%d %H:%M:%S', CMD_ENTRADA) DESC;";
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
                        dataGridView1.Columns.Add("ENTRADA", "ENTRADA");

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

        private void txt_data_ValueChanged(object sender, EventArgs e)
        {
            lista();

            txt_cartao.Clear();
            txt_dinheiro.Clear();
            txt_vip.Clear();

            int cartaoCount = 0;
            int dinheiroCount = 0;
            int vipCount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["PAGAMENTO"].Value != null)
                {
                    string pagamento = row.Cells["PAGAMENTO"].Value.ToString();
                    switch (pagamento)
                    {
                        case "CARTÃO":
                            cartaoCount++;
                            break;
                        case "DINHEIRO":
                            dinheiroCount++;
                            break;
                        case "VIP":
                            vipCount++;
                            break;
                        default:
                            break;
                    }
                }
            }

            txt_cartao.Text = cartaoCount.ToString();
            txt_dinheiro.Text = dinheiroCount.ToString();
            txt_vip.Text = vipCount.ToString();
        }
        private void btn_excel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Dados");

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        if (dataGridView1.Columns[i].Name != "ID")
                        {
                            worksheet.Cells[1, i].Value = dataGridView1.Columns[i].HeaderText;
                        }
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0, colIndex = 1; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Columns[j].Name != "ID")
                            {
                                worksheet.Cells[i + 2, colIndex].Value = dataGridView1.Rows[i].Cells[j].Value;
                                colIndex++;
                            }
                        }
                    }

                    int lastRowIndex = dataGridView1.Rows.Count + 2;
                    string[] paymentTypes = { "CARTÃO", "DINHEIRO", "VIP" };
                    for (int i = 0, colIndex = 2; i < paymentTypes.Length; i++)
                    {
                        int sum = dataGridView1.Rows.Cast<DataGridViewRow>()
                            .Sum(row =>
                            {
                                object cellValue = row.Cells["PAGAMENTO"].Value;
                                return cellValue != null && cellValue.ToString() == paymentTypes[i] ? 1 : 0;
                            });

                        worksheet.Cells[lastRowIndex, colIndex].Value = $"{sum} {paymentTypes[i]}";
                        colIndex++;
                    }
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                    worksheet.Cells[worksheet.Dimension.Address].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[lastRowIndex, 1, lastRowIndex, worksheet.Dimension.End.Column].Style.Font.Bold = true;

                    string nomeArquivo = $"Portaria_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
                    string caminhoDoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nomeArquivo);
                    File.WriteAllBytes(caminhoDoArquivo, package.GetAsByteArray());
                    try
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = caminhoDoArquivo,
                            UseShellExecute = true
                        });
                    }
                    catch (System.ComponentModel.Win32Exception ex)
                    {
                        MessageBox.Show($"Não foi possível abrir o arquivo. Certifique-se de ter um programa associado para arquivos .xlsx instalado no seu sistema. Detalhes do erro: {ex.Message}", "Erro ao abrir arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show($"Dados exportados com sucesso para:\n{caminhoDoArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar dados para Excel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Comandas().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            new Tela_Clientes().Show();
        }
    }
}
