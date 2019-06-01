using System;
using UniversityHospital;
using Xunit;

namespace UniversityHospital.Tests
{
    public class DoctorTest
    {
        [Fact]
        public void Doctor_Salary_Equal_90k()
        {
            Doctor sut = new Doctor();

            sut.Doctor; 
            Assert.Equal(90000, )
        }
    }
}
