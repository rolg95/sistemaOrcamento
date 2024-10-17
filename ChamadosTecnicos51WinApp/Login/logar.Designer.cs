namespace Forms.Login
{
    partial class logar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logar));
            pBoxImg = new PictureBox();
            lblBemVindo = new Label();
            gBCredenciais = new GroupBox();
            txbSenha = new TextBox();
            lblSenha = new Label();
            txbEmail = new TextBox();
            lblEmail = new Label();
            btnAcessar = new Button();
            btnFechar = new Button();
            lblSaudacao = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pBoxImg).BeginInit();
            gBCredenciais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pBoxImg
            // 
            pBoxImg.Image = Properties.Resources.loginIcon;
            pBoxImg.Location = new Point(126, 39);
            pBoxImg.Name = "pBoxImg";
            pBoxImg.Size = new Size(103, 100);
            pBoxImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxImg.TabIndex = 0;
            pBoxImg.TabStop = false;
            // 
            // lblBemVindo
            // 
            lblBemVindo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblBemVindo.Location = new Point(6, 24);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(15, 20);
            lblBemVindo.TabIndex = 1;
            lblBemVindo.Text = "..";
            lblBemVindo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gBCredenciais
            // 
            gBCredenciais.Controls.Add(txbSenha);
            gBCredenciais.Controls.Add(lblSenha);
            gBCredenciais.Controls.Add(txbEmail);
            gBCredenciais.Controls.Add(lblEmail);
            gBCredenciais.Controls.Add(lblBemVindo);
            gBCredenciais.Location = new Point(21, 203);
            gBCredenciais.Name = "gBCredenciais";
            gBCredenciais.Size = new Size(323, 174);
            gBCredenciais.TabIndex = 2;
            gBCredenciais.TabStop = false;
            gBCredenciais.Text = "Credenciais";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(9, 133);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(288, 23);
            txbSenha.TabIndex = 3;
            txbSenha.Text = "123";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(7, 115);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(9, 75);
            txbEmail.Name = "txbEmail";
            txbEmail.PlaceholderText = "E-mail";
            txbEmail.Size = new Size(288, 23);
            txbEmail.TabIndex = 1;
            txbEmail.Text = "teste@teste.com";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(7, 57);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-Mail";
            // 
            // btnAcessar
            // 
            btnAcessar.AutoSize = true;
            btnAcessar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcessar.Location = new Point(53, 394);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 30);
            btnAcessar.TabIndex = 3;
            btnAcessar.Text = "&Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // btnFechar
            // 
            btnFechar.AutoSize = true;
            btnFechar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnFechar.Location = new Point(243, 394);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 30);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblSaudacao
            // 
            lblSaudacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSaudacao.AutoSize = true;
            lblSaudacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaudacao.Location = new Point(139, 156);
            lblSaudacao.Name = "lblSaudacao";
            lblSaudacao.Size = new Size(16, 21);
            lblSaudacao.TabIndex = 5;
            lblSaudacao.Text = "..";
            lblSaudacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // logar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(375, 445);
            Controls.Add(lblSaudacao);
            Controls.Add(btnFechar);
            Controls.Add(btnAcessar);
            Controls.Add(gBCredenciais);
            Controls.Add(pBoxImg);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "logar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acesso";
            ((System.ComponentModel.ISupportInitialize)pBoxImg).EndInit();
            gBCredenciais.ResumeLayout(false);
            gBCredenciais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBoxImg;
        private Label lblBemVindo;
        private GroupBox gBCredenciais;
        private Button btnAcessar;
        private Button btnFechar;
        private TextBox txbSenha;
        private Label lblSenha;
        private TextBox txbEmail;
        private Label lblEmail;
        private Label lblSaudacao;
        private ErrorProvider errorProvider1;
    }
}