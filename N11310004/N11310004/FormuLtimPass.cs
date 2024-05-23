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
    public partial class FormuLtimPass : Form
    {
        int min=0, max=100;
        int answer;
        public FormuLtimPass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                int input =Int32.Parse(textBox1.Text);
                if (input == this.answer)
                    MessageBox.Show("恭喜答對!");
                else if (input<= this.min)
                    MessageBox.Show("請輸入小於"+this.min);
                else if (input>= this.max)
                    MessageBox.Show("請輸入大於"+this.max);

                else if (input< this.answer)                
                    this.min=input;                               
                else if (input> this.answer)                
                    this.max=input;          
                label1.Text =string.Format("提示:請輸入{0}~{1}正整數", min, max);
            }
            catch(Exception el)
            {
                MessageBox.Show("輸入錯誤，請輸入數字");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            min = 0;
            max = 100;
            Random r = new Random();
           this.answer = r.Next(100);
            MessageBox.Show(answer.ToString());         
            label1.Text =string.Format("提示:請輸入{0}~{1}正整數",min,max);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
