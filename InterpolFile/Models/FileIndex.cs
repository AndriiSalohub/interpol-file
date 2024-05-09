﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InterpolFile.Models
{
    public class FileIndex
    {
        public FileIndex()
        {
            Criminals = new List<Criminal>();
            SortedBy = "";
        }

        public List<Criminal> Criminals { get; set; }
        public string SortedBy { get; set; }


        public void AddCriminal(string firstName, string lastName, string hairColor, string eyeColor, int height,
                               string dateOfBirth, string birthPlace, string alias, string distinguishingFeatures,
                               string criminalProfession, string lastCase, List<string> languagesKnown, string lastKnownResidence)
        {
            Criminals.Add(new Criminal(firstName, lastName, hairColor, eyeColor, height,
                        dateOfBirth, birthPlace, alias, distinguishingFeatures,
                        criminalProfession, lastCase, languagesKnown, lastKnownResidence));
        }

        public void SaveCriminals(string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(Criminals, options);
            File.WriteAllText(path, jsonString);
        }

        public void LoadCriminals(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found at the specified path.");
            }

            string jsonString = File.ReadAllText(path);
            Criminals = JsonSerializer.Deserialize<List<Criminal>>(jsonString);

            if (Criminals == null)
            {
                Criminals = new List<Criminal>();
            }
        }
    }
}
