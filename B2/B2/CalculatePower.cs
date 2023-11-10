using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    public class CalculatePower
    {
        private double x {  get; set; }
        private double n { get; set; }

        public CalculatePower(double x, double n)
        {
            this.x = x;
            this.n = n;
        }
        public static double Power(double x, double n)
        {

            if (n == 0)
                return 1.0;
            if (n > 0)
                return x * Power(x, n - 1);
            else
                return 1 / (x * Power(x, -n - 1));

        }
    }
}
