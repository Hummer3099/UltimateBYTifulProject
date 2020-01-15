using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class EmployeeTest
    {
        Employee TestEmployee = new Employee("Jan", "Kowalski", "02/08/1990", "+48123456789", "j.kowal@mymail.com",
            5000, "clerk");


        [TestMethod]
        public void GetSalaryTest()
        {
            double expectedSalary = 5000;
            double actualSalary = TestEmployee.Salary;

            Assert.AreEqual(expectedSalary, actualSalary, "Something went wrong");
        }

        [TestMethod]
        public void GetPositionTest()
        {
            string expectedPosition = "clerk";
            string actualPosition = TestEmployee.Position;

            Assert.AreEqual(expectedPosition, actualPosition, "Something went wrong");
        }
    }
}
