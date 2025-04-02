namespace Portaria
{
    partial class Tela_Inserir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inserir));
            btn_salvar = new Button();
            dataGridView1 = new DataGridView();
            txt_nome = new TextBox();
            btn_limpar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_desc = new TextBox();
            txt_tel = new MaskedTextBox();
            txt_pagamento = new ComboBox();
            label5 = new Label();
            txt_comanda = new ComboBox();
            label4 = new Label();
            btn_excel = new Button();
            button3 = new Button();
            button2 = new Button();
            btn_comanda = new Button();
            btn_sair = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.BackColor = Color.FromArgb(0, 191, 99);
            btn_salvar.Cursor = Cursors.Hand;
            btn_salvar.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            btn_salvar.FlatAppearance.BorderSize = 2;
            btn_salvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            btn_salvar.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btn_salvar.ForeColor = SystemColors.ControlLightLight;
            btn_salvar.Location = new Point(122, 502);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(129, 35);
            btn_salvar.TabIndex = 6;
            btn_salvar.Text = "SALVAR";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
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
            dataGridView1.Location = new Point(277, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(715, 559);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // txt_nome
            // 
            txt_nome.Cursor = Cursors.IBeam;
            txt_nome.Font = new Font("Arial", 16F);
            txt_nome.Location = new Point(32, 165);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(219, 32);
            txt_nome.TabIndex = 1;
            txt_nome.TextChanged += txt_nome_TextChanged;
            txt_nome.KeyPress += txt_nome_KeyPress;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.DarkOrange;
            btn_limpar.Cursor = Cursors.Hand;
            btn_limpar.FlatAppearance.BorderColor = Color.DarkOrange;
            btn_limpar.FlatAppearance.BorderSize = 2;
            btn_limpar.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btn_limpar.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_limpar.FlatStyle = FlatStyle.Flat;
            btn_limpar.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btn_limpar.ForeColor = SystemColors.ControlLightLight;
            btn_limpar.Location = new Point(32, 502);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(81, 35);
            btn_limpar.TabIndex = 7;
            btn_limpar.Text = "LIMPAR";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 136);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 16F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(32, 207);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 12;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 16F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(32, 277);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 14;
            label3.Text = "Descrição";
            // 
            // txt_desc
            // 
            txt_desc.Cursor = Cursors.IBeam;
            txt_desc.Font = new Font("Arial", 16F);
            txt_desc.Location = new Point(32, 306);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(219, 32);
            txt_desc.TabIndex = 3;
            txt_desc.TextChanged += txt_desc_TextChanged;
            txt_desc.KeyPress += txt_desc_KeyPress;
            // 
            // txt_tel
            // 
            txt_tel.Cursor = Cursors.IBeam;
            txt_tel.Font = new Font("Arial", 16F);
            txt_tel.Location = new Point(32, 236);
            txt_tel.Mask = "(00) 00000-0000";
            txt_tel.Name = "txt_tel";
            txt_tel.RightToLeft = RightToLeft.No;
            txt_tel.Size = new Size(219, 32);
            txt_tel.TabIndex = 2;
            txt_tel.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txt_tel.Click += txt_tel_Click;
            txt_tel.TextChanged += txt_tel_TextChanged;
            txt_tel.KeyPress += txt_tel_KeyPress;
            // 
            // txt_pagamento
            // 
            txt_pagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_pagamento.Font = new Font("Arial", 16F);
            txt_pagamento.FormattingEnabled = true;
            txt_pagamento.Location = new Point(32, 447);
            txt_pagamento.Name = "txt_pagamento";
            txt_pagamento.Size = new Size(219, 32);
            txt_pagamento.TabIndex = 5;
            txt_pagamento.SelectedIndexChanged += txt_pagamento_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 16F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(32, 418);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 38;
            label5.Text = "Pagamento";
            // 
            // txt_comanda
            // 
            txt_comanda.Cursor = Cursors.IBeam;
            txt_comanda.Font = new Font("Arial", 16F);
            txt_comanda.FormattingEnabled = true;
            txt_comanda.Location = new Point(32, 376);
            txt_comanda.Name = "txt_comanda";
            txt_comanda.Size = new Size(219, 32);
            txt_comanda.TabIndex = 4;
            txt_comanda.KeyPress += txt_comanda_KeyPress_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 16F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(32, 347);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 36;
            label4.Text = "Comanda";
            // 
            // btn_excel
            // 
            btn_excel.BackColor = Color.FromArgb(69, 69, 69);
            btn_excel.BackgroundImage = (Image)resources.GetObject("btn_excel.BackgroundImage");
            btn_excel.BackgroundImageLayout = ImageLayout.Zoom;
            btn_excel.Cursor = Cursors.Hand;
            btn_excel.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            btn_excel.FlatAppearance.BorderSize = 0;
            btn_excel.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            btn_excel.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_excel.FlatStyle = FlatStyle.Flat;
            btn_excel.ForeColor = Color.Transparent;
            btn_excel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_excel.Location = new Point(803, 19);
            btn_excel.Name = "btn_excel";
            btn_excel.Size = new Size(189, 54);
            btn_excel.TabIndex = 50;
            btn_excel.UseVisualStyleBackColor = false;
            btn_excel.Click += btn_excel_Click;
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
            button3.Location = new Point(564, 19);
            button3.Name = "button3";
            button3.Size = new Size(222, 54);
            button3.TabIndex = 49;
            button3.Text = "CLIENTES";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            button2.Location = new Point(326, 19);
            button2.Name = "button2";
            button2.Size = new Size(222, 54);
            button2.TabIndex = 48;
            button2.Text = "COMANDAS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_comanda
            // 
            btn_comanda.BackColor = Color.FromArgb(0, 191, 99);
            btn_comanda.BackgroundImageLayout = ImageLayout.None;
            btn_comanda.Cursor = Cursors.Hand;
            btn_comanda.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            btn_comanda.FlatAppearance.BorderSize = 0;
            btn_comanda.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            btn_comanda.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 191, 99);
            btn_comanda.FlatStyle = FlatStyle.Flat;
            btn_comanda.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btn_comanda.ForeColor = SystemColors.ControlLightLight;
            btn_comanda.Location = new Point(89, 19);
            btn_comanda.Name = "btn_comanda";
            btn_comanda.Size = new Size(222, 54);
            btn_comanda.TabIndex = 47;
            btn_comanda.Text = "INSERIR COMANDA";
            btn_comanda.UseVisualStyleBackColor = false;
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
            btn_sair.Click += btn_sair_Click;
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
            // Tela_Inserir
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(1002, 673);
            Controls.Add(btn_excel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_comanda);
            Controls.Add(btn_sair);
            Controls.Add(panel1);
            Controls.Add(txt_pagamento);
            Controls.Add(label5);
            Controls.Add(txt_comanda);
            Controls.Add(label4);
            Controls.Add(txt_tel);
            Controls.Add(label3);
            Controls.Add(txt_desc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_limpar);
            Controls.Add(txt_nome);
            Controls.Add(btn_salvar);
            Controls.Add(dataGridView1);
            Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tela_Inserir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir Comanda";
            WindowState = FormWindowState.Maximized;
            Load += Tela_Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private DataGridView dataGridView1;
        private TextBox txt_nome;
        private Button btn_limpar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_desc;
        private MaskedTextBox txt_tel;
        private Button button1;
        private ComboBox txt_pagamento;
        private Label label5;
        private ComboBox txt_comanda;
        private Label label4;
        private Button btn_excel;
        private Button button3;
        private Button button2;
        private Button btn_comanda;
        private Button btn_sair;
        private Panel panel1;
    }
}
