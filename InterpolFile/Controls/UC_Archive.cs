using System;
using System.Windows.Forms;
using InterpolFile.Models;

namespace InterpolFile.Controls
{
    public partial class UC_Archive : UserControl
    {
        private Archive archive;

        public UC_Archive(Archive archive)
        {
            InitializeComponent();
            this.archive = archive;

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

            foreach (var criminal in archive.ArchiveList)
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

        public void RefreshArchive()
        {
            PopulateArchiveListView();
        }
    }
}
