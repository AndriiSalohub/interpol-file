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
            this.footerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(67)))));
            this.navigationPanel.Controls.Add(this.archiveButton);
            this.navigationPanel.Controls.Add(this.criminalsButton);
            this.navigationPanel.Controls.Add(this.homeButton);
            this.navigationPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navigationPanel.ForeColor = System.Drawing.Color.White;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(804, 80);
            this.navigationPanel.TabIndex = 0;
            // 
            // archiveButton
            // 
            this.archiveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.archiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiveButton.Location = new System.Drawing.Point(325, 13);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(155, 55);
            this.archiveButton.TabIndex = 2;
            this.archiveButton.Text = "Список Злочинців";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // criminalsButton
            // 
            this.criminalsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.criminalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criminalsButton.Location = new System.Drawing.Point(516, 13);
            this.criminalsButton.Name = "criminalsButton";
            this.criminalsButton.Size = new System.Drawing.Size(155, 55);
            this.criminalsButton.TabIndex = 3;
            this.criminalsButton.Text = "Архів";
            this.criminalsButton.UseVisualStyleBackColor = true;
            this.criminalsButton.Click += new System.EventHandler(this.criminalsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(134, 13);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(155, 55);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Домашня Сторінка";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // footerPanel
            // 
            this.footerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(67)))));
            this.footerPanel.Controls.Add(this.label1);
            this.footerPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerPanel.ForeColor = System.Drawing.Color.White;
            this.footerPanel.Location = new System.Drawing.Point(0, 391);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(804, 65);
            this.footerPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created by Andrii Salohub";
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(804, 456);
            this.containerPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 456);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.containerPanel);
            this.MinimumSize = new System.Drawing.Size(600, 420);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.navigationPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button criminalsButton;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel containerPanel;
    }
}

