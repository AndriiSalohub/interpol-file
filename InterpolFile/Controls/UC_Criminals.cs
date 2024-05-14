using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterpolFile.Forms;
using InterpolFile.Models;
using InterpolFile.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterpolFile.Controls
{
    public partial class UC_Criminals : UserControl
    {
        private FileIndex fileIndex;
        private Archive archive;

        public UC_Criminals(FileIndex fileIndex, Archive archive)
        {
            InitializeComponent();
            this.fileIndex = fileIndex;
            this.archive = archive;

            AttachValidatingHandlers();
            PopulateCriminalsListView();
        }

        public void SetArchive(Archive archive)
        {
            this.archive = archive;
        }

        private void addCriminalButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                AddCriminalToIndex();
                ResetForm();
                PopulateCriminalsListView();
            }
        }

        private void AddCriminalToIndex()
        {
            fileIndex.AddCriminal(
                firstNameTextBox.Text, lastNameTextBox.Text,
                eyesColorTextBox.Text, hairColorTextBox.Text,
                (int)heightUpDown.Value, birthDateTimePicker.Text, birthPlaceTextBox.Text,
                aliasTextBox.Text, distinguishingFeaturesTextBox.Text,
                professionTextBox.Text, lastCrimeTextBox.Text,
                languagesTextBox.Text.Split(',').ToList(), lastKnownPlaceTextBox.Text);
        }

        private void ResetForm()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            eyesColorTextBox.Text = "";
            hairColorTextBox.Text = "";
            birthPlaceTextBox.Text = "";
            aliasTextBox.Text = "";
            distinguishingFeaturesTextBox.Text = "";
            professionTextBox.Text = "";
            lastCrimeTextBox.Text = "";
            languagesTextBox.Text = "";
            lastKnownPlaceTextBox.Text = "";

            heightUpDown.Value = heightUpDown.Minimum;

            birthDateTimePicker.Value = birthDateTimePicker.MaxDate;
        }

        public void PopulateCriminalsListView()
        {
            criminalsList.Items.Clear();
            var list = CriminalUtils.GetSortedCriminals(fileIndex);

            foreach (var criminal in list)
            {
                criminalsList.Items.Add(CriminalUtils.CreateCriminalListViewItem(criminal));
            }
        }

        private void criminalsList_DoubleClick(object sender, EventArgs e)
        {
            CriminalUtils.OpenSelectedCriminalEditForm(this, fileIndex, archive, criminalsList);
        }

        private void AttachValidatingHandlers()
        {
            var fieldsToValidate = new Dictionary<TextBoxBase, Label>
            {
                { firstNameTextBox, firstNameErrorLabel },
                { lastNameTextBox, lastNameErrorLabel },
                { hairColorTextBox, hairColorErrorLabel },
                { eyesColorTextBox, eyesColorErrorLabel },
                { birthPlaceTextBox, birthPlaceErrorLabel },
                { aliasTextBox, aliasErrorLabel },
                { distinguishingFeaturesTextBox, distinguishingFeaturesErrorLabel },
                { professionTextBox, professionErrorLabel },
                { lastCrimeTextBox, lastCrimeErrorLabel },
                { languagesTextBox, languagesErrorLabel },
                { lastKnownPlaceTextBox, lastPlaceErrorLabel }
            };

            foreach (var pair in fieldsToValidate)
            {
                pair.Key.Validating += (sender, e) => ValidateTextField(pair.Key, pair.Value);
            }
        }

        private bool ValidateFields()
        {
            bool allFieldsValid = true;
            var validationFields = GetValidationFields();

            foreach (var kv in validationFields)
            {
                if (!ValidateTextField(kv.Key, kv.Value))
                {
                    allFieldsValid = false;
                }
            }

            return allFieldsValid;
        }

        private Dictionary<TextBoxBase, Label> GetValidationFields()
        {
            return new Dictionary<TextBoxBase, Label>
            {
                { firstNameTextBox, firstNameErrorLabel },
                { lastNameTextBox, lastNameErrorLabel },
                { hairColorTextBox, hairColorErrorLabel },
                { eyesColorTextBox, eyesColorErrorLabel },
                { birthPlaceTextBox, birthPlaceErrorLabel },
                { aliasTextBox, aliasErrorLabel },
                { distinguishingFeaturesTextBox, distinguishingFeaturesErrorLabel },
                { professionTextBox, professionErrorLabel },
                { lastCrimeTextBox, lastCrimeErrorLabel },
                { languagesTextBox, languagesErrorLabel },
                { lastKnownPlaceTextBox, lastPlaceErrorLabel }
            };
        }

        private bool ValidateTextField(TextBoxBase textBox, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(textBox.Text);
            errorLabel.Visible = !isValid;
            return isValid;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                PopulateCriminalsListView();
            }
            else
            {
                criminalsList.Items.Clear();
                foreach (var criminal in fileIndex.Criminals)
                {
                    if (criminal.FirstName.ToLower().Contains(searchText) ||
                        criminal.LastName.ToLower().Contains(searchText) ||
                        criminal.HairColor.ToLower().Contains(searchText) ||
                        criminal.EyeColor.ToLower().Contains(searchText) ||
                        criminal.Alias.ToLower().Contains(searchText) ||
                        criminal.DistinguishingFeatures.ToLower().Contains(searchText) ||
                        criminal.CriminalProfession.ToLower().Contains(searchText) ||
                        criminal.LastCase.ToLower().Contains(searchText) ||
                        String.Join(", ", criminal.LanguagesKnown).ToLower().Contains(searchText) ||
                        criminal.LastKnownResidence.ToLower().Contains(searchText) ||
                        criminal.BirthPlace.ToLower().Contains(searchText) ||
                        criminal.DateOfBirth.Contains(searchText) ||
                        criminal.Height.ToString().Contains(searchText))
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                    $"{criminal.FirstName} {criminal.LastName}",
                    criminal.HairColor,
                    criminal.EyeColor,
                    criminal.Height.ToString(),
                    criminal.Alias,
                    criminal.DistinguishingFeatures,
                    criminal.CriminalProfession,
                    criminal.LastCase,
                    String.Join(", ", criminal.LanguagesKnown),
                    criminal.LastKnownResidence,
                    criminal.DateOfBirth,
                    criminal.BirthPlace
                        });
                        criminalsList.Items.Add(item);
                    }
                }
            }
        }

        private void sortOptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sortOptionsComboBox.SelectedItem.ToString())
            {

                case "Ім'я":
                    fileIndex.SortedBy = "firstName";
                    break;
                case "Прізвище":
                    fileIndex.SortedBy = "lastName";
                    break;
                case "Зріст":
                    fileIndex.SortedBy = "height";
                    break;
                case "Вік":
                    fileIndex.SortedBy = "dateOfBirth";
                    break;
                default:
                    fileIndex.SortedBy = "";
                    break;

            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            PopulateCriminalsListView();
        }

        private void criminalsList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                CriminalUtils.OpenSelectedCriminalEditForm(this, fileIndex, archive, criminalsList);
            }
        }
    }
}
