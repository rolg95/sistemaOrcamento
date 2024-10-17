namespace Forms
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            técnicosToolStripMenuItem = new ToolStripMenuItem();
            gestorToolStripMenuItem = new ToolStripMenuItem();
            gestorDeClientesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            documentaçãoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            fecharSoluçãoToolStripMenuItem = new ToolStripMenuItem();
            paginasAbertasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.GradientActiveCaption;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, gestorToolStripMenuItem, gestorDeClientesToolStripMenuItem, calculadoraToolStripMenuItem, documentaçãoToolStripMenuItem, sobreToolStripMenuItem, fecharSoluçãoToolStripMenuItem, paginasAbertasToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.MdiWindowListItem = paginasAbertasToolStripMenuItem;
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(914, 30);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "Menu Strip";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, técnicosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
            clienteToolStripMenuItem.Size = new Size(224, 26);
            clienteToolStripMenuItem.Text = "Clientes";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // técnicosToolStripMenuItem
            // 
            técnicosToolStripMenuItem.Name = "técnicosToolStripMenuItem";
            técnicosToolStripMenuItem.Size = new Size(224, 26);
            técnicosToolStripMenuItem.Text = "Técnicos";
            técnicosToolStripMenuItem.Click += técnicosToolStripMenuItem_Click;
            // 
            // gestorToolStripMenuItem
            // 
            gestorToolStripMenuItem.Name = "gestorToolStripMenuItem";
            gestorToolStripMenuItem.Size = new Size(171, 24);
            gestorToolStripMenuItem.Text = "Gestor de Orçamentos";
            gestorToolStripMenuItem.Click += gestorToolStripMenuItem_Click;
            // 
            // gestorDeClientesToolStripMenuItem
            // 
            gestorDeClientesToolStripMenuItem.Name = "gestorDeClientesToolStripMenuItem";
            gestorDeClientesToolStripMenuItem.Size = new Size(143, 24);
            gestorDeClientesToolStripMenuItem.Text = "Gestor de Clientes";
            gestorDeClientesToolStripMenuItem.Click += gestorDeClientesToolStripMenuItem_Click;
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(102, 24);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // documentaçãoToolStripMenuItem
            // 
            documentaçãoToolStripMenuItem.Name = "documentaçãoToolStripMenuItem";
            documentaçãoToolStripMenuItem.Size = new Size(124, 24);
            documentaçãoToolStripMenuItem.Text = "Documentação";
            documentaçãoToolStripMenuItem.Click += documentaçãoToolStripMenuItem_Click_1;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            sobreToolStripMenuItem.Size = new Size(62, 24);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // fecharSoluçãoToolStripMenuItem
            // 
            fecharSoluçãoToolStripMenuItem.Name = "fecharSoluçãoToolStripMenuItem";
            fecharSoluçãoToolStripMenuItem.Size = new Size(123, 24);
            fecharSoluçãoToolStripMenuItem.Text = "Fechar Solução";
            fecharSoluçãoToolStripMenuItem.Click += fecharSoluçãoToolStripMenuItem_Click;
            // 
            // paginasAbertasToolStripMenuItem
            // 
            paginasAbertasToolStripMenuItem.Name = "paginasAbertasToolStripMenuItem";
            paginasAbertasToolStripMenuItem.Size = new Size(128, 24);
            paginasAbertasToolStripMenuItem.Text = "Paginas Abertas";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Orçamento";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem gestorToolStripMenuItem;
        private ToolStripMenuItem gestorDeClientesToolStripMenuItem;
        private ToolStripMenuItem fecharSoluçãoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem técnicosToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem documentaçãoToolStripMenuItem;
        private ToolStripMenuItem paginasAbertasToolStripMenuItem;
    }
}