using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summ
{
    public partial class Form1 : Form
    {
        double a, b, sum;
        string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            sum = a + b;
            result = sum.ToString();
            //MessageBox.Show(result);
            button1.Text = result;
        }
       
    }
}
