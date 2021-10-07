using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert
            Assert.AreEqual(104000, annualSalary);

        }

        [TestMethod]
        public void AnnualSalaryTestNegative()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            try
            { // A negative test. Should throw an exception
                decimal annualSalary = sc.GetAnnualSalary(-50);
                //Assert
                Assert.Fail("This code should not be run. Exception expected.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Hourly wage must be greater than zero.", ex.Message);
            }
        }


        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(52000);

            // Assert
            Assert.AreEqual(25, hourlyWage);

        }

        [TestMethod]
        public void AnnualHourlyWageNegative()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();
            //Act
            try
            { // A negative test. Should throw an exception
                decimal hourlyWage = sc.GetHourlyWage(0);
                //Assert
                Assert.Fail("This code should not be run. Exception expected.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Yearly salary must be greater than zero.", ex.Message);
            }
        }//end AnnualHourlyWageNegative

    }
}
