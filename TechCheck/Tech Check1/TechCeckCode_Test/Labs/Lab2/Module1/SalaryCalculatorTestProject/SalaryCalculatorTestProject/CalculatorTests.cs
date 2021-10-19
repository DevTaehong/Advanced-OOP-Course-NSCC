using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class CalculatorTests
    {
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
            } catch (InvalidOperationException ex)
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
