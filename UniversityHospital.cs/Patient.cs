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

        public Patient(string name)
        {
            Name = name;
            //PatientNumber = number;
            HealthLevel = 20;
            BloodLevel = 10;
        }





        /*public void NurseCare()
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
        */

    }
}
