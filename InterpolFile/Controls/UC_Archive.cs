using System;
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

            foreach (var criminal in archive.Criminals)
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
    }
}
