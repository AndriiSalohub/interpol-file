using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterpolFile.Models;

namespace InterpolFile.Forms
{
    public partial class CriminalEditForm : Form
    {
        readonly Criminal criminal = new Criminal();
        readonly FileIndex fileIndex;
        readonly Archive archive;
        public event Action CriminalDeleted;
        public bool isFromArchive = false;

        public CriminalEditForm(FileIndex fileIndex, Criminal criminal, Archive archive)
        {
            InitializeComponent();

            this.fileIndex = fileIndex;
            this.criminal = criminal;
            this.archive = archive;
            PopulateFields();
            archiveButton.Visible = true;
            backFromArchiveButton.Visible = false;
            isFromArchive = false;
        }

        public CriminalEditForm(Criminal criminal, Archive archive, FileIndex fileIndex)
        {
            InitializeComponent();

            this.archive = archive;
            this.fileIndex = fileIndex;
            this.criminal = criminal;
            PopulateFields();
            archiveButton.Visible = false;
            backFromArchiveButton.Visible = true;
            isFromArchive = true;
        }

        private void PopulateFields()
        {
            firstNameTextBox.Text = criminal.FirstName;
            lastNameTextBox.Text = criminal.LastName;
            hairColorTextBox.Text = criminal.HairColor;
            eyesColorTextBox.Text = criminal.EyeColor;
            heightUpDown.Value = criminal.Height;
            birthDateTimePicker.Value = DateTime.Parse(criminal.DateOfBirth);
            birthPlaceTextBox.Text = criminal.BirthPlace;
            aliasTextBox.Text = criminal.Alias;
            distinguishingFeaturesTextBox.Text = criminal.DistinguishingFeatures;
            proffesionTextBox.Text = criminal.CriminalProfession;
            languagesTextBox.Text = String.Join(",", criminal.LanguagesKnown);
            lastCrimeTextBox.Text = criminal.LastCase;
            lastKnownPlaceTextBox.Text = criminal.LastKnownResidence;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                UpdateCriminal();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private bool ValidateFields()
        {
            var fieldsToValidate = new Dictionary<TextBox, Label>
            {
                { firstNameTextBox, firstNameErrorLabel },
                { lastNameTextBox, lastNameErrorLabel },
                { hairColorTextBox, hairColorErrorLabel },
                { eyesColorTextBox, eyesColorErrorLabel },
                { birthPlaceTextBox, birthPlaceErrorLabel },
                { aliasTextBox, aliasErrorLabel },
                { distinguishingFeaturesTextBox, distinguishingFeaturesErrorLabel },
                { proffesionTextBox, proffesionErrorLabel },
                { lastCrimeTextBox, lastCrimeErrorLabel },
                { languagesTextBox, languagesErrorLabel },
                { lastKnownPlaceTextBox, lastPlaceErrorLabel }
            };

            bool allFieldsValid = true;
            foreach (var pair in fieldsToValidate)
            {
                if (!ValidateTextField(pair.Key, pair.Value))
                {
                    allFieldsValid = false;
                }
            }

            return allFieldsValid;
        }

        private bool ValidateTextField(TextBox textBox, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(textBox.Text);
            errorLabel.Visible = !isValid;
            return isValid;
        }

        private void UpdateCriminal()
        {
            criminal.FirstName = firstNameTextBox.Text;
            criminal.LastName = lastNameTextBox.Text;
            criminal.HairColor = hairColorTextBox.Text;
            criminal.EyeColor = eyesColorTextBox.Text;
            criminal.Height = (int)heightUpDown.Value;
            criminal.DateOfBirth = birthDateTimePicker.Value.ToShortDateString();
            criminal.BirthPlace = birthPlaceTextBox.Text;
            criminal.Alias = aliasTextBox.Text;
            criminal.DistinguishingFeatures = distinguishingFeaturesTextBox.Text;
            criminal.CriminalProfession = proffesionTextBox.Text;
            criminal.LastCase = lastCrimeTextBox.Text;
            criminal.LanguagesKnown = languagesTextBox.Text.Split(',').ToList();
            criminal.LastKnownResidence = lastKnownPlaceTextBox.Text;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (isFromArchive)
            {
                var confirmResult = MessageBox.Show("Ви впевнені, що хочете видалити цього злочинця з архіву?",
                                                   "Confirm Removal",
                                                   MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    archive.DeleteCriminalFromArchive(criminal.FirstName, criminal.LastName);
                    MessageBox.Show("Злочинця було успішно видалено з архіву.", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CriminalDeleted?.Invoke();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Ви впевнені, що хочете видалити цього злочинця?",
                                                   "Confirm Removal",
                                                   MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (fileIndex.Criminals.Contains(criminal))
                    {
                        fileIndex.DeleteCriminal(criminal.FirstName, criminal.LastName);
                        MessageBox.Show("Злочинця було успішно видалено.", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CriminalDeleted?.Invoke();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Злочинець не знайден.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Ви впевнені, що хочете перенести цього злочинця в архів?", "Confirm Archive", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                archive.AddCriminalToArchive(criminal);
                fileIndex.DeleteCriminal(criminal.FirstName, criminal.LastName);
                MessageBox.Show("Злочинець успішно був перенесений в архів.", "Archive Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CriminalDeleted?.Invoke();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void backFromArchiveButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Ви впевнені, що хочете повернути цього злочинця з архіву?", "Confirm Restoration", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                archive.DeleteCriminalFromArchive(criminal.FirstName, criminal.LastName);
                fileIndex.AddCriminal(criminal);
                MessageBox.Show("Злочинець успішно повернутий з архіву.", "Restoration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CriminalDeleted?.Invoke();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
