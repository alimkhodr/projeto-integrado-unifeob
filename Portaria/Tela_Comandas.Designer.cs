namespace Portaria
{
    partial class Tela_Comandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Comandas));
            dataGridView1 = new DataGridView();
            btn_finalizar = new Button();
            button1 = new Button();
            txt_qtd = new TextBox();
            txt_nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_tel = new MaskedTextBox();
            label4 = new Label();
            txt_comanda = new ComboBox();
            label5 = new Label();
            txt_pagamento = new ComboBox();
            btn_excel = new Button();
            button3 = new Button();
            button2 = new Button();
            btn_comanda = new Button();
            btn_sair = new Button();
            panel1 = new Panel();
            btn_limpar = new Button();
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
            dataGridView1.Location = new Point(278, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(715, 559);
            dataGridView1.TabIndex = 1;
            // 
            // btn_finalizar
            // 
            btn_finalizar.BackColor = Color.FromArgb(0, 191, 99);
            btn_finalizar.Cursor = Cursors.Hand;
            btn_finalizar.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            btn_finalizar.FlatAppearance.BorderSize = 2;
            btn_finalizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            btn_finalizar.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_finalizar.FlatStyle = FlatStyle.Flat;
            btn_finalizar.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btn_finalizar.ForeColor = SystemColors.ControlLightLight;
            btn_finalizar.Location = new Point(34, 425);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(215, 35);
            btn_finalizar.TabIndex = 36;
            btn_finalizar.Text = "FINALIZAR";
            btn_finalizar.UseVisualStyleBackColor = false;
            btn_finalizar.Click += btn_finalizar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 49, 49);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 49, 49);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 49, 49);
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(125, 470);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 38;
            button1.Text = "EXCLUIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_qtd
            // 
            txt_qtd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_qtd.Enabled = false;
            txt_qtd.Font = new Font("Arial", 16F);
            txt_qtd.Location = new Point(813, 627);
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Size = new Size(177, 32);
            txt_qtd.TabIndex = 39;
            txt_qtd.TextAlign = HorizontalAlignment.Right;
            // 
            // txt_nome
            // 
            txt_nome.Cursor = Cursors.IBeam;
            txt_nome.Font = new Font("Arial", 16F);
            txt_nome.Location = new Point(34, 161);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(216, 32);
            txt_nome.TabIndex = 6;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(34, 132);
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
            label2.Location = new Point(34, 203);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 12;
            label2.Text = "Telefone";
            // 
            // txt_tel
            // 
            txt_tel.Cursor = Cursors.IBeam;
            txt_tel.Font = new Font("Arial", 16F);
            txt_tel.Location = new Point(34, 232);
            txt_tel.Mask = "(00) 00000-0000";
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(216, 32);
            txt_tel.TabIndex = 18;
            txt_tel.Click += txt_tel_Click;
            txt_tel.TextChanged += txt_tel_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 16F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(34, 274);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 32;
            label4.Text = "Comanda";
            // 
            // txt_comanda
            // 
            txt_comanda.Cursor = Cursors.IBeam;
            txt_comanda.Font = new Font("Arial", 16F);
            txt_comanda.FormattingEnabled = true;
            txt_comanda.Location = new Point(34, 303);
            txt_comanda.Name = "txt_comanda";
            txt_comanda.Size = new Size(216, 32);
            txt_comanda.TabIndex = 33;
            txt_comanda.TextChanged += txt_comanda_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 16F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(34, 345);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 34;
            label5.Text = "Pagamento";
            // 
            // txt_pagamento
            // 
            txt_pagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_pagamento.Font = new Font("Arial", 16F);
            txt_pagamento.FormattingEnabled = true;
            txt_pagamento.Location = new Point(34, 374);
            txt_pagamento.Name = "txt_pagamento";
            txt_pagamento.Size = new Size(216, 32);
            txt_pagamento.TabIndex = 35;
            txt_pagamento.SelectedIndexChanged += txt_pagamento_SelectedIndexChanged;
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
            btn_excel.TabIndex = 44;
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
            button3.TabIndex = 43;
            button3.Text = "CLIENTES";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 191, 99);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 191, 99);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(326, 19);
            button2.Name = "button2";
            button2.Size = new Size(222, 54);
            button2.TabIndex = 42;
            button2.Text = "COMANDAS";
            button2.UseVisualStyleBackColor = false;
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
            btn_comanda.TabIndex = 41;
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
            btn_sair.TabIndex = 40;
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
            panel1.TabIndex = 45;
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
            btn_limpar.Location = new Point(34, 470);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(80, 35);
            btn_limpar.TabIndex = 9;
            btn_limpar.Text = "LIMPAR";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // Tela_Comandas
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(1005, 673);
            Controls.Add(btn_excel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_comanda);
            Controls.Add(btn_sair);
            Controls.Add(txt_qtd);
            Controls.Add(button1);
            Controls.Add(btn_finalizar);
            Controls.Add(txt_pagamento);
            Controls.Add(label5);
            Controls.Add(txt_comanda);
            Controls.Add(label4);
            Controls.Add(txt_tel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_limpar);
            Controls.Add(txt_nome);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tela_Comandas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comandas";
            WindowState = FormWindowState.Maximized;
            Load += Tela_Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btn_finalizar;
        private Button button1;
        private TextBox txt_qtd;
        private TextBox txt_nome;
        private Label label1;
        private Label label2;
        private MaskedTextBox txt_tel;
        private Label label4;
        private ComboBox txt_comanda;
        private Label label5;
        private ComboBox txt_pagamento;
        private Button btn_excel;
        private Button button3;
        private Button button2;
        private Button btn_comanda;
        private Button btn_sair;
        private Panel panel1;
        private Button btn_limpar;
    }
}
