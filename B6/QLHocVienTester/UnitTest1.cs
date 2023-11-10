using B6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace QLHocVienTester
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestAddHocVien()
        {
            List<HocVien> list = new List<HocVien>();
            HocVien hv = new HocVien();
            hv.MaHV = TestContext.DataRow[0].ToString();
            hv.TenHV = TestContext.DataRow[1].ToString();
            hv.QueQuan = TestContext.DataRow[2].ToString();
            hv.Diem.M1 = double.Parse(TestContext.DataRow[3].ToString());
            hv.Diem.M2 = double.Parse(TestContext.DataRow[4].ToString());
            hv.Diem.M3 = double.Parse(TestContext.DataRow[5].ToString());
            list.Add(hv);
            Assert.IsNotNull(list);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
           @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestHocVienNhanHB()
        {
            HocVien hv = new HocVien();
            hv.MaHV = TestContext.DataRow[0].ToString();
            hv.TenHV = TestContext.DataRow[1].ToString();
            hv.QueQuan = TestContext.DataRow[2].ToString();
            hv.Diem.M1 = double.Parse(TestContext.DataRow[3].ToString());
            hv.Diem.M2 = double.Parse(TestContext.DataRow[4].ToString());
            hv.Diem.M3 = double.Parse(TestContext.DataRow[5].ToString());
            bool expected = bool.Parse(TestContext.DataRow[6].ToString());
            bool actual = hv.isThanhTichTot();
            Assert.AreEqual(expected, actual);
        }
    }
}
