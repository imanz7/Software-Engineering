using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1920_2c
{
    public partial class Form1 : Form
    {
        SerialPort sp = new SerialPort();

        public Form1()
        {
            InitializeComponent();

            
            sp.PortName = "COM1";
            sp.BaudRate = 15200;
            sp.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_on_Click(object sender, EventArgs e)
        {
            PortWrite("1");
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            PortWrite("0");
        }

        private void PortWrite(string message)
        {
            if (sp != null && sp.IsOpen)
            {
                sp.Write(message);
            }
        }
    }
}
