using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouseclick
{
    public partial class Form1 : Form
    {

        int times = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            times = times + 1;
            timesLabel.Text = "你已經點了" + times + "下";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            times = 0;//times歸零
            timesLabel.Text = "你已經點了" + times + "下";
        }
    }
}
