using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace B6
{
    public class ListHV
    {
        List<HocVien> list = new List<HocVien>();

        public List<HocVien> List { get { return this.list; }}

        public void addHV(HocVien hv)
        {
            this.list.Add(hv);
        }

        public List<HocVien> listHVCoHB()
        {
            List<HocVien> list = new List<HocVien>();
            foreach(HocVien hv in  this.list)
            {
                if (hv.isThanhTichTot())
                {
                    list.Add(hv);
                }
            }
            return list;
        }
    }
}
