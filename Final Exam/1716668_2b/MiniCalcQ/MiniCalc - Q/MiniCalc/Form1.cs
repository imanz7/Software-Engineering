using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalc
{
    public partial class MiniCalc : Form
    {
        public string input;
        public double valA;
        public double valB;
        public double total;
        public char operation;

        public MiniCalc()
        {
            InitializeComponent();
        }

        private void MiniCalc_Load(object sender, EventArgs e)
        {
            input = String.Empty;
        }

        private void add_Click(object sender, EventArgs e)
        {
            display.Text = "";
            operation = '+';
            input += operation;
            display.Text += input;
        }

        private void num_0_Click(object sender, EventArgs e)
        {
            display.Text = "";
            input += "0";
            display.Text += input;
        }

        private void num_1_Click(object sender, EventArgs e)
        {
            display.Text = "";
            input += "1";
            display.Text += input;
        }

        private void num_2_Click(object sender, EventArgs e)
        {
            display.Text = "";
            input += "2";
            display.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            display.Text = "";
            operation = '/';
            input += operation;
            display.Text += input;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            var temp = input.Split(operation);
            valA = (double)int.Parse(temp[0]);
            valB = (double) int.Parse(temp[1]);

            if(operation == '+')
            {
                total = valA + valB;
                display.Text = total.ToString();
            }

            else if (operation == '/')
            {
                try
                {
                    total = valA / valB;
                    display.Text = total.ToString();
                }

                catch (DivideByZeroException ex)
                {
                    MessageBox.Show("Input cannot be 0. \nError: ", ex.ToString());
                }
            }

            input = string.Empty;
        }
    }
}
