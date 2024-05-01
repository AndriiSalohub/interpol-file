using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolFile.Models
{
    public class FileIndex
    {
        public FileIndex()
        {
            Criminals = new List<Criminal>();
        }

        public List<Criminal> Criminals { get; set; }

        public void AddCriminal(string firstName, string lastName, string hairColor, string eyeColor, int height,
                               string dateOfBirth, string birthPlace, string alias, string distinguishingFeatures,
                               string criminalProfession, string lastCase, List<string> languagesKnown, string lastKnownResidence)
        {
            Criminals.Add(new Criminal(firstName, lastName, hairColor, eyeColor, height,
                        dateOfBirth, birthPlace, alias, distinguishingFeatures,
                        criminalProfession, lastCase, languagesKnown, lastKnownResidence));
        }
    }
}
