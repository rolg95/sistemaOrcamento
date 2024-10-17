namespace Forms
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            lblSobre = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblSobre
            // 
            lblSobre.AutoSize = true;
            lblSobre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSobre.Location = new Point(12, 50);
            lblSobre.Name = "lblSobre";
            lblSobre.Size = new Size(3050, 21);
            lblSobre.TabIndex = 0;
            lblSobre.Text = resources.GetString("lblSobre.Text");
            // 
            // frmSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 223);
            Controls.Add(lblSobre);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmSobre";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre";
            Load += Sobre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSobre;
        private System.Windows.Forms.Timer timer1;
    }
}