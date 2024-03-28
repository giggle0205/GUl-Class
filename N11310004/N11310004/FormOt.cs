using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11310004
{
    public partial class FormOt : Form
    {
        public FormOt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = label1.Text;
            int sum = Int32.Parse(tmp)-1;
            label1.Text = sum.ToString();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string tmp = label1.Text;
            int sum = Int32.Parse(tmp)+1;
            label1.Text = sum.ToString();
        }
    }
}
