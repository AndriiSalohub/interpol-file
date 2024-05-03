using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolFile.Models
{
    public class Criminal
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int Height { get; set; }
        public string DateOfBirth { get; set; }
        public string BirthPlace { get; set; }
        public string Alias { get; set; }
        public string DistinguishingFeatures { get; set; }
        public string CriminalProfession { get; set; }
        public string LastCase { get; set; }
        public List<string> LanguagesKnown { get; set; }
        public string LastKnownResidence { get; set; }

        public Criminal(string firstName, string lastName, string hairColor, string eyeColor, int height,
                       string dateOfBirth, string birthPlace, string alias, string distinguishingFeatures,
                       string criminalProfession, string lastCase, List<string> languagesKnown, string lastKnownResidence)
        {
            FirstName = firstName;
            LastName = lastName;
            HairColor = hairColor;
            EyeColor = eyeColor;
            Height = height;
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            Alias = alias;
            DistinguishingFeatures = distinguishingFeatures;
            CriminalProfession = criminalProfession;
            LastCase = lastCase;
            LanguagesKnown = languagesKnown;
            LastKnownResidence = lastKnownResidence;
        }

        public Criminal() { }
    }
}
