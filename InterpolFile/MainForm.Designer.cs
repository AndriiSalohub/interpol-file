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
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.archiveButton = new System.Windows.Forms.Button();
            this.criminalsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(67)))));
            this.navigationPanel.Controls.Add(this.archiveButton);
            this.navigationPanel.Controls.Add(this.criminalsButton);
            this.navigationPanel.Controls.Add(this.homeButton);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navigationPanel.ForeColor = System.Drawing.Color.White;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1254, 80);
            this.navigationPanel.TabIndex = 0;
            // 
            // archiveButton
            // 
            this.archiveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.archiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiveButton.Location = new System.Drawing.Point(741, 13);
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
            this.criminalsButton.Location = new System.Drawing.Point(550, 13);
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
            this.homeButton.Location = new System.Drawing.Point(359, 13);
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
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1254, 931);
            this.containerPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 931);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.containerPanel);
            this.MinimumSize = new System.Drawing.Size(1270, 970);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button criminalsButton;
        private System.Windows.Forms.Panel containerPanel;
    }
}

