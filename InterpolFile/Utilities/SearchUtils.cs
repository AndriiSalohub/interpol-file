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
            string[] searchParams = searchText.Split(',');

            searchParams = Array.ConvertAll(searchParams, p => p.ToLower().Trim());

            return criminals.Where(criminal =>
                searchParams.All(param =>
                    criminal.FirstName.ToLower().Contains(param) ||
                    criminal.LastName.ToLower().Contains(param) ||
                    criminal.HairColor.ToLower().Contains(param) ||
                    criminal.EyeColor.ToLower().Contains(param) ||
                    criminal.Alias.ToLower().Contains(param) ||
                    criminal.DistinguishingFeatures.ToLower().Contains(param) ||
                    criminal.CriminalProfession.ToLower().Contains(param) ||
                    criminal.LastCase.ToLower().Contains(param) ||
                    string.Join(", ", criminal.LanguagesKnown).ToLower().Contains(param) ||
                    criminal.LastKnownResidence.ToLower().Contains(param) ||
                    criminal.BirthPlace.ToLower().Contains(param) ||
                    criminal.DateOfBirth.Contains(param) ||
                    criminal.Height.ToString().Contains(param)
                )
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
