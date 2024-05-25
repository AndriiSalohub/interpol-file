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
using InterpolFile.Utilities;

namespace InterpolFile.Forms
{
    public partial class CriminalEditForm : Form
    {
        readonly Criminal criminal = new Criminal();
        readonly FileIndex fileIndex;
        readonly Archive archive;
        public event Action CriminalDeleted;
        public bool isFromArchive = false;
        private Dictionary<TextBoxBase, Label> fieldsToValidate;
        const string PATH_TO_IMAGE_PLACEHOLDER = ".\\No_Image.png";

        public CriminalEditForm(FileIndex fileIndex, Criminal criminal, Archive archive)
        {
            InitializeComponent();

            this.fileIndex = fileIndex;
            this.criminal = criminal;
            this.archive = archive;
            InitializeForm(false);
        }

        public CriminalEditForm(Criminal criminal, Archive archive, FileIndex fileIndex)
        {
            InitializeComponent();

            this.archive = archive;
            this.fileIndex = fileIndex;
            this.criminal = criminal;
            InitializeForm(true);
        }

        private void InitializeForm(bool fromArchive)
        {
            PopulateFields();
            archiveButton.Visible = !fromArchive;
            backFromArchiveButton.Visible = fromArchive;
            isFromArchive = fromArchive;

            fieldsToValidate = Validator.GetValidationFields(
                firstNameTextBox, firstNameErrorLabel,
                lastNameTextBox, lastNameErrorLabel,
                hairColorTextBox, hairColorErrorLabel,
                eyesColorTextBox, eyesColorErrorLabel,
                birthPlaceTextBox, birthPlaceErrorLabel,
                aliasTextBox, aliasErrorLabel,
                distinguishingFeaturesTextBox, distinguishingFeaturesErrorLabel,
                professionTextBox, professionErrorLabel,
                lastCrimeTextBox, lastCrimeErrorLabel,
                languagesTextBox, languagesErrorLabel,
                lastKnownPlaceTextBox, lastPlaceErrorLabel);

            Validator.AttachValidatingHandlers(fieldsToValidate);
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
            professionTextBox.Text = criminal.CriminalProfession;
            languagesTextBox.Text = String.Join(",", criminal.LanguagesKnown);
            lastCrimeTextBox.Text = criminal.LastCase;
            lastKnownPlaceTextBox.Text = criminal.LastKnownResidence;

            if (!string.IsNullOrEmpty(criminal.Image))
            {

                criminalImage.ImageLocation = criminal.Image;
            }
            else
            {
                criminalImage.ImageLocation = PATH_TO_IMAGE_PLACEHOLDER;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (Validator.ValidateFields(fieldsToValidate))
            {
                EditCriminal();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void EditCriminal()
        {
            Criminal newCriminal = new Criminal(firstNameTextBox.Text, lastNameTextBox.Text, hairColorTextBox.Text,
                                                eyesColorTextBox.Text, (int)heightUpDown.Value, birthDateTimePicker.Value.ToShortDateString(),
                                                birthPlaceTextBox.Text, aliasTextBox.Text, distinguishingFeaturesTextBox.Text,
                                                professionTextBox.Text, lastCrimeTextBox.Text, languagesTextBox.Text.Split(',').ToList(),
                                                lastKnownPlaceTextBox.Text, criminalImage.ImageLocation);

            if (isFromArchive)
            {
                archive.EditCriminal(criminal, newCriminal);
            }
            else
            {
                fileIndex.EditCriminal(criminal, newCriminal);
            }
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
                archive.AddCriminal(criminal);
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

        private void criminalImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog imageDialog = new OpenFileDialog())
            {
                imageDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*.png|All Files (*.*)|*.*\"";

                if (imageDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = imageDialog.FileName;

                    criminalImage.ImageLocation = imagePath;
                }
            }
        }
    }
}
