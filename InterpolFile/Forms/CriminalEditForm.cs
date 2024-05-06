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

        public CriminalEditForm(Criminal criminal)
        {
            InitializeComponent();

            this.criminal = criminal;
            PopulateFields();
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
    }
}
