using System;
using System.Windows.Forms;
using CalcWinForm.Properties;
using MethodsLibrary;

namespace CalcWinForm
{
    public partial class Calculator : Form
    {
        private double? lastValue;
        private int sign;
        public Calculator()
        {
            InitializeComponent();
        }


        private void zero_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_zero_Click__0;
        }

        private void one_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_one_Click__1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_two_Click__2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_three_Click__3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_four_Click__4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_five_Click__5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_six_Click__6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_seven_Click__7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_eight_Click__8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + Resources.Calculator_nine_Click__9;
        }

        private void div_Click(object sender, EventArgs e)
        {
            var value = Double.Parse(input.Text);
            if (lastValue == null)
            {
                lastValue = value;
            }
            else
            {
                lastValue = MathMethods.Calculate((double)lastValue, value, sign);
            }
            textBox_result.Text = lastValue + " /";
            sign = 4;
            input.Text = "";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            var value = Double.Parse(input.Text);
            if (lastValue == null)
            {
                lastValue = value;
            }
            else
            {
                lastValue = MathMethods.Calculate((double)lastValue, value, sign);
            }
            textBox_result.Text = lastValue + " x";
            sign = 3;
            input.Text = "";
        }

        private void diff_Click(object sender, EventArgs e)
        {
            var value = Double.Parse(input.Text);
            if (lastValue == null)
            {
                lastValue = value;
            }
            else
            {
                lastValue = MathMethods.Calculate((double)lastValue, value, sign);
            }
            textBox_result.Text = lastValue + " -";
            sign = 2;
            input.Text = "";
        }

        private void summ_Click(object sender, EventArgs e)
        {
            var value = Double.Parse(input.Text);
            if (lastValue == null)
            {
                lastValue = value;
            }
            else
            {
                lastValue = MathMethods.Calculate((double)lastValue, value, sign);
            }
            textBox_result.Text = lastValue + " +";
            sign = 1;
            input.Text = "";
        }

        private void result_Click(object sender, EventArgs e)
        {
            var value = Double.Parse(input.Text);
            if (lastValue == null)
            {
                lastValue = value;
            }
            else
            {
                lastValue = MathMethods.Calculate((double)lastValue, value, sign);
            }
            input.Text = lastValue.ToString();
            textBox_result.Text = "";
            lastValue = null;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            input.Text = "";
            textBox_result.Text = "";
            lastValue = null;
        }
    }
}
