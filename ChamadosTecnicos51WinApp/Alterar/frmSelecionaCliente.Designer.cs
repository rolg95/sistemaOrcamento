namespace Forms.Alterar
{
    partial class frmSelecionaCliente
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
            dgvSelecionaCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSelecionaCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvSelecionaCliente
            // 
            dgvSelecionaCliente.AllowUserToAddRows = false;
            dgvSelecionaCliente.AllowUserToDeleteRows = false;
            dgvSelecionaCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSelecionaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSelecionaCliente.Cursor = Cursors.Hand;
            dgvSelecionaCliente.EnableHeadersVisualStyles = false;
            dgvSelecionaCliente.Location = new Point(9, 13);
            dgvSelecionaCliente.Name = "dgvSelecionaCliente";
            dgvSelecionaCliente.ReadOnly = true;
            dgvSelecionaCliente.RowHeadersVisible = false;
            dgvSelecionaCliente.RowTemplate.Height = 25;
            dgvSelecionaCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSelecionaCliente.Size = new Size(436, 323);
            dgvSelecionaCliente.TabIndex = 0;
            dgvSelecionaCliente.DoubleClick += dgvSelecionaCliente_DoubleClick;
            // 
            // frmSelecionaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 348);
            Controls.Add(dgvSelecionaCliente);
            Name = "frmSelecionaCliente";
            ShowIcon = false;
            Text = "Selecione um Cliente";
            Load += frmSelecionaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSelecionaCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSelecionaCliente;
    }
}