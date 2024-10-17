namespace Forms
{
    partial class frmClienteAdicionar
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
            lblCadCliente = new Label();
            lbNome = new Label();
            txbNome = new TextBox();
            txbProfissao = new TextBox();
            lblProfissao = new Label();
            txbSetor = new TextBox();
            lblSetor = new Label();
            btnSalvar = new Button();
            gbEndereco = new GroupBox();
            txbNumero = new TextBox();
            label5 = new Label();
            txbRua = new TextBox();
            label4 = new Label();
            txbEstado = new TextBox();
            label3 = new Label();
            txbCidade = new TextBox();
            label2 = new Label();
            label1 = new Label();
            msbCep = new MaskedTextBox();
            txbObs = new TextBox();
            gbEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // lblCadCliente
            // 
            lblCadCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCadCliente.AutoSize = true;
            lblCadCliente.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCadCliente.Location = new Point(325, 8);
            lblCadCliente.Name = "lblCadCliente";
            lblCadCliente.Size = new Size(78, 28);
            lblCadCliente.TabIndex = 0;
            lblCadCliente.Text = "Cliente";
            // 
            // lbNome
            // 
            lbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbNome.AutoSize = true;
            lbNome.Location = new Point(13, 55);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(50, 20);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // txbNome
            // 
            txbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNome.Location = new Point(14, 79);
            txbNome.Margin = new Padding(3, 4, 3, 4);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(350, 27);
            txbNome.TabIndex = 0;
            // 
            // txbProfissao
            // 
            txbProfissao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbProfissao.Location = new Point(14, 149);
            txbProfissao.Margin = new Padding(3, 4, 3, 4);
            txbProfissao.Name = "txbProfissao";
            txbProfissao.Size = new Size(350, 27);
            txbProfissao.TabIndex = 1;
            // 
            // lblProfissao
            // 
            lblProfissao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProfissao.AutoSize = true;
            lblProfissao.Location = new Point(13, 125);
            lblProfissao.Name = "lblProfissao";
            lblProfissao.Size = new Size(69, 20);
            lblProfissao.TabIndex = 3;
            lblProfissao.Text = "Profissão";
            // 
            // txbSetor
            // 
            txbSetor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbSetor.Location = new Point(14, 221);
            txbSetor.Margin = new Padding(3, 4, 3, 4);
            txbSetor.Name = "txbSetor";
            txbSetor.Size = new Size(350, 27);
            txbSetor.TabIndex = 2;
            // 
            // lblSetor
            // 
            lblSetor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSetor.AutoSize = true;
            lblSetor.Location = new Point(13, 197);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(44, 20);
            lblSetor.TabIndex = 5;
            lblSetor.Text = "Setor";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalvar.Location = new Point(160, 387);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(480, 44);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "&Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // gbEndereco
            // 
            gbEndereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbEndereco.Controls.Add(txbNumero);
            gbEndereco.Controls.Add(label5);
            gbEndereco.Controls.Add(txbRua);
            gbEndereco.Controls.Add(label4);
            gbEndereco.Controls.Add(txbEstado);
            gbEndereco.Controls.Add(label3);
            gbEndereco.Controls.Add(txbCidade);
            gbEndereco.Controls.Add(label2);
            gbEndereco.Controls.Add(label1);
            gbEndereco.Controls.Add(msbCep);
            gbEndereco.Location = new Point(389, 55);
            gbEndereco.Margin = new Padding(3, 4, 3, 4);
            gbEndereco.Name = "gbEndereco";
            gbEndereco.Padding = new Padding(3, 4, 3, 4);
            gbEndereco.Size = new Size(407, 213);
            gbEndereco.TabIndex = 8;
            gbEndereco.TabStop = false;
            gbEndereco.Text = "Endereço";
            // 
            // txbNumero
            // 
            txbNumero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNumero.Location = new Point(322, 169);
            txbNumero.Margin = new Padding(3, 4, 3, 4);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(78, 27);
            txbNumero.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(322, 145);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 15;
            label5.Text = "Numero";
            // 
            // txbRua
            // 
            txbRua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbRua.Location = new Point(8, 169);
            txbRua.Margin = new Padding(3, 4, 3, 4);
            txbRua.Name = "txbRua";
            txbRua.Size = new Size(307, 27);
            txbRua.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(7, 145);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 13;
            label4.Text = "Rua";
            // 
            // txbEstado
            // 
            txbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbEstado.Location = new Point(322, 105);
            txbEstado.Margin = new Padding(3, 4, 3, 4);
            txbEstado.Name = "txbEstado";
            txbEstado.Size = new Size(78, 27);
            txbEstado.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(322, 81);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 11;
            label3.Text = "Estado";
            // 
            // txbCidade
            // 
            txbCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCidade.Location = new Point(8, 105);
            txbCidade.Margin = new Padding(3, 4, 3, 4);
            txbCidade.Name = "txbCidade";
            txbCidade.Size = new Size(307, 27);
            txbCidade.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(7, 81);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 9;
            label2.Text = "Cidade";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 41);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 9;
            label1.Text = "CEP : ";
            // 
            // msbCep
            // 
            msbCep.BorderStyle = BorderStyle.FixedSingle;
            msbCep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            msbCep.Location = new Point(57, 36);
            msbCep.Margin = new Padding(3, 4, 3, 4);
            msbCep.Mask = "00000-000";
            msbCep.Name = "msbCep";
            msbCep.Size = new Size(87, 27);
            msbCep.TabIndex = 3;
            // 
            // txbObs
            // 
            txbObs.Location = new Point(16, 283);
            txbObs.Margin = new Padding(3, 4, 3, 4);
            txbObs.Multiline = true;
            txbObs.Name = "txbObs";
            txbObs.PlaceholderText = "Observação";
            txbObs.Size = new Size(773, 88);
            txbObs.TabIndex = 10;
            // 
            // frmClienteAdicionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(809, 440);
            Controls.Add(txbObs);
            Controls.Add(gbEndereco);
            Controls.Add(btnSalvar);
            Controls.Add(txbSetor);
            Controls.Add(lblSetor);
            Controls.Add(txbProfissao);
            Controls.Add(lblProfissao);
            Controls.Add(txbNome);
            Controls.Add(lbNome);
            Controls.Add(lblCadCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmClienteAdicionar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adiconar Cliente";
            gbEndereco.ResumeLayout(false);
            gbEndereco.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadCliente;
        private Label lbNome;
        private TextBox txbNome;
        private TextBox txbProfissao;
        private Label lblProfissao;
        private TextBox txbSetor;
        private Label lblSetor;
        private Button btnSalvar;
        private GroupBox gbEndereco;
        private Label label1;
        private MaskedTextBox msbCep;
        private TextBox txbNumero;
        private Label label5;
        private TextBox txbRua;
        private Label label4;
        private TextBox txbEstado;
        private Label label3;
        private TextBox txbCidade;
        private Label label2;
        private TextBox txbObs;
    }
}