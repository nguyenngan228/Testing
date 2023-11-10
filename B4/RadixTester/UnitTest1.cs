using B4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RadixTester
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]

        public void TestRadix()
        {
            int num = int.Parse(TestContext.DataRow[0].ToString());
            Radix r = new Radix(num);
            int radix = int.Parse(TestContext.DataRow[1].ToString());
            string s = TestContext.DataRow[2].ToString();
            string expected = s.Substring(1);
            string s2 = r.ConvertDecimalToAnother(radix);
            string[] arrS2 = s2.Split(new char[] { ',' });
            string actual = String.Join("", arrS2);
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        //[TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestError()
        {
            int num = int.Parse(TestContext.DataRow[0].ToString());
            Radix r = new Radix(num);
            int radix = int.Parse(TestContext.DataRow[1].ToString());
            string s2 = r.ConvertDecimalToAnother(radix);
        }

    }
}
