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
            Doctor doctor = new Doctor("", 19504, "");



            Assert.Equal("90,000", doctor.Salary);
        }

        [Fact]
        public void Doctor_Switches_To_Pait()
        {
            Doctor sut = new Doctor("", 19500, "");
            Payroll payroll = new Payroll();
            //foreach(Doctor element in doctorList)
            {
                sut.PaySalary();

            }

            Assert.True(sut.Payment);
        }
    }
}
