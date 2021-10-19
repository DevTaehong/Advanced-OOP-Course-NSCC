using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace SalaryCalculatorTestProject
{
    /*		
        To get hourly, divide annual salary by 2080     
        $100,006.40 / 2080 = $48.08  hr

        To get annual, multiply hourly by 2080 
        $48.08 * 2080 = $100,006.40
    */

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
        public void FiscalYearSalaryTestNegative()
        {
            //Arrange
            SalaryCalculator newObject = new SalaryCalculator();
            //Act
            try
            { // A negative test. Should throw an exception
                decimal annualSalary = newObject.GetAnnualSalary(-45000);
                //Assert
                Assert.Fail("This code should not be run. Exception expected.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Hourly wage must not be less than zero.", ex.Message);
            }
        }


        [TestMethod]
        public void FiscalYearHourlyWageNegative()
        {
            //Arrange
            SalaryCalculator newObject = new SalaryCalculator();
            //Act
            try
            { // A negative test. Should throw an exception
                decimal hourlyWage = newObject.GetHourlyWage(0);
                //Assert
                Assert.Fail("This code should not be run. Exception expected.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Yearly salary must be greater than zero.", ex.Message);
            }
        }

        [TestMethod]
        public void CraTaxCalculatingTest()
        {
            //Arrange
            SalaryCalculator newObject = new SalaryCalculator();
            //Act
            EmpData empData = newObject.EmpAccount(1500, 3);
            //Assert
            Assert.AreEqual(375.0, empData.TaxAmount);
            Assert.AreEqual(225.0, empData.DependentDeduction);
            Assert.AreEqual(150.0, empData.NetTaxAmount);
            Assert.AreEqual(1350.0, empData.TotalTakeHome);
        }

        [TestMethod]
        public void CraTaxTestNoChildren()
        {
            //Arrange
            SalaryCalculator newObject = new SalaryCalculator();
            //Act
            EmpData empData = newObject.EmpAccount(3000, 0);
            //Assert
            Assert.AreEqual(750.0, empData.TaxAmount);
            Assert.AreEqual(0, empData.DependentDeduction);
            Assert.AreEqual(750.0, empData.NetTaxAmount);
            Assert.AreEqual(2250.0, empData.TotalTakeHome);
        }


    }
}
