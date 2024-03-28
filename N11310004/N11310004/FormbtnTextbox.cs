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
    public partial class FormbtnTextbox : Form
    {
        public FormbtnTextbox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text box 被改變了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = tbInput.Text;
        }
    }
}
