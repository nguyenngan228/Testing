using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    public class HocVien
    {
        public string  MaHV { get;set; }
        public string TenHV { get;set; }
        public string QueQuan { get;set; }
        private Diem diem= new Diem();

        public Diem Diem
        {
            get
            {
                return this.diem;
            }
            set
            {
                this.diem = value;
            }
        }

        public HocVien (string maHV, string tenHV, string queQuan, Diem diem)
        {
            this.MaHV = maHV;
            this.TenHV = tenHV;
            this.QueQuan = queQuan;
            this.diem = diem;
        }

        public HocVien()
        {

        }

        public double tinhDTB (double a, double b, double c)
        {
            return (a + b + c) / 3.0;
        }

        public bool isThanhTichTot()
        {
            double dtb = tinhDTB (this.diem.M1, this.diem.M2,this.diem.M3);
            return dtb >= 8.0 && this.diem.M1 >= 5 && this.diem.M2 >= 5 && this.diem.M3 >= 5;
        }
    }
}
