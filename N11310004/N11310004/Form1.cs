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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnButton_Click(object sender, EventArgs e)
        {

            if (btnButton.Text =="按鈕")
                btnButton.Text = "我已經被按過了";
            else if (btnButton.Text =="我已經被按過了")
                btnButton.Text ="按鈕";

        }
    }
}
