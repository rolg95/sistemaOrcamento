namespace Forms
{
    partial class frmTecnicoAdicionar
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
            lblCadTecnico = new Label();
            txbNome = new TextBox();
            lbNome = new Label();
            txbEspecialidade = new TextBox();
            lblEspecialidade = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblCadTecnico
            // 
            lblCadTecnico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCadTecnico.AutoSize = true;
            lblCadTecnico.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCadTecnico.Location = new Point(131, 9);
            lblCadTecnico.Name = "lblCadTecnico";
            lblCadTecnico.Size = new Size(83, 28);
            lblCadTecnico.TabIndex = 1;
            lblCadTecnico.Text = "Técnico";
            // 
            // txbNome
            // 
            txbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNome.Location = new Point(12, 59);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(329, 23);
            txbNome.TabIndex = 4;
            // 
            // lbNome
            // 
            lbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbNome.AutoSize = true;
            lbNome.Location = new Point(11, 41);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome";
            // 
            // txbEspecialidade
            // 
            txbEspecialidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbEspecialidade.Location = new Point(12, 110);
            txbEspecialidade.Name = "txbEspecialidade";
            txbEspecialidade.Size = new Size(329, 23);
            txbEspecialidade.TabIndex = 6;
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEspecialidade.AutoSize = true;
            lblEspecialidade.Location = new Point(11, 92);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(78, 15);
            lblEspecialidade.TabIndex = 5;
            lblEspecialidade.Text = "Especialidade";
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalvar.Location = new Point(139, 151);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TecnicoAdicionarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(351, 193);
            Controls.Add(btnSalvar);
            Controls.Add(txbEspecialidade);
            Controls.Add(lblEspecialidade);
            Controls.Add(txbNome);
            Controls.Add(lbNome);
            Controls.Add(lblCadTecnico);
            Name = "TecnicoAdicionarForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Técnico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadTecnico;
        private TextBox txbNome;
        private Label lbNome;
        private TextBox txbEspecialidade;
        private Label lblEspecialidade;
        private Button btnSalvar;
    }
}