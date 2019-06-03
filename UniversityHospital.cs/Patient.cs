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


        public void NurseCare()
        {
                BloodLevel++;
                HealthLevel++;
            
        }

        public void NurseBloodDraw()
        {
                BloodLevel--;
                HealthLevel++;
           
        }

        public void DoctorBloodDraw()
        {
                BloodLevel -= 2;
                HealthLevel += 3;
                Console.WriteLine("Blood sample has been drawn and sent to the lab for testing.");
        }

        public void DoctorCare()
        {
            BloodLevel += 2;
            HealthLevel += 2;
        }

    }
}
