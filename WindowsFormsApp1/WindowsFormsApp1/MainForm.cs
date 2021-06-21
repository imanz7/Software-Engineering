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

namespace GUI_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Properties.Settings.Default.TempVal = 1;        

            //btn_add.Click += (a, e) => new Add().ShowDialog();

            btn_view.Click += (a, e) => new View().ShowDialog();

            btn_delete.Click += (a, e) => new Delete().ShowDialog();

            btn_find.Click += (a, e) => new Find().ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            Thread t1 = new Thread (() =>
            {
                new Add().Show();
            });
            t1.Start();
            t1.Join();

            btn_add.Enabled = true;
        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {

        }
    }
}
