using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_1
{
    public partial class View : Form
    {
        public class StudentData
        {
            public string Name;
            public string ID;
            public int MatricNo;
        }

        public View()
        {
            InitializeComponent();
            listView.Items.Clear();
            fillBox();
        }

        private void fillBox()
        {
            try
            {
                // Read file
                System.IO.StreamReader file = new System.IO.StreamReader(@"D:\db.txt");
                string line;
                string[] splitline;
                string[] splitcol;

                while ((line = file.ReadLine()) != null)
                {
                    splitline = line.Split(new Char[] { '\n' });
                    splitcol = line.Split(new Char[] { ',' });

                    for (var i = 0; i < splitline.Count(); i++)
                    {
                        listView.Items.Add(new ListViewItem(new[] { splitcol[i], splitcol[splitcol.Count() - 2], splitcol[splitcol.Count() - 1] }));
                    }
                }
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("File is not exist.\n Error: " + ex.Message);
            }
        }
    }
}
