using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace N11310004
{
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,小菜,飲料\n", Encoding.UTF8);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("方塊已被按下");
            else 
                MessageBox.Show("方塊已被取消"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            String main = "", drinking = "", sidedishes = "";

            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                { 
                    CheckBox chk= (CheckBox)c;
                    if (chk.Checked)
                    {
                       main += chk.Text+"，";
                    }
                }
            }

            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                       drinking += chk.Text+"，";
                    }
                }
            }

            foreach (Control c in panel3.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        sidedishes+=chk.Text+"，";
                        // MessageBox.Show(chk.Text);
                    }
                }
            }
            main=main.Remove(main.Length-1, 1);
            drinking=drinking.Remove(drinking.Length-1, 1);
            sidedishes=sidedishes.Remove(sidedishes.Length-1, 1);

            DateTime currentDateTime= DateTime.Now;
            String orderTime = currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");

            File.AppendAllText("OrderData.csv",orderTime+","+ main+","+drinking+","+sidedishes+"\n");
            //MessageBox.Show("主餐:"+main+ "\n飲料:"+drinking+"\n小菜:"+sidedishes);
            MessageBox.Show("完成訂餐");
        }
    }
}
