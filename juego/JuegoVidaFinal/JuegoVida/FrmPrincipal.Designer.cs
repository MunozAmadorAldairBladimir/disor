namespace JuegoVida
{
    partial class frmPrincipal
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reglasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglas1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglas2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglas3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reglasToolStripMenuItem,
            this.ejecutarToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reglasToolStripMenuItem
            // 
            this.reglasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reglas1ToolStripMenuItem,
            this.reglas2ToolStripMenuItem,
            this.reglas3ToolStripMenuItem});
            this.reglasToolStripMenuItem.Name = "reglasToolStripMenuItem";
            this.reglasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.reglasToolStripMenuItem.Text = "Reglas";
            // 
            // reglas1ToolStripMenuItem
            // 
            this.reglas1ToolStripMenuItem.Checked = true;
            this.reglas1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reglas1ToolStripMenuItem.Name = "reglas1ToolStripMenuItem";
            this.reglas1ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.reglas1ToolStripMenuItem.Text = "Reglas 23/3";
            this.reglas1ToolStripMenuItem.Click += new System.EventHandler(this.reglas1ToolStripMenuItem_Click);
            // 
            // reglas2ToolStripMenuItem
            // 
            this.reglas2ToolStripMenuItem.Name = "reglas2ToolStripMenuItem";
            this.reglas2ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.reglas2ToolStripMenuItem.Text = "Reglas 34/34";
            this.reglas2ToolStripMenuItem.Click += new System.EventHandler(this.reglas2ToolStripMenuItem_Click);
            // 
            // reglas3ToolStripMenuItem
            // 
            this.reglas3ToolStripMenuItem.Name = "reglas3ToolStripMenuItem";
            this.reglas3ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.reglas3ToolStripMenuItem.Text = "Reglas 1358/357";
            this.reglas3ToolStripMenuItem.Click += new System.EventHandler(this.reglas3ToolStripMenuItem_Click);
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem});
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 415);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Juego de la Vida C#";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPrincipal_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reglasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglas1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglas2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglas3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
    }
}

