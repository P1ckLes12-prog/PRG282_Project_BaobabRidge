using System;
using System.Collections.Generic;
using System.Text;

namespace PRG282_Project_BaobabRidge
{
    internal class DataHandler
    {
        //create a path
        string path = Path.Combine(AppContext.BaseDirectory, "animals.txt");

        //create an empty animals file if it is missing
        public void EnsureFileExists()
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }
        }

        //this method will be used to check every ID entered is unique and it will caluclate the amount of lines skipped when doing the validation
        //lines skipped are lines that are invalid/ have errors
        public (List<Animal> Animals, int Skipped) LoadAnimals()
        {
            EnsureFileExists();
            List<Animal> animals = new List<Animal>();
            int skipped = 0;

            try
            {
                //check the validity of each line and skip the lines that aren't valid
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
                        status = parts[5],
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

        public void AddAnimal(Animal animal)
        {
            EnsureFileExists();
            string existing = File.ReadAllText(path);
            string prefix = (existing.Length > 0 && !existing.EndsWith("\n")) ? Environment.NewLine : "";
            File.AppendAllText(path, prefix + animal.ConvertAnimal() + Environment.NewLine);
        }
    }
}
