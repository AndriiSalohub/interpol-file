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
    public class IndexManager
    {
        public List<Criminal> Criminals { get; set; }
        public string SortedBy { get; set; }
        public string SearchTerm { get; set; }

        public IndexManager()
        {
            Criminals = new List<Criminal>();
            SortedBy = "";
            SearchTerm = "";
        }

        public void AddCriminal(Criminal criminal)
        {
            Criminals.Add(criminal);
        }

        public void EditCriminal(Criminal oldCriminal, Criminal newCriminal)
        {
            int index = Criminals.FindIndex(c => c.FirstName == oldCriminal.FirstName && c.LastName == oldCriminal.LastName);
            if (index != -1)
            {
                Criminals[index] = newCriminal;
            }
        }

        public void SaveCriminals(string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string jsonString = JsonSerializer.Serialize(Criminals, options);
            File.WriteAllText(path, jsonString, Encoding.UTF8);
        }

        public void LoadCriminals(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found at the specified path.");
            }

            string jsonString = File.ReadAllText(path);
            Criminals = JsonSerializer.Deserialize<List<Criminal>>(jsonString);
            //List<Criminal> loadedCriminals = JsonSerializer.Deserialize<List<Criminal>>(jsonString);
            //for (int i = 0; i < loadedCriminals.Count; i++)
            //{
            //    Criminals.Add(loadedCriminals[i]);
            //}

            if (Criminals == null)
            {
                Criminals = new List<Criminal>();
            }
        }
    }
}
