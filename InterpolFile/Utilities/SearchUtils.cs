using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpolFile.Models;

namespace InterpolFile.Utilities
{
    public class SearchUtils
    {
        public static List<Criminal> SearchCriminals(List<Criminal> criminals, string searchText)
        {
            searchText = searchText.ToLower();

            return criminals.Where(criminal =>
                criminal.FirstName.ToLower().Contains(searchText) ||
                criminal.LastName.ToLower().Contains(searchText) ||
                criminal.HairColor.ToLower().Contains(searchText) ||
                criminal.EyeColor.ToLower().Contains(searchText) ||
                criminal.Alias.ToLower().Contains(searchText) ||
                criminal.DistinguishingFeatures.ToLower().Contains(searchText) ||
                criminal.CriminalProfession.ToLower().Contains(searchText) ||
                criminal.LastCase.ToLower().Contains(searchText) ||
                string.Join(", ", criminal.LanguagesKnown).ToLower().Contains(searchText) ||
                criminal.LastKnownResidence.ToLower().Contains(searchText) ||
                criminal.BirthPlace.ToLower().Contains(searchText) ||
                criminal.DateOfBirth.Contains(searchText) ||
                criminal.Height.ToString().Contains(searchText)
            ).ToList();
        }

        public static List<Criminal> SearchCriminals(object source, string searchText)
        {
            if (source is FileIndex fileIndex)
            {
                return SearchCriminalsInFileIndex(fileIndex, searchText);
            }
            else if (source is Archive archive)
            {
                return SearchCriminalsInArchive(archive, searchText);
            }
            else
            {
                throw new ArgumentException("Invalid source type. Expected FileIndex or Archive.");
            }
        }

        private static List<Criminal> SearchCriminalsInFileIndex(FileIndex fileIndex, string searchText)
        {
            fileIndex.SearchTerm = searchText;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return fileIndex.Criminals;
            }
            else
            {
                var searchedCriminals = SearchCriminals(fileIndex.Criminals, searchText);
                return CriminalUtils.GetSortedCriminals(searchedCriminals, fileIndex.SortedBy);
            }
        }

        private static List<Criminal> SearchCriminalsInArchive(Archive archive, string searchText)
        {
            archive.SearchTerm = searchText;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return archive.Criminals;
            }
            else
            {
                var searchedCriminals = SearchCriminals(archive.Criminals, searchText);
                return CriminalUtils.GetSortedCriminals(searchedCriminals, archive.SortedBy);
            }
        }
    }
}
