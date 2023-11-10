using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int a1 = int.Parse(txtA1.Text);
            int a2 = int.Parse(txtA2.Text);
            List<int> listA = new List<int>();
            listA.Add(a1);
            listA.Add(a2);
            Polynomial p = new Polynomial(n, listA);
            int x = int.Parse(txtX.Text);
            txtKQ.Text = p.Cal(x).ToString();

        }
    }
}
