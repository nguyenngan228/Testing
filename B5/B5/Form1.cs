using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhDT_Click(object sender, EventArgs e)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.DTT.X = double.Parse(txtX1.Text);
            hcn.DTT.Y = double.Parse(txtY1.Text);
            hcn.DDP.X = double.Parse(txtX2.Text);
            hcn.DDP.Y = double.Parse(txtY2.Text);   

            txtKQ.Text = hcn.tinhDienTichHCN().ToString();
        }

        private void btnKiemTraGiaoNhau_Click(object sender, EventArgs e)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.DTT.X = double.Parse(txtX1.Text);
            hcn.DTT.Y = double.Parse(txtY1.Text);
            hcn.DDP.X = double.Parse(txtX2.Text);
            hcn.DDP.Y = double.Parse(txtY2.Text); 

            HinhChuNhat hcn2 = new HinhChuNhat();
            hcn2.DTT.X = double.Parse(txtX1O.Text);
            hcn2.DTT.Y = double.Parse(txtY1O.Text);
            hcn2.DDP.X = double.Parse(txtX2O.Text);
            hcn2.DDP.Y = double.Parse(txtY2O.Text);

            txtKQGiaoNhau.Text = hcn.isGiaoNhau(hcn2).ToString();
        }
    }
}
