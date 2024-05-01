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

                criminalsList.Items.Add(item);
            }

        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    fileIndex.AddCriminal(firstNameTextBox.Text, lastNameTextBox.Text,
        //        eyesColorTextBox.Text, hairColorTextBox.Text,
        //        (int)heightUpDown.Value, birthTextBox.Text, birthPlaceTextBox.Text,
        //        alias.Text, distinguishingFeaturesTextBox.Text,
        //        proffesionTextBox.Text, lastCrimeTextBox.Text,
        //        languagesTextBox.Text.Split(',').ToList(), lastKnownPlaceTextBox.Text);

        //    foreach (var criminal in fileIndex.Criminals)
        //    {
        //        MessageBox.Show("sdfsdf");
        //        criminalsList.Items.Add(criminal.FirstName);
        //    }
        //}
    }
}
