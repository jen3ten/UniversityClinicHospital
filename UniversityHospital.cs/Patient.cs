using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    class Patient
    {
        public string Name { get; set; }
        public int PatientNumber { get; set; }
        public int HealthLevel { get; set; }
        public int BloodLevel { get; set; }

        public Patient(string name, int number)
        {
            HealthLevel = 20;
            BloodLevel = 10;
           
        }
    }
}
