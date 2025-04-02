namespace Portaria
{
    partial class Tela_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Clientes));
            dataGridView1 = new DataGridView();
            btn_limpar = new Button();
            button1 = new Button();
            txt_nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_tel = new MaskedTextBox();
            label3 = new Label();
            txt_desc = new TextBox();
            btn_salvar = new Button();
            btn_relatar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
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
            btn_limpar.Location = new Point(33, 357);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(80, 35);
            btn_limpar.TabIndex = 5;
            btn_limpar.Text = "LIMPAR";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
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
            button1.Location = new Point(32, 447);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 7;
            button1.Text = "EXCLUIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_nome
            // 
            txt_nome.Cursor = Cursors.IBeam;
            txt_nome.Font = new Font("Arial", 16F);
            txt_nome.Location = new Point(32, 162);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(216, 32);
            txt_nome.TabIndex = 1;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 133);
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
            label2.Location = new Point(32, 204);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 12;
            label2.Text = "Telefone";
            // 
            // txt_tel
            // 
            txt_tel.Cursor = Cursors.IBeam;
            txt_tel.Font = new Font("Arial", 16F);
            txt_tel.Location = new Point(32, 233);
            txt_tel.Mask = "(00) 00000-0000";
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(216, 32);
            txt_tel.TabIndex = 2;
            txt_tel.Click += txt_tel_Click;
            txt_tel.TextChanged += txt_tel_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 16F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(33, 276);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 40;
            label3.Text = "Descrição";
            // 
            // txt_desc
            // 
            txt_desc.Cursor = Cursors.IBeam;
            txt_desc.Font = new Font("Arial", 16F);
            txt_desc.Location = new Point(33, 305);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(216, 32);
            txt_desc.TabIndex = 3;
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
            btn_salvar.Location = new Point(121, 357);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(127, 35);
            btn_salvar.TabIndex = 4;
            btn_salvar.Text = "SALVAR";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_relatar
            // 
            btn_relatar.BackColor = Color.FromArgb(255, 49, 49);
            btn_relatar.BackgroundImageLayout = ImageLayout.None;
            btn_relatar.Cursor = Cursors.Hand;
            btn_relatar.FlatAppearance.BorderSize = 0;
            btn_relatar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btn_relatar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_relatar.FlatStyle = FlatStyle.Flat;
            btn_relatar.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btn_relatar.ForeColor = Color.Transparent;
            btn_relatar.Location = new Point(32, 402);
            btn_relatar.Name = "btn_relatar";
            btn_relatar.Size = new Size(216, 35);
            btn_relatar.TabIndex = 6;
            btn_relatar.Text = "RELATAR";
            btn_relatar.UseVisualStyleBackColor = false;
            btn_relatar.Click += btn_relatar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(69, 69, 69);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(803, 19);
            button2.Name = "button2";
            button2.Size = new Size(189, 54);
            button2.TabIndex = 56;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 191, 99);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 191, 99);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(564, 19);
            button3.Name = "button3";
            button3.Size = new Size(222, 54);
            button3.TabIndex = 55;
            button3.Text = "CLIENTES";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(69, 69, 69);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            button4.FlatAppearance.MouseOverBackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(326, 19);
            button4.Name = "button4";
            button4.Size = new Size(222, 54);
            button4.TabIndex = 54;
            button4.Text = "COMANDAS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            btn_comanda.TabIndex = 53;
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
            btn_sair.TabIndex = 52;
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
            panel1.TabIndex = 57;
            // 
            // Tela_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(1005, 673);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(btn_comanda);
            Controls.Add(btn_sair);
            Controls.Add(panel1);
            Controls.Add(btn_relatar);
            Controls.Add(btn_salvar);
            Controls.Add(label3);
            Controls.Add(txt_desc);
            Controls.Add(button1);
            Controls.Add(txt_tel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_limpar);
            Controls.Add(txt_nome);
            Controls.Add(dataGridView1);
            Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tela_Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += Tela_Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btn_limpar;
        private Button button1;
        private TextBox txt_nome;
        private Label label1;
        private Label label2;
        private MaskedTextBox txt_tel;
        private Label label3;
        private TextBox txt_desc;
        private Button btn_salvar;
        private Button btn_relatar;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btn_comanda;
        private Button btn_sair;
        private Panel panel1;
    }
}
