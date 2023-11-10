using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    public class Diem
    {
        public double X { get; set; }   
        public double Y { get; set; }

        public Diem(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Diem() { }
    }
}
