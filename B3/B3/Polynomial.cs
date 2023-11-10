using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    public class Polynomial
    {
        private int n;
        private List<int> a;

        public Polynomial(int n, List<int> a)
        {
            //a là list: các hệ số do người dùng nhập vào
            //n là bậc của đa thức
            if (a.Count != n + 1 || n < 0)
                throw new ArgumentException("Invalid Data");
            this.n = n;
            this.a = a;
        }

        public int Cal (double x)
        {
            int result = 0;
            for(int i = 0; i <= this.n;  i++)
            {
                result += (int)(a[i] * Math.Pow(x, i));
            }
            return result;
        }
    }
}
