using B2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PowerTester
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Test_Power()
        {
            double expected, actual;
            double a = double.Parse(TestContext.DataRow[0].ToString());
            double b = double.Parse(TestContext.DataRow[1].ToString());
            expected = double.Parse(TestContext.DataRow[2].ToString());
            actual = CalculatePower.Power(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
