using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Patient
    {
        Doctor doctor = new Doctor ("",0,"","");
        Nurse nurse = new Nurse("", 0, "", "");
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

        List<Patient> patientList = new List<Patient>();

        Patient p1 = new Patient("Stone, Travis", 10874);
        Patient p2 = new Patient("Jones, Angel", 15823);
        Patient p3 = new Patient("Hamilton, Thomas", 12561);
        Patient p4 = new Patient("Kipnis, Jason", 16810);
        Patient p5 = new Patient("Kluber, Bridget", 108945);

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
            AddPatientToList();

            int i = 1;
            foreach (Patient element in patientList)
            {
                Console.WriteLine($"{i++}. {element.Name} \t|  {element.PatientNumber}  |     {element.HealthLevel}    |    {element.BloodLevel}       |");
            }

            Console.WriteLine(" ");
        }

        public void NurseCare()
        {
            PatientList();
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
            {
                BloodLevel += 2;
                HealthLevel += 2;
            }
        }
    }
}
