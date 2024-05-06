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
            firstNameTextBox.Text = criminal.FirstName;
            lastNameTextBox.Text = criminal.LastName;
            hairColorTextBox.Text = criminal.HairColor;
            eyesColorTextBox.Text = criminal.EyeColor;
            heightUpDown.Value = criminal.Height;
            birthDateTimePicker.Text = criminal.DateOfBirth;
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
            criminal.LastKnownResidence = lastKnownPlaceTextBox.Text;
            criminal.LastCase = lastCrimeTextBox.Text;
            criminal.CriminalProfession = proffesionTextBox.Text;
            criminal.DistinguishingFeatures = distinguishingFeaturesTextBox.Text;
            criminal.Alias = aliasTextBox.Text;
            criminal.DateOfBirth = birthDateTimePicker.Text;
            criminal.BirthPlace = birthPlaceTextBox.Text;
            criminal.Height = (int)heightUpDown.Value;
            criminal.EyeColor = eyesColorTextBox.Text;
            criminal.HairColor = hairColorTextBox.Text;
            criminal.LastName = lastNameTextBox.Text;
            criminal.FirstName = firstNameTextBox.Text;
            criminal.LanguagesKnown = languagesTextBox.Text.Split(',').ToList();
        }
    }
}
