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

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                 a = Int32.Parse(textBox2.Text);
                 b = Int32.Parse(textBox3.Text);
            }
            catch (System.FormatException) 
            {
                MessageBox.Show("請輸入數字");
                a= 0;
                b= 0;
            }
            int sum = a+b;
            label4.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(textBox5.Text);
                b = Int32.Parse(textBox4.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
                a= 0;
                b= 0;
            }
                int sum = a-b;
                label5.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(textBox7.Text);
                b = Int32.Parse(textBox6.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
                a= 0;
                b= 0;
            }
            int sum = a*b;
            label8.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                 a = Int32.Parse(textBox9.Text);
                 b = Int32.Parse(textBox8.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
                a= 0;
                b= 1;
            }
            int sum = a/b;
            label11.Text = sum.ToString();
        }
    }
}
