using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Doctor : Employee

    {
        Doctor dr;
        public string SpecialtyArea { get; set; }
        public int Salary { get; set; }

        public Doctor() : base("", int number,"")
        {
            Position = "Doctor";
            Salary = 90000;
        }

            Doctor dr1 = new Doctor("Francona, Terry", 8561, "");
            Doctor dr2 = new Doctor("Roth, Elise", 8213, "");
            Doctor dr3 = new Doctor("Dolson, Miranda", 8497, "");
            Doctor dr4 = new Doctor("Sandhu, Cory", 8109, "");
            Doctor dr5 = new Doctor("Messaros, Kyle", 8670, "");
    }
}
