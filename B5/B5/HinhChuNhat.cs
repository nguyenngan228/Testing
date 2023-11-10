using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    public class HinhChuNhat
    {
        private Diem dtt = new Diem();
        private Diem ddp = new Diem();

        public Diem DTT
        {
            get
            {
                return dtt;
            }
            set
            {
                dtt = value;
            }
        }
        public Diem DDP
        {
            get
            {
                return ddp;
            }
            set
            {
                ddp = value;
            }
        }

        public HinhChuNhat(Diem dTT, Diem dDP)
        {
            dtt = dTT;
            ddp = dDP;
        }

        public HinhChuNhat() { }

        public double tinhDienTichHCN()
        {
            double cd = Math.Abs(this.ddp.X - this.dtt.X);
            double cr = Math.Abs(this.ddp.Y - this.dtt.Y);
            return cd * cr;
        }


        public bool isGiaoNhau (HinhChuNhat hcn) {
           
            if (this.dtt.Y >= hcn.ddp.Y || hcn.dtt.Y >= this.ddp.Y)
                return false;

           
            if (this.dtt.X >= hcn.ddp.X || hcn.dtt.X >= this.ddp.X)
                return false;

            return true;
        }
    }
}
