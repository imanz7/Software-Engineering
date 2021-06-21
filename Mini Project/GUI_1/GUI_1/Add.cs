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
    public partial class Add : Form
    {
        public int i;

        public Add()
        {
            InitializeComponent();
            i = Properties.Settings.Default.TempVal;    // use default TempVal value stored in the system (setting)
            ID_box.Text = "MCT" + i;
        }

        public class StudentData
        {
            public string ID;
            public int Matric;
            public string Name;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            StudentData A = new StudentData();
            Dictionary<string, StudentData> Database = new Dictionary<string, StudentData>();

            try
            {
                A.Matric = int.Parse(matric_box.Text);
                A.Name = name_box.Text;
                A.ID = ID_box.Text;

                // Add data to dictionary
                Database.Add(ID_box.Text, A);

                // Write file
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\db.txt", true))
                {
                    file.WriteLine(A.ID + "," + A.Matric + "," + A.Name);
                    file.Close();
                }
                MessageBox.Show("Succesfully added user " + name_box.Text + " with ID " + ID_box.Text);

                i++;
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Error:\nThe input must be a number.", ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Sorry. Unexpected error: " + ex.Message);
            }

            ClearBox();

            ID_box.Text = "MCT" + i;
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            var temp = ID_box.Text.Split('T');                          // split MCT with ID value
            Properties.Settings.Default.TempVal = int.Parse(temp[1]);   // store current ID value
            i = Properties.Settings.Default.TempVal;                    // store TempVal value even after add window closed
            Properties.Settings.Default.Save();                         // update TempVal value in system even after main form closed
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

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
