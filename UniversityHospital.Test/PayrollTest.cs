using System;
using UniversityHospital.cs;
using Xunit;

namespace UniversityHospital.Test
{
    public class PayrollTest
    {
        [Fact]
        public void Add_Doctors_To_List()
        {
            Payroll sut = new Payroll();

            sut.AddEmployeeToList();

            Assert.True(6 == sut.employeeList.Count);
        }


    }
}
