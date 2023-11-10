using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtKQ.Text = "";
            double x = double.Parse(txtX.Text);
            double n = double.Parse(txtN.Text);
            txtKQ.Text = CalculatePower.Power(x, n).ToString();
        }
    }
}
