using System.Drawing;

namespace InterpolFile
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.divider = new System.Windows.Forms.Panel();
            this.archiveButton = new System.Windows.Forms.Button();
            this.criminalsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.openAs = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationPanel.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(67)))));
            this.navigationPanel.Controls.Add(this.divider);
            this.navigationPanel.Controls.Add(this.archiveButton);
            this.navigationPanel.Controls.Add(this.criminalsButton);
            this.navigationPanel.Controls.Add(this.homeButton);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navigationPanel.ForeColor = System.Drawing.Color.White;
            this.navigationPanel.Location = new System.Drawing.Point(0, 27);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1534, 80);
            this.navigationPanel.TabIndex = 3;
            // 
            // divider
            // 
            this.divider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider.BackColor = System.Drawing.Color.MidnightBlue;
            this.divider.Location = new System.Drawing.Point(0, 0);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(1534, 2);
            this.divider.TabIndex = 0;
            // 
            // archiveButton
            // 
            this.archiveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.archiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiveButton.Location = new System.Drawing.Point(881, 13);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(155, 55);
            this.archiveButton.TabIndex = 3;
            this.archiveButton.Text = "Архів";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // criminalsButton
            // 
            this.criminalsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.criminalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criminalsButton.Location = new System.Drawing.Point(690, 13);
            this.criminalsButton.Name = "criminalsButton";
            this.criminalsButton.Size = new System.Drawing.Size(155, 55);
            this.criminalsButton.TabIndex = 2;
            this.criminalsButton.Text = "Список Злочинців";
            this.criminalsButton.UseVisualStyleBackColor = true;
            this.criminalsButton.Click += new System.EventHandler(this.criminalsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(499, 13);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(155, 55);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Домашня Сторінка";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 107);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1534, 824);
            this.containerPanel.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openAs,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAs,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.fileToolStripMenuItem_DropDownClosed);
            this.fileToolStripMenuItem.DropDownOpened += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpened);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.DropDownClosed += new System.EventHandler(this.helpToolStripMenuItem_DropDownClosed);
            this.helpToolStripMenuItem.DropDownOpened += new System.EventHandler(this.helpToolStripMenuItem_DropDownOpened);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(55)))));
            this.menu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(1534, 27);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(180, 22);
            this.saveAs.Text = "Save as";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // openAs
            // 
            this.openAs.Name = "openAs";
            this.openAs.Size = new System.Drawing.Size(180, 22);
            this.openAs.Text = "Open as";
            this.openAs.Click += new System.EventHandler(this.openAs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 931);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(1500, 970);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.navigationPanel.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button criminalsButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem openAs;
    }
}

