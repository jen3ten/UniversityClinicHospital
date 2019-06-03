using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Patient
    {
        //public List<Doctor> doctorList = new List<Doctor>();

        //public List<Patient> patientList = new List<Patient>();

        public string Name { get; set; }
        public int PatientNumber { get; set; }
        public int HealthLevel { get; set; }
        public int BloodLevel { get; set; }

        public Patient(string name, int number)
        {
            Name = name;
            PatientNumber = number;
            HealthLevel = 20;
            BloodLevel = 10;
        }


    }
}
