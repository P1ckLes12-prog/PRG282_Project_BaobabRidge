using System;
using System.Collections.Generic;
using System.Text;

namespace PRG282_Project_BaobabRidge
{
    internal class Animals
    {
        private string AnimalID { get; set; }
        private string Name { get; set; }
        private string Species { get; set; }
        private int Age { get; set; }
        private int RecoveryScore { get; set; }
        private string Status { get; set; }
        private string HousingUnit { get; set; }

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

        

    }
}
