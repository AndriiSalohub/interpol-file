using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolFile.Models
{
    public class Archive : IndexManager
    {
        public Archive() : base()
        {
        }

        public void AddCriminalToArchive(Criminal criminal)
        {
            Criminals.Add(criminal);
        }

        public void DeleteCriminalFromArchive(string firstName, string lastName)
        {
            Criminal criminalToRemove = Criminals.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);

            if (criminalToRemove != null)
            {
                Criminals.Remove(criminalToRemove);
            }
        }

    }
}
