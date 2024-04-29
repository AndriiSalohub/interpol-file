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
        public string Nickname { get; set; }
        public double Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string DistinguishingFeatures { get; set; }
        public string BirthPlace { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string LastKnownResidence { get; set; }
        public List<string> LanguagesKnown { get; set; }
        public string CriminalProfession { get; set; }
        public string LastCase { get; set; }

        public Criminal(string lastName, string firstName, string nickname, double height, string hairColor, string eyeColor,
                        string distinguishingFeatures, string birthPlace, DateTime dateOfBirth, string lastKnownResidence,
                        List<string> languagesKnown, string criminalProfession, string lastCase)
        {
            LastName = lastName;
            FirstName = firstName;
            Nickname = nickname;
            Height = height;
            HairColor = hairColor;
            EyeColor = eyeColor;
            DistinguishingFeatures = distinguishingFeatures;
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            LastKnownResidence = lastKnownResidence;
            LanguagesKnown = languagesKnown;
            CriminalProfession = criminalProfession;
            LastCase = lastCase;
        }
    }
}
