using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InterpolFile.Forms;
using InterpolFile.Models;
using InterpolFile.Utilities;

namespace InterpolFile.Controls
{
    public partial class UC_Archive : UserControl
    {
        private Archive archive;
        private FileIndex fileIndex;

        public UC_Archive(Archive archive, FileIndex fileIndex)
        {
            InitializeComponent();
            this.archive = archive;
            this.fileIndex = fileIndex;

            PopulateArchiveListView();
        }

        public void SetArchive(Archive archive)
        {
            this.archive = archive;
            PopulateArchiveListView();
        }

        public void PopulateArchiveListView()
        {
            archiveList.Items.Clear();
            var list = CriminalUtils.GetSortedCriminals(archive.Criminals, archive.SortedBy);

            foreach (var criminal in list)
            {
                archiveList.Items.Add(CriminalUtils.CreateCriminalListViewItem(criminal));
            }
        }

        public void PopulateArchiveListView(List<Criminal> criminals)
        {
            archiveList.Items.Clear();

            foreach (var criminal in criminals)
            {
                archiveList.Items.Add(CriminalUtils.CreateCriminalListViewItem(criminal));
            }
        }

        private void archiveList_DoubleClick(object sender, EventArgs e)
        {
            CriminalUtils.OpenSelectedCriminalEditForm(this, fileIndex, archive, archiveList);
        }

        private void archiveList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                CriminalUtils.OpenSelectedCriminalEditForm(this, fileIndex, archive, archiveList);
            }
        }

        private void searchArchiveButton_Click(object sender, EventArgs e)
        {
            var searchedCriminals = SearchUtils.SearchCriminals(archive, searchArchiveTextBox.Text);
            PopulateArchiveListView(searchedCriminals);
        }

        private void archiveSortOptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (archiveSortOptionsComboBox.SelectedItem.ToString())
            {
                case "Ім'я":
                    archive.SortedBy = "firstName";
                    break;
                case "Прізвище":
                    archive.SortedBy = "lastName";
                    break;
                case "Зріст":
                    archive.SortedBy = "height";
                    break;
                case "Вік":
                    archive.SortedBy = "dateOfBirth";
                    break;
                default:
                    archive.SortedBy = "";
                    break;
            }
        }

        private void sortArchiveButton_Click(object sender, EventArgs e)
        {
            PopulateArchiveListView();
        }
    }
}
