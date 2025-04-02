namespace Portaria
{
    partial class Tela_Relatorio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Relatorio));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btn_excel = new Button();
            txt_data = new DateTimePicker();
            txt_cartao = new TextBox();
            txt_dinheiro = new TextBox();
            txt_vip = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btn_comanda = new Button();
            btn_sair = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(278, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(715, 560);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(35, 133);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 10;
            label1.Text = "Data";
            // 
            // btn_excel
            // 
            btn_excel.BackColor = Color.FromArgb(0, 191, 99);
            btn_excel.Cursor = Cursors.Hand;
            btn_excel.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            btn_excel.FlatAppearance.BorderSize = 2;
            btn_excel.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            btn_excel.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_excel.FlatStyle = FlatStyle.Flat;
            btn_excel.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btn_excel.ForeColor = SystemColors.ControlLightLight;
            btn_excel.Location = new Point(35, 205);
            btn_excel.Name = "btn_excel";
            btn_excel.Size = new Size(216, 35);
            btn_excel.TabIndex = 36;
            btn_excel.Text = "EXPORTAR";
            btn_excel.UseVisualStyleBackColor = false;
            btn_excel.Click += btn_excel_Click;
            // 
            // txt_data
            // 
            txt_data.CalendarFont = new Font("Arial", 16F);
            txt_data.Font = new Font("Arial", 16F);
            txt_data.Format = DateTimePickerFormat.Short;
            txt_data.Location = new Point(35, 163);
            txt_data.Name = "txt_data";
            txt_data.Size = new Size(216, 32);
            txt_data.TabIndex = 38;
            txt_data.Value = new DateTime(2024, 1, 26, 0, 0, 0, 0);
            txt_data.ValueChanged += txt_data_ValueChanged;
            // 
            // txt_cartao
            // 
            txt_cartao.Enabled = false;
            txt_cartao.Font = new Font("Arial", 16F);
            txt_cartao.Location = new Point(35, 275);
            txt_cartao.Name = "txt_cartao";
            txt_cartao.Size = new Size(66, 32);
            txt_cartao.TabIndex = 40;
            // 
            // txt_dinheiro
            // 
            txt_dinheiro.Enabled = false;
            txt_dinheiro.Font = new Font("Arial", 16F);
            txt_dinheiro.Location = new Point(109, 275);
            txt_dinheiro.Name = "txt_dinheiro";
            txt_dinheiro.Size = new Size(66, 32);
            txt_dinheiro.TabIndex = 41;
            // 
            // txt_vip
            // 
            txt_vip.Enabled = false;
            txt_vip.Font = new Font("Arial", 16F);
            txt_vip.Location = new Point(182, 275);
            txt_vip.Name = "txt_vip";
            txt_vip.Size = new Size(66, 32);
            txt_vip.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(35, 254);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 43;
            label2.Text = "Cartão";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(108, 254);
            label3.Name = "label3";
            label3.Size = new Size(67, 18);
            label3.TabIndex = 44;
            label3.Text = "Dinheiro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(182, 254);
            label4.Name = "label4";
            label4.Size = new Size(32, 18);
            label4.TabIndex = 45;
            label4.Text = "Vip";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 191, 99);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 191, 99);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(803, 19);
            button1.Name = "button1";
            button1.Size = new Size(189, 54);
            button1.TabIndex = 50;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(69, 69, 69);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(564, 19);
            button2.Name = "button2";
            button2.Size = new Size(222, 54);
            button2.TabIndex = 49;
            button2.Text = "CLIENTES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(69, 69, 69);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            button3.FlatAppearance.MouseOverBackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(326, 19);
            button3.Name = "button3";
            button3.Size = new Size(222, 54);
            button3.TabIndex = 48;
            button3.Text = "COMANDAS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btn_comanda
            // 
            btn_comanda.BackColor = Color.FromArgb(69, 69, 69);
            btn_comanda.BackgroundImageLayout = ImageLayout.None;
            btn_comanda.Cursor = Cursors.Hand;
            btn_comanda.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            btn_comanda.FlatAppearance.BorderSize = 0;
            btn_comanda.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            btn_comanda.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_comanda.FlatStyle = FlatStyle.Flat;
            btn_comanda.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btn_comanda.ForeColor = SystemColors.ControlLightLight;
            btn_comanda.Location = new Point(89, 19);
            btn_comanda.Name = "btn_comanda";
            btn_comanda.Size = new Size(222, 54);
            btn_comanda.TabIndex = 47;
            btn_comanda.Text = "INSERIR COMANDA";
            btn_comanda.UseVisualStyleBackColor = false;
            btn_comanda.Click += btn_comanda_Click;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.FromArgb(255, 49, 49);
            btn_sair.BackgroundImage = (Image)resources.GetObject("btn_sair.BackgroundImage");
            btn_sair.BackgroundImageLayout = ImageLayout.Zoom;
            btn_sair.Cursor = Cursors.Hand;
            btn_sair.FlatAppearance.BorderColor = Color.FromArgb(255, 49, 49);
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 49, 49);
            btn_sair.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.ForeColor = Color.Transparent;
            btn_sair.Location = new Point(14, 19);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(60, 54);
            btn_sair.TabIndex = 46;
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 90);
            panel1.TabIndex = 51;
            // 
            // Tela_Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(1005, 673);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_vip);
            Controls.Add(txt_dinheiro);
            Controls.Add(txt_cartao);
            Controls.Add(txt_data);
            Controls.Add(btn_excel);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btn_comanda);
            Controls.Add(btn_sair);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tela_Relatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios";
            WindowState = FormWindowState.Maximized;
            Load += Tela_Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private Button btn_excel;
        private DateTimePicker txt_data;
        private TextBox txt_cartao;
        private TextBox txt_dinheiro;
        private TextBox txt_vip;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btn_comanda;
        private Button btn_sair;
        private Panel panel1;
    }
}
