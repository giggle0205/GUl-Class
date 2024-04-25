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
    public partial class FormTryCatch : Form
    {
        public FormTryCatch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               // double input = Double.Parse(textBox1.Text);
               // button1.Text=(input+100).ToString();
                throw new IndexOutOfRangeException();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("輸入格式錯誤");
            }
            catch (Exception)
            {
                MessageBox.Show("⚠發生錯誤⚠");
            }
            finally
            {
                MessageBox.Show("執行到最後");
            }

        }
    }
}
