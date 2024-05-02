namespace InterpolFile.Controls
{
    partial class UC_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(468, 438);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(332, 36);
            this.title.TabIndex = 1;
            this.title.Text = "Картотека Інтерполу";
            // 
            // subtitle
            // 
            this.subtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subtitle.Font = new System.Drawing.Font("Century Gothic", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtitle.Location = new System.Drawing.Point(471, 474);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(329, 78);
            this.subtitle.TabIndex = 2;
            this.subtitle.Text = " Застосунок призначений для зберігання та обробки інформації про злочинців";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1270, 970);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subtitle;
    }
}
