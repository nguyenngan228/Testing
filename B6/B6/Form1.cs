using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B6
{
    public partial class Form1 : Form
    {
        ListHV list = new ListHV();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            HocVien hv = new HocVien();
            hv.MaHV = txtMaHV.Text;
            hv.TenHV = txtHoTen.Text;
            hv.QueQuan = txtQueQuan.Text;
            hv.Diem.M1 = double.Parse(txtDiem1.Text);
            hv.Diem.M2 = double.Parse(txtDiem2.Text);
            hv.Diem.M3 = double.Parse(txtDiem3.Text);
            list.addHV(hv);
        }

        private void btnXemList_Click(object sender, EventArgs e)
        {
            List<HocVien> listHB = list.listHVCoHB();
            foreach(HocVien hv in listHB)
            {
                listBox1.Items.Add(hv.MaHV);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
