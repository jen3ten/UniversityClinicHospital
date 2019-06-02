using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Patient
    {
        //public List<Doctor> doctorList = new List<Doctor>();

         public List<Patient> patientList = new List<Patient>();

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

        //static void PatientList(string[] args)
        //{
            Patient p1 = new Patient("Stone, Travis", 10874);
            Patient p2 = new Patient("Jones, Angel", 15823);
            Patient p3 = new Patient("Hamilton, Thomas", 12561);
            Patient p4 = new Patient("Kipnis, Jason", 16810);
            Patient p5 = new Patient("Kluber, Bridget", 108945);
        //}

        public void AddPatientToList()
        {
            patientList.Add(p1);
            patientList.Add(p2);
            patientList.Add(p3);
            patientList.Add(p4);
            patientList.Add(p5);
        }
    }
}
