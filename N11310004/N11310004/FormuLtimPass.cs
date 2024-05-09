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
        public FormuLtimPass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int resuit = r.Next(100);
            MessageBox.Show(resuit.ToString());
        }
    }
}
