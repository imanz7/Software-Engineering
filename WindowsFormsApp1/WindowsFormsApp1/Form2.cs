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
    public partial class Form2 : Form
    {
        private int res;

        public Form2(int result)
        {
            InitializeComponent();
            res = result;

            label1.Text = "The value enter: " + res.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            var awaiter = GetPrimesCountAsync(res).GetAwaiter();

            awaiter.OnCompleted(() =>
            {
                label1.Text = "There are " + awaiter.GetResult().ToString() + " primes";
                button1.Enabled = true;
            });
        }

        Task<int> GetPrimesCountAsync(int max) //Asynchronous function
        {
            
            return Task.Run(() =>
            ParallelEnumerable
                    .Range(2, max-1)
                        .Count(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1)
                            .All(i => n % i != 0)));
            
            /*
            return Task.Run(() =>
            ParallelEnumerable
                    .Range(2, max-1)
                    .Where(z=> Enumerable.Range(2, (int)Math.Sqrt(z) - 1)
                    .All(i => z % i != 0))
                    .Count());
            */
        }
    }
}
