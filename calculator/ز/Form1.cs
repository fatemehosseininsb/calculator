using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ز
{
    public partial class Form1 : Form
    {
        Calculate Calculator;
        public Form1()
        {
            InitializeComponent();
            Calculator = new Calculator();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        bool Isvalid()
        {
            bool valid = true;
            if(GetNum1.Value == 0)
            {
                valid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else
            {
                if(GetNum2.Value == 0)
                {
                    valid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");

                }
            }
            return true;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                int sum = Calculator.sum((int)GetNum1.Value, (int)GetNum2.Value);
                answer.Text = "the answer is:" + sum;
            }
        }

        private void minuse_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                int minuse = Calculator.minuse((int)GetNum1.Value, (int)GetNum2.Value);
                answer.Text = "the answer is: " + minuse; 
            }
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                int multiple = Calculator.multiple((int)GetNum1.Value, (int)GetNum2.Value);
                answer.Text = "the answer is: " + multiple;
            }

        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                int Divide = Calculator.divide((int)GetNum1.Value, (int)GetNum2.Value);
                answer.Text = "the answer is: " + Divide;
            }
        }
    }
}
