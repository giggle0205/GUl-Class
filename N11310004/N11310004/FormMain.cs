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
    public partial class FormMain : Form
    {
        public FormMain()
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
            Form formBMI = new FormBMI();
            formBMI.Show();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {         
            Form form = new FormButton();
            form.Show();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form formButTextbox = new FormbtnTextbox();
            formButTextbox.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form formOt = new FormOt();
            formOt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formCtoF = new FormCtoF();
            formCtoF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formTryCatchClick = new FormTryCatch();
            formTryCatchClick.Show();
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            Form formTimer = new FormTimer();
            formTimer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formuLtimPass = new FormuLtimPass();
            formuLtimPass.Show();
        }
    }
}
