using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Doctor : Employee

    {
        Doctor dr;
        public string SpecialtyArea { get; set; }

        public Doctor(string name, int number, int salary) : base("", number, 90000)
        {
            Doctor dr1 = new Doctor("Francona, Terry", 8561, Salary);
            Doctor dr2 = new Doctor("Roth, Elise", 8213, Salary);
            Doctor dr3 = new Doctor("Dolson, Miranda", 8497, Salary);
            Doctor dr4 = new Doctor("Sandhu, Cory", 8109, Salary);
            Doctor dr5 = new Doctor("Messaros, Kyle", 8670, Salary);
        }

    }
}
