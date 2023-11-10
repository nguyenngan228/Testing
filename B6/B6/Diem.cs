using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    public class Diem
    {
        public double M1 { get;set; }
        public double M2 { get;set; }
        public double M3 { get;set; }

        public Diem (double m1, double m2, double m3)
        {
            this.M1 = m1;
            this.M2 = m2;
            this.M3 = m3;
        }

        public Diem()
        {

        }
    }
}
