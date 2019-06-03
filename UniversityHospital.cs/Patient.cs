using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Patient
    {
        List<Patient> patientList = new List<Patient>();

        public string Name { get; set; }
        public int PatientNumber { get; set; }
        public int HealthLevel { get; set; }
        public int BloodLevel { get; set; }

        public Patient(string name)
        {
            Name = name;
            //PatientNumber = number;
            HealthLevel = 20;
            BloodLevel = 10;
        }


        Patient p1 = new Patient("Stone, Travis");
        Patient p2 = new Patient("Jones, Angel");
        Patient p3 = new Patient("Hamilton, Thomas");
        Patient p4 = new Patient("Kipnis, Jason");
        Patient p5 = new Patient("Kluber, Bridget");

        public void AddPatientToList()
        {
            patientList.Add(p1);
            patientList.Add(p2);
            patientList.Add(p3);
            patientList.Add(p4);
            patientList.Add(p5);
        }

        public void PatientList()
        {
            Console.WriteLine("\n---- Patient List: ----");
            Console.WriteLine("Patient Name\t\t| Patient Number |  Health Level |  Blood Level   |");
            Console.WriteLine("-------------------|--------|------------|-------------|");

            int i = 1;
            foreach (Patient element in patientList)
            {
                Console.WriteLine($"{i++}. {element.Name} \t|  {element.PatientNumber}  |     {element.HealthLevel}    |    {element.BloodLevel}       |");
            }

            Console.WriteLine(" ");
        }

        public void NurseCare()
        {

            foreach (Patient element in patientList)
            {
                BloodLevel++;
                HealthLevel++;
            }
        }

        public void NurseBloodDraw()
        {
            foreach (Patient element in patientList)
            {
                BloodLevel--;
                HealthLevel++;
            }
        }

        public void DoctorBloodDraw()
        {
            foreach (Patient element in patientList)
            {
                BloodLevel -= 2;
                HealthLevel += 3;
                Console.WriteLine("Blood sample has been drawn and sent to the lab for testing.");
            }
        }

        public void DoctorCare()
        {
            foreach (Patient element in patientList)
            BloodLevel += 2;
            HealthLevel += 2;
        }

    }
}
