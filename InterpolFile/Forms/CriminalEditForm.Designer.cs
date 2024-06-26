﻿namespace InterpolFile.Forms
{
    partial class CriminalEditForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.criminalFormPanel = new System.Windows.Forms.Panel();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastPlaceErrorLabel = new System.Windows.Forms.Label();
            this.languagesErrorLabel = new System.Windows.Forms.Label();
            this.lastCrimeErrorLabel = new System.Windows.Forms.Label();
            this.eyesColorErrorLabel = new System.Windows.Forms.Label();
            this.professionErrorLabel = new System.Windows.Forms.Label();
            this.distinguishingFeaturesErrorLabel = new System.Windows.Forms.Label();
            this.aliasErrorLabel = new System.Windows.Forms.Label();
            this.hairColorErrorLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.birthPlaceErrorLabel = new System.Windows.Forms.Label();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.firstName = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.lastKnownPlace = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastKnownPlaceTextBox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.languagesTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.languages = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.lastCrime = new System.Windows.Forms.Label();
            this.lastCrimeTextBox = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.Label();
            this.professionTextBox = new System.Windows.Forms.TextBox();
            this.proffesion = new System.Windows.Forms.Label();
            this.hairColor = new System.Windows.Forms.Label();
            this.distinguishingFeaturesTextBox = new System.Windows.Forms.TextBox();
            this.hairColorTextBox = new System.Windows.Forms.TextBox();
            this.distinguishingFeatures = new System.Windows.Forms.Label();
            this.birthPlaceTextBox = new System.Windows.Forms.TextBox();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.birthPlace = new System.Windows.Forms.Label();
            this.alias = new System.Windows.Forms.Label();
            this.eyesColor = new System.Windows.Forms.Label();
            this.eyesColorTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.backFromArchiveButton = new System.Windows.Forms.Button();
            this.imageLabel = new System.Windows.Forms.Label();
            this.criminalImage = new System.Windows.Forms.PictureBox();
            this.criminalFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitButton.Location = new System.Drawing.Point(757, 280);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(130, 35);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Ok";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(893, 280);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 35);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // criminalFormPanel
            // 
            this.criminalFormPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.criminalFormPanel.Controls.Add(this.birthDateTimePicker);
            this.criminalFormPanel.Controls.Add(this.lastPlaceErrorLabel);
            this.criminalFormPanel.Controls.Add(this.languagesErrorLabel);
            this.criminalFormPanel.Controls.Add(this.lastCrimeErrorLabel);
            this.criminalFormPanel.Controls.Add(this.eyesColorErrorLabel);
            this.criminalFormPanel.Controls.Add(this.professionErrorLabel);
            this.criminalFormPanel.Controls.Add(this.distinguishingFeaturesErrorLabel);
            this.criminalFormPanel.Controls.Add(this.aliasErrorLabel);
            this.criminalFormPanel.Controls.Add(this.hairColorErrorLabel);
            this.criminalFormPanel.Controls.Add(this.firstNameErrorLabel);
            this.criminalFormPanel.Controls.Add(this.birthPlaceErrorLabel);
            this.criminalFormPanel.Controls.Add(this.heightUpDown);
            this.criminalFormPanel.Controls.Add(this.firstName);
            this.criminalFormPanel.Controls.Add(this.lastNameErrorLabel);
            this.criminalFormPanel.Controls.Add(this.lastKnownPlace);
            this.criminalFormPanel.Controls.Add(this.firstNameTextBox);
            this.criminalFormPanel.Controls.Add(this.lastKnownPlaceTextBox);
            this.criminalFormPanel.Controls.Add(this.lastName);
            this.criminalFormPanel.Controls.Add(this.languagesTextBox);
            this.criminalFormPanel.Controls.Add(this.lastNameTextBox);
            this.criminalFormPanel.Controls.Add(this.languages);
            this.criminalFormPanel.Controls.Add(this.height);
            this.criminalFormPanel.Controls.Add(this.lastCrime);
            this.criminalFormPanel.Controls.Add(this.lastCrimeTextBox);
            this.criminalFormPanel.Controls.Add(this.birth);
            this.criminalFormPanel.Controls.Add(this.professionTextBox);
            this.criminalFormPanel.Controls.Add(this.proffesion);
            this.criminalFormPanel.Controls.Add(this.hairColor);
            this.criminalFormPanel.Controls.Add(this.distinguishingFeaturesTextBox);
            this.criminalFormPanel.Controls.Add(this.hairColorTextBox);
            this.criminalFormPanel.Controls.Add(this.distinguishingFeatures);
            this.criminalFormPanel.Controls.Add(this.birthPlaceTextBox);
            this.criminalFormPanel.Controls.Add(this.aliasTextBox);
            this.criminalFormPanel.Controls.Add(this.birthPlace);
            this.criminalFormPanel.Controls.Add(this.alias);
            this.criminalFormPanel.Controls.Add(this.eyesColor);
            this.criminalFormPanel.Controls.Add(this.eyesColorTextBox);
            this.criminalFormPanel.Location = new System.Drawing.Point(13, 12);
            this.criminalFormPanel.Name = "criminalFormPanel";
            this.criminalFormPanel.Size = new System.Drawing.Size(763, 262);
            this.criminalFormPanel.TabIndex = 33;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateTimePicker.Location = new System.Drawing.Point(178, 93);
            this.birthDateTimePicker.MaxDate = new System.DateTime(2006, 6, 8, 0, 0, 0, 0);
            this.birthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(199, 27);
            this.birthDateTimePicker.TabIndex = 9;
            this.birthDateTimePicker.Value = new System.DateTime(2006, 6, 1, 0, 0, 0, 0);
            // 
            // lastPlaceErrorLabel
            // 
            this.lastPlaceErrorLabel.AutoSize = true;
            this.lastPlaceErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastPlaceErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastPlaceErrorLabel.Location = new System.Drawing.Point(741, 224);
            this.lastPlaceErrorLabel.Name = "lastPlaceErrorLabel";
            this.lastPlaceErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.lastPlaceErrorLabel.TabIndex = 40;
            this.lastPlaceErrorLabel.Text = "x";
            this.lastPlaceErrorLabel.Visible = false;
            // 
            // languagesErrorLabel
            // 
            this.languagesErrorLabel.AutoSize = true;
            this.languagesErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languagesErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.languagesErrorLabel.Location = new System.Drawing.Point(270, 223);
            this.languagesErrorLabel.Name = "languagesErrorLabel";
            this.languagesErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.languagesErrorLabel.TabIndex = 34;
            this.languagesErrorLabel.Text = "x";
            this.languagesErrorLabel.Visible = false;
            // 
            // lastCrimeErrorLabel
            // 
            this.lastCrimeErrorLabel.AutoSize = true;
            this.lastCrimeErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastCrimeErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastCrimeErrorLabel.Location = new System.Drawing.Point(741, 182);
            this.lastCrimeErrorLabel.Name = "lastCrimeErrorLabel";
            this.lastCrimeErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.lastCrimeErrorLabel.TabIndex = 34;
            this.lastCrimeErrorLabel.Text = "x";
            this.lastCrimeErrorLabel.Visible = false;
            // 
            // eyesColorErrorLabel
            // 
            this.eyesColorErrorLabel.AutoSize = true;
            this.eyesColorErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eyesColorErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eyesColorErrorLabel.Location = new System.Drawing.Point(537, 58);
            this.eyesColorErrorLabel.Name = "eyesColorErrorLabel";
            this.eyesColorErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.eyesColorErrorLabel.TabIndex = 34;
            this.eyesColorErrorLabel.Text = "x";
            this.eyesColorErrorLabel.Visible = false;
            // 
            // professionErrorLabel
            // 
            this.professionErrorLabel.AutoSize = true;
            this.professionErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.professionErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.professionErrorLabel.Location = new System.Drawing.Point(303, 182);
            this.professionErrorLabel.Name = "professionErrorLabel";
            this.professionErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.professionErrorLabel.TabIndex = 39;
            this.professionErrorLabel.Text = "x";
            this.professionErrorLabel.Visible = false;
            // 
            // distinguishingFeaturesErrorLabel
            // 
            this.distinguishingFeaturesErrorLabel.AutoSize = true;
            this.distinguishingFeaturesErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distinguishingFeaturesErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.distinguishingFeaturesErrorLabel.Location = new System.Drawing.Point(741, 141);
            this.distinguishingFeaturesErrorLabel.Name = "distinguishingFeaturesErrorLabel";
            this.distinguishingFeaturesErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.distinguishingFeaturesErrorLabel.TabIndex = 38;
            this.distinguishingFeaturesErrorLabel.Text = "x";
            this.distinguishingFeaturesErrorLabel.Visible = false;
            // 
            // aliasErrorLabel
            // 
            this.aliasErrorLabel.AutoSize = true;
            this.aliasErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aliasErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.aliasErrorLabel.Location = new System.Drawing.Point(225, 141);
            this.aliasErrorLabel.Name = "aliasErrorLabel";
            this.aliasErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.aliasErrorLabel.TabIndex = 34;
            this.aliasErrorLabel.Text = "x";
            this.aliasErrorLabel.Visible = false;
            // 
            // hairColorErrorLabel
            // 
            this.hairColorErrorLabel.AutoSize = true;
            this.hairColorErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hairColorErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hairColorErrorLabel.Location = new System.Drawing.Point(278, 58);
            this.hairColorErrorLabel.Name = "hairColorErrorLabel";
            this.hairColorErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.hairColorErrorLabel.TabIndex = 35;
            this.hairColorErrorLabel.Text = "x";
            this.hairColorErrorLabel.Visible = false;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.firstNameErrorLabel.Location = new System.Drawing.Point(327, 18);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.firstNameErrorLabel.TabIndex = 33;
            this.firstNameErrorLabel.Text = "x";
            this.firstNameErrorLabel.Visible = false;
            // 
            // birthPlaceErrorLabel
            // 
            this.birthPlaceErrorLabel.AutoSize = true;
            this.birthPlaceErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthPlaceErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.birthPlaceErrorLabel.Location = new System.Drawing.Point(741, 100);
            this.birthPlaceErrorLabel.Name = "birthPlaceErrorLabel";
            this.birthPlaceErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.birthPlaceErrorLabel.TabIndex = 36;
            this.birthPlaceErrorLabel.Text = "x";
            this.birthPlaceErrorLabel.Visible = false;
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(608, 52);
            this.heightUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(127, 27);
            this.heightUpDown.TabIndex = 8;
            this.heightUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName.Location = new System.Drawing.Point(22, 14);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(43, 21);
            this.firstName.TabIndex = 4;
            this.firstName.Text = "Ім\'я:";
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastNameErrorLabel.Location = new System.Drawing.Point(741, 18);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.lastNameErrorLabel.TabIndex = 34;
            this.lastNameErrorLabel.Text = "x";
            this.lastNameErrorLabel.Visible = false;
            // 
            // lastKnownPlace
            // 
            this.lastKnownPlace.AutoSize = true;
            this.lastKnownPlace.Location = new System.Drawing.Point(288, 219);
            this.lastKnownPlace.Name = "lastKnownPlace";
            this.lastKnownPlace.Size = new System.Drawing.Size(239, 21);
            this.lastKnownPlace.TabIndex = 31;
            this.lastKnownPlace.Text = "Останнє місцезнаходження:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(71, 11);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(250, 27);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastKnownPlaceTextBox
            // 
            this.lastKnownPlaceTextBox.Location = new System.Drawing.Point(533, 217);
            this.lastKnownPlaceTextBox.Name = "lastKnownPlaceTextBox";
            this.lastKnownPlaceTextBox.Size = new System.Drawing.Size(202, 27);
            this.lastKnownPlaceTextBox.TabIndex = 15;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(360, 14);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(89, 21);
            this.lastName.TabIndex = 6;
            this.lastName.Text = "Прізвище:";
            // 
            // languagesTextBox
            // 
            this.languagesTextBox.Location = new System.Drawing.Point(83, 216);
            this.languagesTextBox.Name = "languagesTextBox";
            this.languagesTextBox.Size = new System.Drawing.Size(181, 27);
            this.languagesTextBox.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(455, 11);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(280, 27);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // languages
            // 
            this.languages.AutoSize = true;
            this.languages.Location = new System.Drawing.Point(21, 219);
            this.languages.Name = "languages";
            this.languages.Size = new System.Drawing.Size(56, 21);
            this.languages.TabIndex = 28;
            this.languages.Text = "Мови:";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(551, 55);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(53, 21);
            this.height.TabIndex = 8;
            this.height.Text = "Зріст:";
            // 
            // lastCrime
            // 
            this.lastCrime.AutoSize = true;
            this.lastCrime.Location = new System.Drawing.Point(323, 178);
            this.lastCrime.Name = "lastCrime";
            this.lastCrime.Size = new System.Drawing.Size(146, 21);
            this.lastCrime.TabIndex = 27;
            this.lastCrime.Text = "Остання справа:";
            // 
            // lastCrimeTextBox
            // 
            this.lastCrimeTextBox.Location = new System.Drawing.Point(476, 178);
            this.lastCrimeTextBox.Name = "lastCrimeTextBox";
            this.lastCrimeTextBox.Size = new System.Drawing.Size(259, 27);
            this.lastCrimeTextBox.TabIndex = 13;
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Location = new System.Drawing.Point(21, 96);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(157, 21);
            this.birth.TabIndex = 10;
            this.birth.Text = "Дата народження:";
            // 
            // professionTextBox
            // 
            this.professionTextBox.Location = new System.Drawing.Point(121, 175);
            this.professionTextBox.Name = "professionTextBox";
            this.professionTextBox.Size = new System.Drawing.Size(176, 27);
            this.professionTextBox.TabIndex = 12;
            // 
            // proffesion
            // 
            this.proffesion.AutoSize = true;
            this.proffesion.Location = new System.Drawing.Point(22, 178);
            this.proffesion.Name = "proffesion";
            this.proffesion.Size = new System.Drawing.Size(93, 21);
            this.proffesion.TabIndex = 24;
            this.proffesion.Text = "Професія:";
            // 
            // hairColor
            // 
            this.hairColor.AutoSize = true;
            this.hairColor.Location = new System.Drawing.Point(21, 55);
            this.hairColor.Name = "hairColor";
            this.hairColor.Size = new System.Drawing.Size(123, 21);
            this.hairColor.TabIndex = 12;
            this.hairColor.Text = "Колір волосся:";
            // 
            // distinguishingFeaturesTextBox
            // 
            this.distinguishingFeaturesTextBox.Location = new System.Drawing.Point(418, 137);
            this.distinguishingFeaturesTextBox.Name = "distinguishingFeaturesTextBox";
            this.distinguishingFeaturesTextBox.Size = new System.Drawing.Size(317, 27);
            this.distinguishingFeaturesTextBox.TabIndex = 11;
            // 
            // hairColorTextBox
            // 
            this.hairColorTextBox.Location = new System.Drawing.Point(150, 52);
            this.hairColorTextBox.Name = "hairColorTextBox";
            this.hairColorTextBox.Size = new System.Drawing.Size(125, 27);
            this.hairColorTextBox.TabIndex = 6;
            // 
            // distinguishingFeatures
            // 
            this.distinguishingFeatures.AutoSize = true;
            this.distinguishingFeatures.Location = new System.Drawing.Point(241, 137);
            this.distinguishingFeatures.Name = "distinguishingFeatures";
            this.distinguishingFeatures.Size = new System.Drawing.Size(171, 21);
            this.distinguishingFeatures.TabIndex = 22;
            this.distinguishingFeatures.Text = "Особливі прикмети:";
            // 
            // birthPlaceTextBox
            // 
            this.birthPlaceTextBox.Location = new System.Drawing.Point(574, 93);
            this.birthPlaceTextBox.Name = "birthPlaceTextBox";
            this.birthPlaceTextBox.Size = new System.Drawing.Size(161, 27);
            this.birthPlaceTextBox.TabIndex = 9;
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.Location = new System.Drawing.Point(96, 137);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(123, 27);
            this.aliasTextBox.TabIndex = 10;
            // 
            // birthPlace
            // 
            this.birthPlace.AutoSize = true;
            this.birthPlace.Location = new System.Drawing.Point(403, 96);
            this.birthPlace.Name = "birthPlace";
            this.birthPlace.Size = new System.Drawing.Size(165, 21);
            this.birthPlace.TabIndex = 16;
            this.birthPlace.Text = "Місце народження:";
            // 
            // alias
            // 
            this.alias.AutoSize = true;
            this.alias.Location = new System.Drawing.Point(22, 137);
            this.alias.Name = "alias";
            this.alias.Size = new System.Drawing.Size(68, 21);
            this.alias.TabIndex = 20;
            this.alias.Text = "Кличка:";
            // 
            // eyesColor
            // 
            this.eyesColor.AutoSize = true;
            this.eyesColor.Location = new System.Drawing.Point(303, 55);
            this.eyesColor.Name = "eyesColor";
            this.eyesColor.Size = new System.Drawing.Size(97, 21);
            this.eyesColor.TabIndex = 18;
            this.eyesColor.Text = "Колір очей:";
            // 
            // eyesColorTextBox
            // 
            this.eyesColorTextBox.Location = new System.Drawing.Point(406, 52);
            this.eyesColorTextBox.Name = "eyesColorTextBox";
            this.eyesColorTextBox.Size = new System.Drawing.Size(125, 27);
            this.eyesColorTextBox.TabIndex = 7;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(13, 280);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(130, 35);
            this.removeButton.TabIndex = 34;
            this.removeButton.Text = "Видалити";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.Location = new System.Drawing.Point(150, 280);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(147, 34);
            this.archiveButton.TabIndex = 35;
            this.archiveButton.Text = "Додати в архів";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // backFromArchiveButton
            // 
            this.backFromArchiveButton.Location = new System.Drawing.Point(151, 280);
            this.backFromArchiveButton.Name = "backFromArchiveButton";
            this.backFromArchiveButton.Size = new System.Drawing.Size(183, 35);
            this.backFromArchiveButton.TabIndex = 36;
            this.backFromArchiveButton.Text = "Повернути з архіву";
            this.backFromArchiveButton.UseVisualStyleBackColor = true;
            this.backFromArchiveButton.Visible = false;
            this.backFromArchiveButton.Click += new System.EventHandler(this.backFromArchiveButton_Click);
            // 
            // imageLabel
            // 
            this.imageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(805, 23);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(188, 21);
            this.imageLabel.TabIndex = 109;
            this.imageLabel.Text = "Зображення злочинця:";
            // 
            // criminalImage
            // 
            this.criminalImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.criminalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.criminalImage.Location = new System.Drawing.Point(809, 47);
            this.criminalImage.Name = "criminalImage";
            this.criminalImage.Size = new System.Drawing.Size(214, 227);
            this.criminalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.criminalImage.TabIndex = 108;
            this.criminalImage.TabStop = false;
            this.criminalImage.Click += new System.EventHandler(this.criminalImage_Click);
            // 
            // CriminalEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 339);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.criminalImage);
            this.Controls.Add(this.backFromArchiveButton);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.criminalFormPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CriminalEditForm";
            this.Text = "Редагування Злочинця";
            this.criminalFormPanel.ResumeLayout(false);
            this.criminalFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel criminalFormPanel;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Label lastPlaceErrorLabel;
        private System.Windows.Forms.Label languagesErrorLabel;
        private System.Windows.Forms.Label lastCrimeErrorLabel;
        private System.Windows.Forms.Label eyesColorErrorLabel;
        private System.Windows.Forms.Label professionErrorLabel;
        private System.Windows.Forms.Label distinguishingFeaturesErrorLabel;
        private System.Windows.Forms.Label aliasErrorLabel;
        private System.Windows.Forms.Label hairColorErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label birthPlaceErrorLabel;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label lastKnownPlace;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastKnownPlaceTextBox;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox languagesTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label languages;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label lastCrime;
        private System.Windows.Forms.TextBox lastCrimeTextBox;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.TextBox professionTextBox;
        private System.Windows.Forms.Label proffesion;
        private System.Windows.Forms.Label hairColor;
        private System.Windows.Forms.TextBox distinguishingFeaturesTextBox;
        private System.Windows.Forms.TextBox hairColorTextBox;
        private System.Windows.Forms.Label distinguishingFeatures;
        private System.Windows.Forms.TextBox birthPlaceTextBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.Label birthPlace;
        private System.Windows.Forms.Label alias;
        private System.Windows.Forms.Label eyesColor;
        private System.Windows.Forms.TextBox eyesColorTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button backFromArchiveButton;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.PictureBox criminalImage;
    }
}