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
    public partial class Delete : Form
    {
        public string[] splitline;
        public string[] splitcol;

        public class StudentData
        {
            public string StudName;
            public string StudID;
            public int StudMatricNo;
        }

        public Delete()
        {
            InitializeComponent();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            Dictionary<string, StudentData> Database = new Dictionary<string, StudentData>();
            
            try
            {
                // Read file
                System.IO.StreamReader fileread = new System.IO.StreamReader(@"D:\db.txt");
                string line;
                string[] splitline;
                string[] splitcol;

                while ((line = fileread.ReadLine()) != null)
                {
                    splitline = line.Split(new Char[] { '\n' });
                    splitcol = line.Split(new Char[] { ',' });

                    for (var i = 0; i < splitline.Count(); i++)
                    {
                        StudentData A = new StudentData() { StudName = splitcol[i + 2], StudMatricNo = int.Parse(splitcol[i + 1]) };
                        Database.Add(splitcol[i], A);
                    }
                }
                fileread.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("File is not exist.\n Error: " + ex.Message);
            }

            // Check if key match
            if (Database.ContainsKey(IDBox.Text))
            {
                Database.Remove(IDBox.Text);
                string tempfile = @"D:\temp.txt";

                // Write temporary file
                using (System.IO.StreamWriter filewrite = new System.IO.StreamWriter(tempfile, true))
                {
                    foreach (KeyValuePair<string, StudentData> x in Database)
                    {
                        filewrite.WriteLine(x.Key + "," + x.Value.StudMatricNo + "," + x.Value.StudName);
                    }

                    filewrite.Close();
                }

                // Delete prev file and replace with temporary file
                System.IO.File.Delete(@"D:\db.txt");
                System.IO.File.Move(tempfile, @"D:\db.txt");

                MessageBox.Show("Succesfully deleted user with ID " + IDBox.Text);
            }
            else
            {
                MessageBox.Show("No user with ID " + IDBox.Text);
            }

            ClearBox();
        }

        private void ClearBox()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}
