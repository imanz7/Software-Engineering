using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int result;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            try
            {
                result = int.Parse(textBox1.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: "+ a);
            }

            var win2 = new Form2(result);
            win2.Show();
            win2.FormClosed += (s, z) => button1.Enabled = true;

            /*
            Thread t1 = new Thread(() =>
            {
                new Form2().Show();
            });
            t1.Start();
            t1.Join();
            */

            //Thread thread = new Thread(WriteY);
            //thread.Start();
            //thread.Join(); //The main thread will be blocked until the child thread ends
            //WriteX();
        }

        static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
        }
        static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }

        

    }
}
