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
        }

        private void addCriminalButton_Click(object sender, EventArgs e)
        {
            fileIndex.AddCriminal(firstNameTextBox.Text, lastNameTextBox.Text,
                eyesColorTextBox.Text, hairColorTextBox.Text,
                (int)heightUpDown.Value, birthTextBox.Text, birthPlaceTextBox.Text,
                aliasTextBox.Text, distinguishingFeaturesTextBox.Text,
                proffesionTextBox.Text, lastCrimeTextBox.Text,
                languagesTextBox.Text.Split(',').ToList(), lastKnownPlaceTextBox.Text);

            criminalsList.Items.Clear();
            foreach (var criminal in fileIndex.Criminals)
            {
                ListViewItem item = new ListViewItem($"{criminal.FirstName} {criminal.LastName}");

                item.SubItems.Add(criminal.HairColor);
                item.SubItems.Add(criminal.EyeColor);
                item.SubItems.Add(criminal.Height.ToString());
                item.SubItems.Add(criminal.Alias);
                item.SubItems.Add(criminal.DistinguishingFeatures);
                item.SubItems.Add(criminal.CriminalProfession);
                item.SubItems.Add(criminal.LastCase);
                item.SubItems.Add(String.Join(", ", criminal.LanguagesKnown));  // Пример, если LanguagesKnown - это список
                item.SubItems.Add(criminal.LastKnownResidence);
                item.SubItems.Add(criminal.DateOfBirth);
                item.SubItems.Add(criminal.BirthPlace);

                criminalsList.Items.Add(item);
            }
        }

        private void criminalsList_DoubleClick(object sender, EventArgs e)
        {
            if (criminalsList.SelectedItems.Count == 0)
                return;

            int selectedIndex = criminalsList.SelectedItems[0].Index;
            var selectedCriminal = fileIndex.Criminals[selectedIndex];

            var dialog = new CriminalEditForm(selectedCriminal);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UpdateListViewItem(criminalsList.Items[selectedIndex], selectedCriminal);
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
    }
}
