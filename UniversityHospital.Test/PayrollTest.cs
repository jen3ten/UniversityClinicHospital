using System;
using UniversityHospital.cs;
using Xunit;

namespace UniversityHospital.Test
{
    public class PayrollTest
    {
        Nurse nurse;
        [Fact]
        public void Add_Doctors_To_List()
        {
            Payroll sut = new Payroll();

            //sut.AddEmployeeToList();

            //Assert.True(6 == sut.employeeList.Count);
        }

        [Fact]
        public void Nurse_Payment()
        {
            Payroll sut = new Payroll();
            nurse = new Nurse("", 0, "","");
            //nurse.PaySalary;

        }

        [Fact]
        public void Nurse_Blood_Draw()
        {
            Payroll sut = new Payroll();
            Patient patient = new Patient("");

            //patient.NurseBloodDraw();
            sut.NurseDraw();

            Assert.Equal(11, patient.HealthLevel);
        }



    }
}
