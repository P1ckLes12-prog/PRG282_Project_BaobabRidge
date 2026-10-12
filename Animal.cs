using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRG282_Project_BaobabRidge
{
    internal class Animal
    {
        public string AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string status { get; set; }
        public string HousingUnit { get; set; }

        public string ConvertAnimal()
        {
            return $"{AnimalID}|{Name}|{Species}|{Age}|{RecoveryScore}|{status}|{HousingUnit}";
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
