using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N11310004
{
    public partial class FormBMI : Form
    {
        public FormBMI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
                a= 0;
                b= 0;
            }
            double sum = a/(b*b)*10000;
            double roundSum=Math.Round(sum,0);
            label3.Text = roundSum.ToString();
        }
    }
}
