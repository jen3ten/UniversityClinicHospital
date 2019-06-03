using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Patient
    {
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

        //public void PatientList()
        //{
        //    Console.WriteLine("\n---- Patient List: ----");
        //    Console.WriteLine("Patient Name\t\t| Patient Number |  Health Level |  Blood Level   |");
        //    Console.WriteLine("------------------------|----------------|---------------|----------------|");

        //    int i = 1;
        //    foreach (Patient element in patientList)
        //    {
        //        Console.WriteLine($"{i++}. {element.Name} \t|  {element.PatientNumber}\t |     {element.HealthLevel}\t |    {element.BloodLevel}  \t  |");
        //    }

        //    Console.WriteLine(" ");
        //}


    }
}
