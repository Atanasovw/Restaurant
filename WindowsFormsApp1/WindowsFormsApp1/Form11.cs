using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            double paygr1 = (int.Parse(textBox1.Text) * 7.40) + (int.Parse(textBox2.Text) * 8.60) + (int.Parse(textBox3.Text) * 9.70);
            double paygr2 = (int.Parse(textBox4.Text) * 4.98) + (int.Parse(textBox5.Text) * 5.99) + (int.Parse(textBox6.Text) * 3.85);
            double paygr3 = (int.Parse(textBox7.Text) * 3.50) + (int.Parse(textBox8.Text) * 4.00) + (int.Parse(textBox9.Text) * 2.80);
            double pay = paygr1 + paygr2+paygr3;
            MessageBox.Show(pay.ToString()+ "лева");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
            groupBox3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
        }
    }
}
