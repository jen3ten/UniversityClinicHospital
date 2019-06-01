using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital.cs
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set;  }

        public Nurse() : base("")
        {
            NumberOfPatients = 8;
        }


    }
}
