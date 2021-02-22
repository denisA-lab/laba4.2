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
    public partial class Form2 : Form
    {
        Model model;
        public Form2()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);//подписка формы на обн

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            model.setValue(decimal.ToInt32(numericUpDown1.Value), decimal.ToInt32(numericUpDown2.Value));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            model.setValue(decimal.ToInt32(numericUpDown1.Value), decimal.ToInt32(numericUpDown2.Value));
        }
        private void UpdateFromModel(object sender, EventArgs e)//список подписок
        {
            button3.Text = model.getValue1().ToString();
            numericUpDown1.Value = model.getValue1();
            progressBar1.Value = decimal.ToInt32(model.getValue1());
            textBox1.Text = model.getValue1().ToString();

            button2.Text = model.getValue2().ToString();
            numericUpDown2.Value = model.getValue2();
            progressBar2.Value = decimal.ToInt32(model.getValue2());
            textBox2.Text = model.getValue2().ToString();
        }
    }

    public class Model//модель
    {
        private int value1;
        private int value2;
        public System.EventHandler observers;
        public void setValue(int value1, int value2)
        {
            if (value1 > value2)//1 всегда больше
                this.value1 = value1;
            else this.value1 = value2 + 1;
            if (value2 >= value1)
                this.value2 = value1 - 1;
            else this.value2 = value2;
            observers.Invoke(this, null);
        }
        public int getValue1()
        {
            return value1;
        }
        public int getValue2()
        {
            return value2;
        }
    }
}
