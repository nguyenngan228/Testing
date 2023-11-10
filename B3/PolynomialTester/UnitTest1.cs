using B3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PolynomialTester
{
    [TestClass]
    public class UnitTest1
    {
        private Polynomial p;
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        //[TestMethod]
        public void TestPolynomial()
        {

            List<int> listA = new List<int>();
            int n = int.Parse(TestContext.DataRow[0].ToString());
            string l = TestContext.DataRow[2].ToString();
            for (int i = 1; i < l.Length; i++)
            {
                listA.Add(int.Parse(l[i].ToString()));
            }
            p = new Polynomial(n, listA);
            int epected = int.Parse(TestContext.DataRow[3].ToString());
            int x = int.Parse(TestContext.DataRow[1].ToString());
            int actual = p.Cal(x);
            Assert.AreEqual(epected, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Error()
        {
            List<int> listA = new List<int>();
            int n = int.Parse(TestContext.DataRow[0].ToString());
            string l = TestContext.DataRow[2].ToString();
            for (int i = 1; i < l.Length; i++)
            {
                listA.Add(int.Parse(l[i].ToString()));
            }
            p = new Polynomial(n, listA);
       
        }
    }
}
