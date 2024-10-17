namespace Forms.Adicionar
{
    partial class frmAdicionaAlterarOrcamentos
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
            lblCliente = new Label();
            lblTecnico = new Label();
            cbTecnico = new ComboBox();
            dtpSolicita = new DateTimePicker();
            lblDataSolicitacao = new Label();
            gbDados = new GroupBox();
            btnSelecionaCliente = new Button();
            txbCliente = new TextBox();
            btnSalvar = new Button();
            txBoxOcorrencia = new TextBox();
            lblOcorrencia = new Label();
            lblProblema = new Label();
            txbProblema = new TextBox();
            txbCodigoOrcamento = new TextBox();
            lblCodigoChamado = new Label();
            btnLimpar = new Button();
            gbConcluido = new GroupBox();
            rbConcluidoNao = new RadioButton();
            rbConcluidoSim = new RadioButton();
            pnFooter = new Panel();
            gbDados.SuspendLayout();
            gbConcluido.SuspendLayout();
            pnFooter.SuspendLayout();
            SuspendLayout();
            // 
            // lblCadCliente
            // 
            lblCadCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCadCliente.AutoSize = true;
            lblCadCliente.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCadCliente.Location = new Point(16, 9);
            lblCadCliente.Name = "lblCadCliente";
            lblCadCliente.Size = new Size(117, 28);
            lblCadCliente.TabIndex = 8;
            lblCadCliente.Text = "Orçamento";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(7, 25);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 10;
            lblCliente.Text = "Cliente";
            // 
            // lblTecnico
            // 
            lblTecnico.AutoSize = true;
            lblTecnico.Location = new Point(8, 99);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(59, 20);
            lblTecnico.TabIndex = 12;
            lblTecnico.Text = "Técnico";
            // 
            // cbTecnico
            // 
            cbTecnico.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTecnico.FormattingEnabled = true;
            cbTecnico.Location = new Point(9, 125);
            cbTecnico.Margin = new Padding(3, 4, 3, 4);
            cbTecnico.Name = "cbTecnico";
            cbTecnico.Size = new Size(405, 28);
            cbTecnico.TabIndex = 3;
            cbTecnico.Text = "[Selecione]";
            // 
            // dtpSolicita
            // 
            dtpSolicita.Location = new Point(11, 200);
            dtpSolicita.Margin = new Padding(3, 4, 3, 4);
            dtpSolicita.Name = "dtpSolicita";
            dtpSolicita.Size = new Size(403, 27);
            dtpSolicita.TabIndex = 4;
            // 
            // lblDataSolicitacao
            // 
            lblDataSolicitacao.AutoSize = true;
            lblDataSolicitacao.Location = new Point(9, 176);
            lblDataSolicitacao.Name = "lblDataSolicitacao";
            lblDataSolicitacao.Size = new Size(118, 20);
            lblDataSolicitacao.TabIndex = 14;
            lblDataSolicitacao.Text = "Data Solicitação";
            // 
            // gbDados
            // 
            gbDados.Controls.Add(btnSelecionaCliente);
            gbDados.Controls.Add(txbCliente);
            gbDados.Controls.Add(lblCliente);
            gbDados.Controls.Add(lblDataSolicitacao);
            gbDados.Controls.Add(dtpSolicita);
            gbDados.Controls.Add(lblTecnico);
            gbDados.Controls.Add(cbTecnico);
            gbDados.Location = new Point(17, 60);
            gbDados.Margin = new Padding(3, 4, 3, 4);
            gbDados.Name = "gbDados";
            gbDados.Padding = new Padding(3, 4, 3, 4);
            gbDados.Size = new Size(431, 271);
            gbDados.TabIndex = 15;
            gbDados.TabStop = false;
            gbDados.Text = "Dados";
            // 
            // btnSelecionaCliente
            // 
            btnSelecionaCliente.Location = new Point(367, 59);
            btnSelecionaCliente.Margin = new Padding(3, 4, 3, 4);
            btnSelecionaCliente.Name = "btnSelecionaCliente";
            btnSelecionaCliente.Size = new Size(48, 31);
            btnSelecionaCliente.TabIndex = 2;
            btnSelecionaCliente.Text = "...";
            btnSelecionaCliente.UseVisualStyleBackColor = true;
            btnSelecionaCliente.Click += btnSelecionaCliente_Click;
            // 
            // txbCliente
            // 
            txbCliente.Location = new Point(10, 59);
            txbCliente.Margin = new Padding(3, 4, 3, 4);
            txbCliente.Name = "txbCliente";
            txbCliente.PlaceholderText = "Clique no botão para buscar ";
            txbCliente.ReadOnly = true;
            txbCliente.Size = new Size(349, 27);
            txbCliente.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalvar.AutoSize = true;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(54, 7);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(323, 44);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txBoxOcorrencia
            // 
            txBoxOcorrencia.Location = new Point(469, 89);
            txBoxOcorrencia.Margin = new Padding(3, 4, 3, 4);
            txBoxOcorrencia.Multiline = true;
            txBoxOcorrencia.Name = "txBoxOcorrencia";
            txBoxOcorrencia.Size = new Size(321, 52);
            txBoxOcorrencia.TabIndex = 4;
            // 
            // lblOcorrencia
            // 
            lblOcorrencia.AutoSize = true;
            lblOcorrencia.Location = new Point(469, 65);
            lblOcorrencia.Name = "lblOcorrencia";
            lblOcorrencia.Size = new Size(81, 20);
            lblOcorrencia.TabIndex = 18;
            lblOcorrencia.Text = "Ocorrência";
            // 
            // lblProblema
            // 
            lblProblema.AutoSize = true;
            lblProblema.Location = new Point(469, 159);
            lblProblema.Name = "lblProblema";
            lblProblema.Size = new Size(73, 20);
            lblProblema.TabIndex = 20;
            lblProblema.Text = "Problema";
            // 
            // txbProblema
            // 
            txbProblema.Location = new Point(469, 183);
            txbProblema.Margin = new Padding(3, 4, 3, 4);
            txbProblema.Multiline = true;
            txbProblema.Name = "txbProblema";
            txbProblema.Size = new Size(321, 52);
            txbProblema.TabIndex = 5;
            // 
            // txbCodigoOrcamento
            // 
            txbCodigoOrcamento.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txbCodigoOrcamento.Location = new Point(675, 16);
            txbCodigoOrcamento.Margin = new Padding(3, 4, 3, 4);
            txbCodigoOrcamento.Name = "txbCodigoOrcamento";
            txbCodigoOrcamento.ReadOnly = true;
            txbCodigoOrcamento.Size = new Size(114, 27);
            txbCodigoOrcamento.TabIndex = 21;
            txbCodigoOrcamento.Text = "0";
            // 
            // lblCodigoChamado
            // 
            lblCodigoChamado.AutoSize = true;
            lblCodigoChamado.Location = new Point(615, 20);
            lblCodigoChamado.Name = "lblCodigoChamado";
            lblCodigoChamado.Size = new Size(65, 20);
            lblCodigoChamado.TabIndex = 22;
            lblCodigoChamado.Text = "Código :";
            // 
            // btnLimpar
            // 
            btnLimpar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLimpar.AutoSize = true;
            btnLimpar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(430, 7);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(323, 44);
            btnLimpar.TabIndex = 23;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // gbConcluido
            // 
            gbConcluido.Controls.Add(rbConcluidoNao);
            gbConcluido.Controls.Add(rbConcluidoSim);
            gbConcluido.Location = new Point(637, 260);
            gbConcluido.Margin = new Padding(3, 4, 3, 4);
            gbConcluido.Name = "gbConcluido";
            gbConcluido.Padding = new Padding(3, 4, 3, 4);
            gbConcluido.Size = new Size(153, 71);
            gbConcluido.TabIndex = 24;
            gbConcluido.TabStop = false;
            gbConcluido.Text = "Concluido ?";
            // 
            // rbConcluidoNao
            // 
            rbConcluidoNao.AutoSize = true;
            rbConcluidoNao.Location = new Point(77, 29);
            rbConcluidoNao.Margin = new Padding(3, 4, 3, 4);
            rbConcluidoNao.Name = "rbConcluidoNao";
            rbConcluidoNao.Size = new Size(62, 24);
            rbConcluidoNao.TabIndex = 1;
            rbConcluidoNao.TabStop = true;
            rbConcluidoNao.Text = "NÃO";
            rbConcluidoNao.UseVisualStyleBackColor = true;
            // 
            // rbConcluidoSim
            // 
            rbConcluidoSim.AutoSize = true;
            rbConcluidoSim.Location = new Point(7, 29);
            rbConcluidoSim.Margin = new Padding(3, 4, 3, 4);
            rbConcluidoSim.Name = "rbConcluidoSim";
            rbConcluidoSim.Size = new Size(55, 24);
            rbConcluidoSim.TabIndex = 0;
            rbConcluidoSim.TabStop = true;
            rbConcluidoSim.Text = "SIM\r\n";
            rbConcluidoSim.UseVisualStyleBackColor = true;
            // 
            // pnFooter
            // 
            pnFooter.Controls.Add(btnSalvar);
            pnFooter.Controls.Add(btnLimpar);
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.Location = new Point(0, 350);
            pnFooter.Margin = new Padding(3, 4, 3, 4);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(814, 61);
            pnFooter.TabIndex = 25;
            // 
            // frmAdicionaAlterarOrcamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 411);
            Controls.Add(pnFooter);
            Controls.Add(gbConcluido);
            Controls.Add(lblCodigoChamado);
            Controls.Add(txbCodigoOrcamento);
            Controls.Add(lblProblema);
            Controls.Add(txbProblema);
            Controls.Add(lblOcorrencia);
            Controls.Add(txBoxOcorrencia);
            Controls.Add(gbDados);
            Controls.Add(lblCadCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdicionaAlterarOrcamentos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Chamado";
            gbDados.ResumeLayout(false);
            gbDados.PerformLayout();
            gbConcluido.ResumeLayout(false);
            gbConcluido.PerformLayout();
            pnFooter.ResumeLayout(false);
            pnFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadCliente;
        private Label lblCliente;
        private Label lblTecnico;
        private ComboBox cbTecnico;
        private DateTimePicker dtpSolicita;
        private Label lblDataSolicitacao;
        private GroupBox gbDados;
        private Button btnSalvar;
        private TextBox txBoxOcorrencia;
        private Label lblOcorrencia;
        private Label lblProblema;
        private TextBox txbProblema;
        private TextBox txbCodigoOrcamento;
        private Label lblCodigoChamado;
        private Button btnLimpar;
        private GroupBox gbConcluido;
        private RadioButton rbConcluidoSim;
        private Panel pnFooter;
        private Button btnSelecionaCliente;
        public TextBox txbCliente;
        private RadioButton rbConcluidoNao;
    }
}