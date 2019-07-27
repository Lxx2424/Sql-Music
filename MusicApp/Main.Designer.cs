namespace MusicApp
{
    partial class Main
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.ForestGreen;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.showToolStripMenuItem,
            this.favoriteToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem,
            this.genresToolStripMenuItem});
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.MusicToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genresToolStripMenuItem.Text = "Genres";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem1,
            this.genresToolStripMenuItem1});
            this.showToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // favoriteToolStripMenuItem
            // 
            this.favoriteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.favoriteToolStripMenuItem.Name = "favoriteToolStripMenuItem";
            this.favoriteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.favoriteToolStripMenuItem.Text = "Favorite";
            // 
            // musicToolStripMenuItem1
            // 
            this.musicToolStripMenuItem1.Name = "musicToolStripMenuItem1";
            this.musicToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.musicToolStripMenuItem1.Text = "Music";
            // 
            // genresToolStripMenuItem1
            // 
            this.genresToolStripMenuItem1.Name = "genresToolStripMenuItem1";
            this.genresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.genresToolStripMenuItem1.Text = "Genres";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem;
    }
}