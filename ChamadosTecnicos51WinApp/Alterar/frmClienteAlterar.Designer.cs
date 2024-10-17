namespace Forms.Alterar
{
    partial class frmClienteAlterar
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
            btnSalvar = new Button();
            lblCadCliente = new Label();
            txbCodigoCliente = new TextBox();
            txbObs = new TextBox();
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
            txbSetor = new TextBox();
            lblSetor = new Label();
            txbProfissao = new TextBox();
            lblProfissao = new Label();
            txbNome = new TextBox();
            lbNome = new Label();
            gbEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalvar.Location = new Point(91, 308);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(432, 33);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar Alteração";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // lblCadCliente
            // 
            lblCadCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCadCliente.AutoSize = true;
            lblCadCliente.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCadCliente.Location = new Point(15, 9);
            lblCadCliente.Name = "lblCadCliente";
            lblCadCliente.Size = new Size(150, 28);
            lblCadCliente.TabIndex = 8;
            lblCadCliente.Text = "Alterar Cliente";
            // 
            // txbCodigoCliente
            // 
            txbCodigoCliente.Location = new Point(567, 14);
            txbCodigoCliente.Name = "txbCodigoCliente";
            txbCodigoCliente.ReadOnly = true;
            txbCodigoCliente.Size = new Size(100, 23);
            txbCodigoCliente.TabIndex = 16;
            // 
            // txbObs
            // 
            txbObs.Location = new Point(15, 222);
            txbObs.Multiline = true;
            txbObs.Name = "txbObs";
            txbObs.PlaceholderText = "Observação";
            txbObs.Size = new Size(652, 67);
            txbObs.TabIndex = 25;
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
            gbEndereco.Location = new Point(289, 51);
            gbEndereco.Name = "gbEndereco";
            gbEndereco.Size = new Size(378, 160);
            gbEndereco.TabIndex = 24;
            gbEndereco.TabStop = false;
            gbEndereco.Text = "Endereço";
            // 
            // txbNumero
            // 
            txbNumero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNumero.Location = new Point(282, 127);
            txbNumero.Name = "txbNumero";
            txbNumero.Size = new Size(90, 23);
            txbNumero.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(282, 109);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 15;
            label5.Text = "Numero";
            // 
            // txbRua
            // 
            txbRua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbRua.Location = new Point(7, 127);
            txbRua.Name = "txbRua";
            txbRua.Size = new Size(239, 23);
            txbRua.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(6, 109);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 13;
            label4.Text = "Rua";
            // 
            // txbEstado
            // 
            txbEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbEstado.Location = new Point(282, 79);
            txbEstado.Name = "txbEstado";
            txbEstado.Size = new Size(90, 23);
            txbEstado.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(282, 61);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Estado";
            // 
            // txbCidade
            // 
            txbCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbCidade.Location = new Point(7, 79);
            txbCidade.Name = "txbCidade";
            txbCidade.Size = new Size(239, 23);
            txbCidade.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 9;
            label2.Text = "Cidade";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(7, 31);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 9;
            label1.Text = "CEP : ";
            // 
            // msbCep
            // 
            msbCep.BorderStyle = BorderStyle.FixedSingle;
            msbCep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            msbCep.Location = new Point(50, 27);
            msbCep.Mask = "00000-000";
            msbCep.Name = "msbCep";
            msbCep.Size = new Size(76, 23);
            msbCep.TabIndex = 3;
            // 
            // txbSetor
            // 
            txbSetor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbSetor.Location = new Point(16, 176);
            txbSetor.Name = "txbSetor";
            txbSetor.Size = new Size(251, 23);
            txbSetor.TabIndex = 21;
            // 
            // lblSetor
            // 
            lblSetor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSetor.AutoSize = true;
            lblSetor.Location = new Point(15, 158);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(34, 15);
            lblSetor.TabIndex = 23;
            lblSetor.Text = "Setor";
            // 
            // txbProfissao
            // 
            txbProfissao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbProfissao.Location = new Point(16, 122);
            txbProfissao.Name = "txbProfissao";
            txbProfissao.Size = new Size(251, 23);
            txbProfissao.TabIndex = 19;
            // 
            // lblProfissao
            // 
            lblProfissao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProfissao.AutoSize = true;
            lblProfissao.Location = new Point(15, 104);
            lblProfissao.Name = "lblProfissao";
            lblProfissao.Size = new Size(55, 15);
            lblProfissao.TabIndex = 22;
            lblProfissao.Text = "Profissão";
            // 
            // txbNome
            // 
            txbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNome.Location = new Point(16, 69);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(251, 23);
            txbNome.TabIndex = 17;
            // 
            // lbNome
            // 
            lbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbNome.AutoSize = true;
            lbNome.Location = new Point(15, 51);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 20;
            lbNome.Text = "Nome";
            // 
            // frmClienteAlterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 353);
            Controls.Add(txbObs);
            Controls.Add(gbEndereco);
            Controls.Add(txbSetor);
            Controls.Add(lblSetor);
            Controls.Add(txbProfissao);
            Controls.Add(lblProfissao);
            Controls.Add(txbNome);
            Controls.Add(lbNome);
            Controls.Add(txbCodigoCliente);
            Controls.Add(btnSalvar);
            Controls.Add(lblCadCliente);
            Name = "frmClienteAlterar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Cliente";
            gbEndereco.ResumeLayout(false);
            gbEndereco.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label lblCadCliente;
        private TextBox txbCodigoCliente;
        private TextBox txbObs;
        private GroupBox gbEndereco;
        private TextBox txbNumero;
        private Label label5;
        private TextBox txbRua;
        private Label label4;
        private TextBox txbEstado;
        private Label label3;
        private TextBox txbCidade;
        private Label label2;
        private Label label1;
        private MaskedTextBox msbCep;
        private TextBox txbSetor;
        private Label lblSetor;
        private TextBox txbProfissao;
        private Label lblProfissao;
        private TextBox txbNome;
        private Label lbNome;
    }
}