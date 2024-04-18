using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N11310004
{
    public partial class FormCtoF : Form
    {
        public FormCtoF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
   
            a = Int32.Parse(textBox1.Text);                   
            double sum = a*9/5+32;
            label3.Text = sum.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
