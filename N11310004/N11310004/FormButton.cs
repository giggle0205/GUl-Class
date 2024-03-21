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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnClick.Text =="導彈按鈕")
            {
                btnClick.Text = "導彈已經飛越你家上空";
                btnClick.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            }
            else if (btnClick.Text =="導彈已經飛越你家上空")
            {
                btnClick.Text ="導彈按鈕";
                btnClick.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            }
        }

        private void butlab_Click(object sender, EventArgs e)
        {
            label1.Text = "下方按鈕已經被按過";
            label1.Size = new System.Drawing.Size(200, 600);
            label1.BackColor = System.Drawing.Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butCount_Click(object sender, EventArgs e)
        {
            string tmp = labCount.Text;
            int sum = Int32.Parse(tmp)+1;
            labCount.Text = sum.ToString();
        }
    }
}
