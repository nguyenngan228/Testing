using B5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HinhChuNhatTester
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestDienTichHCN()
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.DTT.X = double.Parse(TestContext.DataRow[0].ToString());
            hcn.DTT.Y = double.Parse(TestContext.DataRow[1].ToString());
            hcn.DDP.X = double.Parse(TestContext.DataRow[2].ToString());
            hcn.DDP.Y = double.Parse(TestContext.DataRow[3].ToString());
            double expected = double.Parse(TestContext.DataRow[4].ToString());
            double actual = hcn.tinhDienTichHCN();
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
   @".\Data\TestData_2HCNGiaoNhau.csv", "TestData_2HCNGiaoNhau#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Test2HCNGiaoNhau()
        {
            HinhChuNhat hcn1 = new HinhChuNhat();
            hcn1.DTT.X = double.Parse(TestContext.DataRow[0].ToString());
            hcn1.DTT.Y = double.Parse(TestContext.DataRow[1].ToString());
            hcn1.DDP.X = double.Parse(TestContext.DataRow[2].ToString());
            hcn1.DDP.Y = double.Parse(TestContext.DataRow[3].ToString());
            HinhChuNhat hcn2 = new HinhChuNhat();
            hcn2.DTT.X = double.Parse(TestContext.DataRow[4].ToString());
            hcn2.DTT.Y = double.Parse(TestContext.DataRow[5].ToString());
            hcn2.DDP.X = double.Parse(TestContext.DataRow[6].ToString());
            hcn2.DDP.Y = double.Parse(TestContext.DataRow[7].ToString());

            bool expected = bool.Parse(TestContext.DataRow[8].ToString());
            bool actual = hcn1.isGiaoNhau(hcn2);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
