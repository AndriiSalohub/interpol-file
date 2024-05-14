using System;
using System.Windows.Forms;
using InterpolFile.Forms;
using InterpolFile.Models;

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

        private void PopulateArchiveListView()
        {
            archiveList.Items.Clear();

            foreach (var criminal in archive.Criminals)
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
                archiveList.Items.Add(item);
            }
        }

        private void archiveList_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedCriminalEditForm();
        }

        private void OpenSelectedCriminalEditForm()
        {
            int selectedIndex = archiveList.SelectedItems[0].Index;
            var list = archive.Criminals;

            var selectedCriminal = list[selectedIndex];
            var dialog = new CriminalEditForm(fileIndex, selectedCriminal, archive);
            dialog.CriminalDeleted += RefreshArchive;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                RefreshArchive();
            }

            dialog.CriminalDeleted -= RefreshArchive;
        }


        public void RefreshArchive()
        {
            PopulateArchiveListView();
        }

        private void archiveList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                OpenSelectedCriminalEditForm();
            }
        }
    }
}
