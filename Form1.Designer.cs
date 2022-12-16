namespace gitForm
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
            this.git1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.git2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.git3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.git1ToolStripMenuItem,
            this.git2ToolStripMenuItem,
            this.git3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // git1ToolStripMenuItem
            // 
            this.git1ToolStripMenuItem.Name = "git1ToolStripMenuItem";
            this.git1ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.git1ToolStripMenuItem.Text = "git1";
            // 
            // git2ToolStripMenuItem
            // 
            this.git2ToolStripMenuItem.Name = "git2ToolStripMenuItem";
            this.git2ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.git2ToolStripMenuItem.Text = "git2";
            // 
            // git3ToolStripMenuItem
            // 
            this.git3ToolStripMenuItem.Name = "git3ToolStripMenuItem";
            this.git3ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.git3ToolStripMenuItem.Text = "git3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
        private System.Windows.Forms.ToolStripMenuItem git1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem git2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem git3ToolStripMenuItem;
    }
}

