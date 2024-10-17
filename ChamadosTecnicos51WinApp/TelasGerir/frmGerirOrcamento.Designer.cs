namespace Forms.TelasGerir
{
    partial class frmGerirOrcamento
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
            lblBuscar = new Label();
            btnBusca = new Button();
            txbBuscar = new TextBox();
            dgvChamados = new DataGridView();
            lblGerirCliente = new Label();
            btnIncluir = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(353, 27);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(106, 15);
            lblBuscar.TabIndex = 12;
            lblBuscar.Text = "Buscar por Cliente:";
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(628, 22);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(31, 23);
            btnBusca.TabIndex = 11;
            btnBusca.Text = "B";
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(465, 22);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(157, 23);
            txbBuscar.TabIndex = 10;
            // 
            // dgvChamados
            // 
            dgvChamados.AllowUserToAddRows = false;
            dgvChamados.AllowUserToDeleteRows = false;
            dgvChamados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamados.Location = new Point(12, 51);
            dgvChamados.Name = "dgvChamados";
            dgvChamados.ReadOnly = true;
            dgvChamados.RowTemplate.Height = 25;
            dgvChamados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChamados.Size = new Size(648, 245);
            dgvChamados.TabIndex = 9;
            // 
            // lblGerirCliente
            // 
            lblGerirCliente.AutoSize = true;
            lblGerirCliente.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblGerirCliente.Location = new Point(12, 14);
            lblGerirCliente.Name = "lblGerirCliente";
            lblGerirCliente.Size = new Size(162, 28);
            lblGerirCliente.TabIndex = 8;
            lblGerirCliente.Text = "Gerir Chamados";
            // 
            // btnIncluir
            // 
            btnIncluir.AutoSize = true;
            btnIncluir.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnIncluir.Location = new Point(666, 76);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(157, 38);
            btnIncluir.TabIndex = 13;
            btnIncluir.Text = "Incluir Chamado";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.AutoSize = true;
            btnAlterar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(666, 145);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(157, 38);
            btnAlterar.TabIndex = 14;
            btnAlterar.Text = "Alterar Chamado";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = true;
            btnExcluir.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Location = new Point(666, 210);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(157, 38);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir Chamado";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmGerirChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 311);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(lblBuscar);
            Controls.Add(btnBusca);
            Controls.Add(txbBuscar);
            Controls.Add(dgvChamados);
            Controls.Add(lblGerirCliente);
            Name = "frmGerirChamado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerir Chamados";
            ((System.ComponentModel.ISupportInitialize)dgvChamados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar;
        private Button btnBusca;
        private TextBox txbBuscar;
        private DataGridView dgvChamados;
        private Label lblGerirCliente;
        private Button btnIncluir;
        private Button btnAlterar;
        private Button btnExcluir;
    }
}