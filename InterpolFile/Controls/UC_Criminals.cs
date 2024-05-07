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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterpolFile.Controls
{
    public partial class UC_Criminals : UserControl
    {
        private FileIndex fileIndex;

        public UC_Criminals(FileIndex fileIndex)
        {
            InitializeComponent();
            this.fileIndex = fileIndex;

            AttachValidatingHandlers();
        }

        private void addCriminalButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                AddCriminalToIndex();
                PopulateCriminalsListView();
            }
        }
        private void criminalsList_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = criminalsList.SelectedItems[0].Index;
            var selectedCriminal = fileIndex.Criminals[selectedIndex];
            var dialog = new CriminalEditForm(selectedCriminal);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UpdateListViewItem(criminalsList.Items[selectedIndex], selectedCriminal);
            }
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

        private void PopulateCriminalsListView()
        {
            criminalsList.Items.Clear();
            foreach (var criminal in fileIndex.Criminals)
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

        private void UpdateListViewItem(ListViewItem item, Criminal criminal)
        {
            item.SubItems[0].Text = $"{criminal.FirstName} {criminal.LastName}";
            item.SubItems[1].Text = criminal.HairColor;
            item.SubItems[2].Text = criminal.EyeColor;
            item.SubItems[3].Text = criminal.Height.ToString();
            item.SubItems[4].Text = criminal.Alias;
            item.SubItems[5].Text = criminal.DistinguishingFeatures;
            item.SubItems[6].Text = criminal.CriminalProfession;
            item.SubItems[7].Text = criminal.LastCase;
            item.SubItems[8].Text = String.Join(", ", criminal.LanguagesKnown);
            item.SubItems[9].Text = criminal.LastKnownResidence;
            item.SubItems[10].Text = criminal.DateOfBirth;
            item.SubItems[11].Text = criminal.BirthPlace;
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
    }
}
