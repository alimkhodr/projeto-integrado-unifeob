namespace Portaria
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_tipo = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            txt_senha = new TextBox();
            btn_salvar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_tipo
            // 
            txt_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_tipo.Font = new Font("Arial", 16F);
            txt_tipo.FormattingEnabled = true;
            txt_tipo.Location = new Point(45, 148);
            txt_tipo.Name = "txt_tipo";
            txt_tipo.Size = new Size(254, 32);
            txt_tipo.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 16F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(45, 119);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 30;
            label5.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(45, 188);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 23;
            label1.Text = "Senha";
            // 
            // txt_senha
            // 
            txt_senha.Cursor = Cursors.IBeam;
            txt_senha.Font = new Font("Arial", 16F);
            txt_senha.Location = new Point(45, 217);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(254, 32);
            txt_senha.TabIndex = 2;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.KeyPress += txt_senha_KeyPress;
            // 
            // btn_salvar
            // 
            btn_salvar.AccessibleDescription = "";
            btn_salvar.AccessibleName = "";
            btn_salvar.BackColor = Color.FromArgb(0, 191, 99);
            btn_salvar.Cursor = Cursors.Hand;
            btn_salvar.FlatAppearance.BorderColor = Color.FromArgb(0, 191, 99);
            btn_salvar.FlatAppearance.BorderSize = 2;
            btn_salvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 191, 99);
            btn_salvar.FlatAppearance.MouseOverBackColor = Color.Black;
            btn_salvar.FlatStyle = FlatStyle.Flat;
            btn_salvar.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btn_salvar.ForeColor = SystemColors.ControlLightLight;
            btn_salvar.Location = new Point(45, 266);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(254, 37);
            btn_salvar.TabIndex = 3;
            btn_salvar.Text = "ENTRAR";
            btn_salvar.UseVisualStyleBackColor = false;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_expediente1;
            pictureBox1.Location = new Point(92, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(346, 345);
            Controls.Add(pictureBox1);
            Controls.Add(btn_salvar);
            Controls.Add(txt_tipo);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txt_senha);
            Font = new Font("Montserrat Medium", 8.999999F, FontStyle.Bold);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Comanda_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txt_tipo;
        private Label label5;
        private Label label1;
        private TextBox txt_senha;
        private Button btn_salvar;
        private PictureBox pictureBox1;
    }
}