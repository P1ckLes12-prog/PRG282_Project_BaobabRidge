using System;
using System.Collections.Generic;
using System.Text;

namespace PRG282_Project_BaobabRidge
{
    internal class Animal
    {
        public string AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; }
        public string HousingUnit { get; set; }

        public string ConvertAnimal(string id, string name, string species, int age, int recoveryScore, string status, string housingUnit)
        {
            return $"{id}|{name}|{species}|{age}|{recoveryScore}|{status}|{housingUnit}";
        }

        public (string status, string housingUnit) ClassifyRecoveryScore(int score)
        {
            if (score >= 0 && score <= 19) { return ("Critical", "Intensive Care Unit"); }
            else if (score >= 20 && score <= 39) { return ("Serious", "High-Dependency Ward"); }
            else if (score >= 40 && score <= 59) { return ("Stable", "Recovery Ward"); }
            else if (score >= 60 && score <= 79) { return ("Recovering", "Outdoor Enclosure"); }
            else if (score >= 80 && score <= 100) { return ("Release-Ready", "Pre-Release Camp"); }
            else { return ("N/A", "N/A"); }
        }

        //this method will be used to check that ecery ID entered is unique and it will caluclate the amount of lines skipped when doing the validation
        public (List<Animal> Animals, int Skipped) LoadAnimals()
        {
            int skipped = 0;
            List<Animal> animals = new List<Animal>();

            //create a path
            string path = Path.Combine(AppContext.BaseDirectory, "animals.txt");

            try
            {
                //if the file is missing we create an empty one and return an empty list
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, "");
                    return (animals, 0);
                }

                //if the file exists we will then need to check the validity of each line and skip the lines that aren't valid
                foreach (string line in File.ReadAllLines(path))
                {
                    string[] parts = line.Split('|');

                    //ensure there are 7 fiels
                    if (parts.Length != 7)
                    {
                        skipped++;
                        continue;
                    }

                    //trim each part - this just makes everything neater
                    for (int i = 0; i < parts.Length; i++)
                    {
                        parts[i] = parts[i].Trim();
                    }

                    //ensure the animal id is in the following format WR-0000
                    string id = parts[0].ToUpper();
                    if (id.Length != 7 || !id.StartsWith("WR-") || !int.TryParse(id.Substring(3), out int code))
                    {
                        skipped++;
                        continue;
                    }

                    //ensure the age and recovery score is actually numbers
                    if (!int.TryParse(parts[3], out int age) || !int.TryParse(parts[4], out int score))
                    {
                        skipped++;
                        continue;
                    }

                    //if all of the above code has run and none of these tests were false, the line is valid and we can the build the object
                    animals.Add(new Animal
                    {
                        AnimalID = id,
                        Name = parts[1],
                        Species = parts[2],
                        Age = age,
                        RecoveryScore = score,
                        Status = parts[5],
                        HousingUnit = parts[6],
                    });
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No permission to access the animals file.", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("The animals file is in use by another program", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (animals, skipped);
        }

    }
}
