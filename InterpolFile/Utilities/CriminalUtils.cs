using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpolFile.Forms;
using InterpolFile.Models;
using System.Windows.Forms;
using InterpolFile.Controls;

namespace InterpolFile.Utilities
{
    public class CriminalUtils
    {
        public static ListViewItem CreateCriminalListViewItem(Criminal criminal)
        {
            return new ListViewItem(new string[]
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
        }

        public static List<Criminal> GetSortedCriminals(IEnumerable<Criminal> criminals, string sortBy)
        {
            switch (sortBy)
            {
                case "firstName":
                    return criminals.OrderBy(c => c.FirstName).ToList();
                case "lastName":
                    return criminals.OrderBy(c => c.LastName).ToList();
                case "height":
                    return criminals.OrderBy(c => c.Height).ToList();
                case "dateOfBirth":
                    return criminals.OrderBy(c => DateTime.Parse(c.DateOfBirth)).ToList();
                default:
                    return criminals.ToList();
            }
        }

        public static void OpenSelectedCriminalEditForm(UserControl currentUserControl, FileIndex fileIndex, Archive archive, ListView listView)
        {
            int selectedIndex = listView.SelectedItems[0].Index;
            List<Criminal> list = null;

            if (currentUserControl is UC_Criminals)
            {
                list = GetSortedCriminals(fileIndex.Criminals, fileIndex.SortedBy);
                var selectedCriminal = list[selectedIndex];
                var dialog = new CriminalEditForm(fileIndex, selectedCriminal, archive);
                dialog.CriminalDeleted += () => RefreshData(currentUserControl);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    RefreshData(currentUserControl);
                }

                dialog.CriminalDeleted -= () => RefreshData(currentUserControl);
            }
            else if (currentUserControl is UC_Archive)
            {
                list = GetSortedCriminals(archive.Criminals, archive.SortedBy);
                var selectedCriminal = list[selectedIndex];
                var dialog = new CriminalEditForm(selectedCriminal, archive, fileIndex);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    RefreshData(currentUserControl);
                }

                dialog.CriminalDeleted -= () => RefreshData(currentUserControl);
            }
        }

        public static void RefreshData(UserControl currentUserControl)
        {
            if (currentUserControl is UC_Criminals)
            {
                (currentUserControl as UC_Criminals).PopulateCriminalsListView();
            }
            else if (currentUserControl is UC_Archive)
            {
                (currentUserControl as UC_Archive).PopulateArchiveListView();
            }
        }
    }
}
