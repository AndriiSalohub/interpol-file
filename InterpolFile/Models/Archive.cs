using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolFile.Models
{
    public class Archive
    {
        public Archive()
        {
            ArchiveList = new List<Criminal>();
            SortedBy = "";
        }

        public List<Criminal> ArchiveList { get; set; }
        public string SortedBy { get; set; }


        public void AddCriminalToArchive(Criminal criminal)
        {
            ArchiveList.Add(criminal);
        }
    }
}
