using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractTest
{
    [TestClass]
    public class EmployeeManagerTests
    {
        [TestMethod]
        public void TestGetTotoalSalary()

        {


            var e1 = new abstract2.WorkerBee("Munir");
            var e2 = new abstract2.Boss("Adam");
            var employee = new abstract2.Employee[]
            {
               e1, e2
            };

            var expected = e1.GetSalary() + e2.GetSalary();
            var em = new abstract2.EmployeeManager();

            var actual = em.GetTotalSalary(employee);

            Assert.AreEqual(actual, expected);

        }
    }
}
