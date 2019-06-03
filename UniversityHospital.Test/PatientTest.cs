using System;
using UniversityHospital.cs;
using Xunit;

namespace UniversityHospital.Test
{
    public class PatientTest
    {
        private int number;
        [Fact]
        public void Doctor_Salary_Equal_90k()
        {
            Patient sut = new Patient("", number);

            Assert.Equal(90000, sut.PatientNumber);
        }

        [Fact]
        public void Patient_List_Values()
        {
            Patient sut = new Patient("", number);


        }

    }
}
