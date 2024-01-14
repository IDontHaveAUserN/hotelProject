namespace hotel
{
    partial class Vmain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recursosHumanosToolStripMenuItem,
            this.hospedeToolStripMenuItem,
            this.recepçãoToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioMenuItem});
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.recursosHumanosToolStripMenuItem.Text = "Recursos Humanos";
            // 
            // usuarioMenuItem
            // 
            this.usuarioMenuItem.Name = "usuarioMenuItem";
            this.usuarioMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuarioMenuItem.Text = "Usuários";
            this.usuarioMenuItem.Click += new System.EventHandler(this.hosMenuUsuario_Click);
            // 
            // hospedeToolStripMenuItem
            // 
            this.hospedeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hosMenuItem,
            this.quartosMenuItem});
            this.hospedeToolStripMenuItem.Name = "hospedeToolStripMenuItem";
            this.hospedeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.hospedeToolStripMenuItem.Text = "Secretária";
            // 
            // hosMenuItem
            // 
            this.hosMenuItem.Name = "hosMenuItem";
            this.hosMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hosMenuItem.Text = "Hospedes";
            this.hosMenuItem.Click += new System.EventHandler(this.hosMenuItem_Click);
            // 
            // quartosMenuItem
            // 
            this.quartosMenuItem.Name = "quartosMenuItem";
            this.quartosMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quartosMenuItem.Text = "Quartos";
            this.quartosMenuItem.Click += new System.EventHandler(this.quartosMenuItem_Click);
            // 
            // recepçãoToolStripMenuItem
            // 
            this.recepçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaMenuItem});
            this.recepçãoToolStripMenuItem.Name = "recepçãoToolStripMenuItem";
            this.recepçãoToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.recepçãoToolStripMenuItem.Text = "Recepção";
            // 
            // reservaMenuItem
            // 
            this.reservaMenuItem.Name = "reservaMenuItem";
            this.reservaMenuItem.Size = new System.Drawing.Size(149, 26);
            this.reservaMenuItem.Text = "Reservas";
            this.reservaMenuItem.Click += new System.EventHandler(this.reservaMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // Vmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 663);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaMenuItem;
    }
}

