using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                numericUpDown1.Value = numericUpDown1.Value;
            }
            else numericUpDown1.Value = numericUpDown2.Value + 1;
            progressBar1.Value = decimal.ToInt32(numericUpDown1.Value);
            button1.Text = numericUpDown1.Value.ToString();
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value >= numericUpDown1.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value - 1;
            }
            else numericUpDown2.Value = numericUpDown2.Value ;
            progressBar2.Value = decimal.ToInt32(numericUpDown2.Value);
            button2.Text = numericUpDown2.Value.ToString();
            textBox2.Text = numericUpDown2.Value.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
