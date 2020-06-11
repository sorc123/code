namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spiskoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poAranzmanimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poRezervacijamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.spiskoviToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.destinacijeToolStripMenuItem,
            this.klijentiToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // destinacijeToolStripMenuItem
            // 
            this.destinacijeToolStripMenuItem.Name = "destinacijeToolStripMenuItem";
            this.destinacijeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.destinacijeToolStripMenuItem.Text = "Destinacije";
            this.destinacijeToolStripMenuItem.Click += new System.EventHandler(this.destinacijeToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            this.klijentiToolStripMenuItem.Click += new System.EventHandler(this.klijentiToolStripMenuItem_Click);
            // 
            // spiskoviToolStripMenuItem
            // 
            this.spiskoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poAranzmanimaToolStripMenuItem,
            this.poRezervacijamaToolStripMenuItem});
            this.spiskoviToolStripMenuItem.Name = "spiskoviToolStripMenuItem";
            this.spiskoviToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.spiskoviToolStripMenuItem.Text = "Spiskovi";
            // 
            // poAranzmanimaToolStripMenuItem
            // 
            this.poAranzmanimaToolStripMenuItem.Name = "poAranzmanimaToolStripMenuItem";
            this.poAranzmanimaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poAranzmanimaToolStripMenuItem.Text = "Po aranzmanima";
            this.poAranzmanimaToolStripMenuItem.Click += new System.EventHandler(this.poAranzmanimaToolStripMenuItem_Click);
            // 
            // poRezervacijamaToolStripMenuItem
            // 
            this.poRezervacijamaToolStripMenuItem.Name = "poRezervacijamaToolStripMenuItem";
            this.poRezervacijamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poRezervacijamaToolStripMenuItem.Text = "Po rezervacijama";
            this.poRezervacijamaToolStripMenuItem.Click += new System.EventHandler(this.poRezervacijamaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krajToolStripMenuItem});
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.krajToolStripMenuItem.Text = "Kraj";
            this.krajToolStripMenuItem.Click += new System.EventHandler(this.krajToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spiskoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poAranzmanimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poRezervacijamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
    }
}

