using System;
using UniversityHospital.cs;
using Xunit;

namespace UniversityHospital.Test
{
    public class DoctorTest
    {
        public string name;
        public int number;
        public int salary; 

        [Fact]
        public void Doctor_Salary_Equal_90k()
        {
            Doctor doctor = new Doctor("", 19504, "", "");
            /*Doctor dr1 = new Doctor("Francona, Terry", 8561, salary);
            Doctor dr2 = new Doctor("Roth, Elise", 8213, salary);
            Doctor dr3 = new Doctor("Dolson, Miranda", 8497, salary);
            Doctor dr4 = new Doctor("Sandhu, Cory", 8109, salary);
            Doctor dr5 = new Doctor("Messaros, Kyle", 8670, salary);*/



            Assert.Equal("90,000", doctor.Salary);
        }
    }
}
