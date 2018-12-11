using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double f = double.Parse(textBox1.Text);
                double a = double.Parse(textBox2.Text);
                double fx = f * cos(a);
                double fy = f * sin(a);
                label1.Text = "Fx = " + fx + " N";
                label2.Text = "Fy = " + fy + " N";            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }

        double sin(double a)
        {
            return Math.Sin(a / 180.0 * Math.PI);
        }

        double cos(double a)
        {
            return Math.Cos(a / 180.0 * Math.PI);
        }

        double inverseSin(double a)
        {
            return Math.Asin(a)*180.0/Math.PI;
        }

        double inverseCos(double a)
        {
            return Math.Acos(a) * 180.0 / Math.PI;
        }

        double tan(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Tan(rad);
        }

        double inverseTan(double a)
        {
            return Math.Atan(a) * 180.0 / Math.PI;
        }
    }
}
