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
            Doctor sut = new Doctor("", number, salary);


            Assert.Equal(90000, sut.Salary);
        }
    }
}
