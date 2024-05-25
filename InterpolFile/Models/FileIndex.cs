using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterpolFile.Models
{
    public class FileIndex : IndexManager
    {
        public FileIndex() : base()
        {
        }

        public void AddCriminal(string firstName, string lastName, string hairColor, string eyeColor, int height,
                               string dateOfBirth, string birthPlace, string alias, string distinguishingFeatures,
                               string criminalProfession, string lastCase, List<string> languagesKnown, string lastKnownResidence, string image)
        {
            Criminals.Add(new Criminal(firstName, lastName, hairColor, eyeColor, height,
                        dateOfBirth, birthPlace, alias, distinguishingFeatures,
                        criminalProfession, lastCase, languagesKnown, lastKnownResidence, image));
        }

        public void DeleteCriminal(string firstName, string lastName)
        {
            Criminal criminalToRemove = Criminals.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);

            if (criminalToRemove != null)
            {
                Criminals.Remove(criminalToRemove);
            }
        }
    }
}
