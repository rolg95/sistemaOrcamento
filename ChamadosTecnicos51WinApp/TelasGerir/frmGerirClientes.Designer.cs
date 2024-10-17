namespace Forms.TelasGerir
{
    partial class frmGerirClientes
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
            lblGerirCliente = new Label();
            dgvCliente = new DataGridView();
            btnIncluir = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            txbBuscar = new TextBox();
            btnBusca = new Button();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // lblGerirCliente
            // 
            lblGerirCliente.AutoSize = true;
            lblGerirCliente.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblGerirCliente.Location = new Point(12, 18);
            lblGerirCliente.Name = "lblGerirCliente";
            lblGerirCliente.Size = new Size(131, 28);
            lblGerirCliente.TabIndex = 0;
            lblGerirCliente.Text = "Gerir Cliente";
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(12, 55);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(653, 245);
            dgvCliente.TabIndex = 1;
            // 
            // btnIncluir
            // 
            btnIncluir.AutoSize = true;
            btnIncluir.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnIncluir.Location = new Point(26, 324);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(157, 38);
            btnIncluir.TabIndex = 2;
            btnIncluir.Text = "Incluir Cliente";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.AutoSize = true;
            btnAlterar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(262, 324);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(157, 38);
            btnAlterar.TabIndex = 3;
            btnAlterar.Text = "Alterar Cliente";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = true;
            btnExcluir.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Location = new Point(491, 324);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(157, 38);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir Cliente";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(471, 26);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(157, 23);
            txbBuscar.TabIndex = 5;
            txbBuscar.KeyDown += txbBuscar_KeyDown;
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(634, 26);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(31, 23);
            btnBusca.TabIndex = 6;
            btnBusca.Text = "B";
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(423, 31);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(48, 15);
            lblBuscar.TabIndex = 7;
            lblBuscar.Text = "Buscar :";
            // 
            // frmGerirClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 383);
            Controls.Add(lblBuscar);
            Controls.Add(btnBusca);
            Controls.Add(txbBuscar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(dgvCliente);
            Controls.Add(lblGerirCliente);
            Name = "frmGerirClientes";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerir Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGerirCliente;
        private DataGridView dgvCliente;
        private Button btnIncluir;
        private Button btnAlterar;
        private Button btnExcluir;
        private TextBox txbBuscar;
        private Button btnBusca;
        private Label lblBuscar;
    }
}