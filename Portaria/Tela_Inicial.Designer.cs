namespace Portaria
{
    partial class Tela_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            btn_sair = new Button();
            pictureBox1 = new PictureBox();
            btn_comanda = new Button();
            button2 = new Button();
            button3 = new Button();
            btn_excel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btn_sair.TabIndex = 11;
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(981, 570);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
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
            btn_comanda.TabIndex = 13;
            btn_comanda.Text = "INSERIR COMANDA";
            btn_comanda.UseVisualStyleBackColor = false;
            btn_comanda.Click += btn_comanda_Click;
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
            button2.TabIndex = 14;
            button2.Text = "COMANDAS";
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
            button3.Location = new Point(564, 19);
            button3.Name = "button3";
            button3.Size = new Size(222, 54);
            button3.TabIndex = 15;
            button3.Text = "CLIENTES";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            btn_excel.TabIndex = 16;
            btn_excel.UseVisualStyleBackColor = false;
            btn_excel.Click += btn_excel_Click;
            // 
            // Tela_Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1005, 673);
            Controls.Add(btn_excel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_comanda);
            Controls.Add(btn_sair);
            Controls.Add(pictureBox1);
            Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tela_Inicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            WindowState = FormWindowState.Maximized;
            Load += Tela_Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button btn_sair;
        private PictureBox pictureBox1;
        private Button btn_comanda;
        private Button button2;
        private Button button3;
        private Button btn_excel;
    }
}
