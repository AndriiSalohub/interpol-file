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
        private Dictionary<TextBoxBase, Label> fieldsToValidate;

        public UC_Criminals(FileIndex fileIndex, Archive archive)
        {
            InitializeComponent();
            this.fileIndex = fileIndex;
            this.archive = archive;

            InitializeValidator();

            PopulateCriminalsListView();
        }

        public void SetArchive(Archive archive)
        {
            this.archive = archive;
        }
        private void InitializeValidator()
        {
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
        public void PopulateCriminalsListView()
        {
            criminalsList.Items.Clear();
            var list = CriminalUtils.GetSortedCriminals(fileIndex.Criminals, fileIndex.SortedBy);

            foreach (var criminal in list)
            {
                criminalsList.Items.Add(CriminalUtils.CreateCriminalListViewItem(criminal));
            }
        }

        public void PopulateCriminalsListView(List<Criminal> criminals)
        {
            criminalsList.Items.Clear();

            foreach (var criminal in criminals)
            {
                criminalsList.Items.Add(CriminalUtils.CreateCriminalListViewItem(criminal));
            }
        }

        private void addCriminalButton_Click(object sender, EventArgs e)
        {
            if (Validator.ValidateFields(fieldsToValidate))
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


        private void criminalsList_DoubleClick(object sender, EventArgs e)
        {
            CriminalUtils.OpenSelectedCriminalEditForm(this, fileIndex, archive, criminalsList);
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchedCriminals = SearchUtils.SearchCriminals(fileIndex, searchTextBox.Text);
            PopulateCriminalsListView(searchedCriminals);
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
