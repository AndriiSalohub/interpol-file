namespace InterpolFile.Controls
{
    partial class UC_Archive
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
            this.archiveList = new System.Windows.Forms.ListView();
            this.fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hair = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eyes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.h = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.something = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prof = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.langs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.placeOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.archiveTitle = new System.Windows.Forms.Label();
            this.sortArchiveButton = new System.Windows.Forms.Button();
            this.archiveSortOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.searchArchiveButton = new System.Windows.Forms.Button();
            this.searchArchiveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // archiveList
            // 
            this.archiveList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.archiveList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fullName,
            this.hair,
            this.eyes,
            this.h,
            this.alies,
            this.something,
            this.prof,
            this.crime,
            this.langs,
            this.location,
            this.birthDate,
            this.placeOfBirth});
            this.archiveList.FullRowSelect = true;
            this.archiveList.HideSelection = false;
            this.archiveList.Location = new System.Drawing.Point(18, 192);
            this.archiveList.Margin = new System.Windows.Forms.Padding(2);
            this.archiveList.MultiSelect = false;
            this.archiveList.Name = "archiveList";
            this.archiveList.Size = new System.Drawing.Size(1465, 545);
            this.archiveList.TabIndex = 106;
            this.archiveList.UseCompatibleStateImageBehavior = false;
            this.archiveList.View = System.Windows.Forms.View.Details;
            this.archiveList.DoubleClick += new System.EventHandler(this.archiveList_DoubleClick);
            this.archiveList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.archiveList_KeyUp);
            // 
            // fullName
            // 
            this.fullName.Text = "Ім\'я та Прізвище";
            this.fullName.Width = 150;
            // 
            // hair
            // 
            this.hair.Text = "Колір волосся";
            this.hair.Width = 125;
            // 
            // eyes
            // 
            this.eyes.Text = "Колір очей";
            this.eyes.Width = 95;
            // 
            // h
            // 
            this.h.Text = "Зріст";
            this.h.Width = 55;
            // 
            // alies
            // 
            this.alies.Text = "Кличка";
            this.alies.Width = 67;
            // 
            // something
            // 
            this.something.DisplayIndex = 8;
            this.something.Text = "Особливі прикмети";
            this.something.Width = 170;
            // 
            // prof
            // 
            this.prof.DisplayIndex = 5;
            this.prof.Text = "Професія";
            this.prof.Width = 95;
            // 
            // crime
            // 
            this.crime.DisplayIndex = 9;
            this.crime.Text = "Остання справа";
            this.crime.Width = 145;
            // 
            // langs
            // 
            this.langs.DisplayIndex = 10;
            this.langs.Text = "Мови";
            this.langs.Width = 55;
            // 
            // location
            // 
            this.location.DisplayIndex = 11;
            this.location.Text = "Місцезнаходження";
            this.location.Width = 170;
            // 
            // birthDate
            // 
            this.birthDate.DisplayIndex = 6;
            this.birthDate.Text = "Дата народження";
            this.birthDate.Width = 160;
            // 
            // placeOfBirth
            // 
            this.placeOfBirth.DisplayIndex = 7;
            this.placeOfBirth.Text = "Місце народження";
            this.placeOfBirth.Width = 170;
            // 
            // archiveTitle
            // 
            this.archiveTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.archiveTitle.AutoSize = true;
            this.archiveTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archiveTitle.Location = new System.Drawing.Point(711, 70);
            this.archiveTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.archiveTitle.Name = "archiveTitle";
            this.archiveTitle.Size = new System.Drawing.Size(78, 28);
            this.archiveTitle.TabIndex = 107;
            this.archiveTitle.Text = "Архів";
            // 
            // sortArchiveButton
            // 
            this.sortArchiveButton.Location = new System.Drawing.Point(990, 129);
            this.sortArchiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.sortArchiveButton.Name = "sortArchiveButton";
            this.sortArchiveButton.Size = new System.Drawing.Size(106, 29);
            this.sortArchiveButton.TabIndex = 111;
            this.sortArchiveButton.Text = "Сортувати";
            this.sortArchiveButton.UseVisualStyleBackColor = true;
            this.sortArchiveButton.Click += new System.EventHandler(this.sortArchiveButton_Click);
            // 
            // archiveSortOptionsComboBox
            // 
            this.archiveSortOptionsComboBox.FormattingEnabled = true;
            this.archiveSortOptionsComboBox.Items.AddRange(new object[] {
            "Виберіть сортування",
            "Ім\'я",
            "Прізвище",
            "Зріст",
            "Вік"});
            this.archiveSortOptionsComboBox.Location = new System.Drawing.Point(784, 129);
            this.archiveSortOptionsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.archiveSortOptionsComboBox.Name = "archiveSortOptionsComboBox";
            this.archiveSortOptionsComboBox.Size = new System.Drawing.Size(202, 29);
            this.archiveSortOptionsComboBox.TabIndex = 110;
            this.archiveSortOptionsComboBox.Text = "Виберіть сортування";
            this.archiveSortOptionsComboBox.SelectedIndexChanged += new System.EventHandler(this.archiveSortOptionsComboBox_SelectedIndexChanged);
            // 
            // searchArchiveButton
            // 
            this.searchArchiveButton.Location = new System.Drawing.Point(691, 129);
            this.searchArchiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchArchiveButton.Name = "searchArchiveButton";
            this.searchArchiveButton.Size = new System.Drawing.Size(81, 29);
            this.searchArchiveButton.TabIndex = 109;
            this.searchArchiveButton.Text = "Пошук";
            this.searchArchiveButton.UseVisualStyleBackColor = true;
            this.searchArchiveButton.Click += new System.EventHandler(this.searchArchiveButton_Click);
            // 
            // searchArchiveTextBox
            // 
            this.searchArchiveTextBox.Location = new System.Drawing.Point(404, 129);
            this.searchArchiveTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchArchiveTextBox.Name = "searchArchiveTextBox";
            this.searchArchiveTextBox.Size = new System.Drawing.Size(283, 27);
            this.searchArchiveTextBox.TabIndex = 108;
            // 
            // UC_Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sortArchiveButton);
            this.Controls.Add(this.archiveSortOptionsComboBox);
            this.Controls.Add(this.searchArchiveButton);
            this.Controls.Add(this.searchArchiveTextBox);
            this.Controls.Add(this.archiveTitle);
            this.Controls.Add(this.archiveList);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "UC_Archive";
            this.Size = new System.Drawing.Size(1500, 970);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView archiveList;
        private System.Windows.Forms.ColumnHeader fullName;
        private System.Windows.Forms.ColumnHeader hair;
        private System.Windows.Forms.ColumnHeader eyes;
        private System.Windows.Forms.ColumnHeader h;
        private System.Windows.Forms.ColumnHeader alies;
        private System.Windows.Forms.ColumnHeader something;
        private System.Windows.Forms.ColumnHeader prof;
        private System.Windows.Forms.ColumnHeader crime;
        private System.Windows.Forms.ColumnHeader langs;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader birthDate;
        private System.Windows.Forms.ColumnHeader placeOfBirth;
        private System.Windows.Forms.Label archiveTitle;
        private System.Windows.Forms.Button sortArchiveButton;
        private System.Windows.Forms.ComboBox archiveSortOptionsComboBox;
        private System.Windows.Forms.Button searchArchiveButton;
        private System.Windows.Forms.TextBox searchArchiveTextBox;
    }
}
