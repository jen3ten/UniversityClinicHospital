using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Hospital
    {
        public List<Patient> PatientList { get; set; }

        public Hospital()
        {
            PatientList = new List<Patient>()
                {
                    new Patient("Stone, Travis", 10574),
                    new Patient("Jones, Angel", 10986),
                    new Patient("Hamilton, Thomas", 10025),
                    new Patient("Kipnis, Jason", 10658),
                    new Patient("Kluber, Bridget", 10234)
                };
        }

        public void ShowPatientList()
        {
            Console.WriteLine("\n---- Patient List: ----");
            Console.WriteLine("Patient Name\t\t| Patient Number |  Health Level |  Blood Level   |");
            Console.WriteLine("------------------------|----------------|---------------|----------------|");

            int i = 1;
            foreach (Patient element in PatientList)
            {
                Console.WriteLine($"{i++}. {element.Name} \t|  {element.PatientNumber}\t |     {element.HealthLevel}\t |    {element.BloodLevel}  \t  |");
            }

            Console.WriteLine(" ");
        }



    }
}
