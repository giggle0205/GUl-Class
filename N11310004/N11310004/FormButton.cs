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
            if (btnClick.Text =="核彈按鈕")
                btnClick.Text = "核彈已經飛越你家上空";          
            else if (btnClick.Text =="核彈已經飛越你家上空")
                btnClick.Text ="核彈按鈕";
        }
    }
}
