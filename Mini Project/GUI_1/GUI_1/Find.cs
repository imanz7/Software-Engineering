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
    public partial class Find : Form
    {
        public string[] splitline;
        public string[] splitcol;
        public string dataKey;
        public string dataValue;
        public string message;
        public string result;
        public int status;

        public Find()
        {
            InitializeComponent();
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            status = 0;             // reset message status
            result = "";            // reset result

            try
            {   
                // Read file
                System.IO.StreamReader file = new System.IO.StreamReader(@"D:\db.txt");

                string line;
                Dictionary<string, string> data = new Dictionary<string, string>();

                while ((line = file.ReadLine()) != null)
                {
                    splitline = line.Split(new Char[] { '\n' });
                    splitcol = line.Split(new Char[] { ',' });

                    for (var i = 0; i < splitline.Count(); i++)
                    {
                        dataKey = splitcol[i + 2];          // Name
                        dataValue = splitcol[i + 1];        // Matric. No
                        data.Add(dataKey, dataValue);
                    }
                }
                file.Close();

                // Check if key match
                StringBuilder sb = new StringBuilder();
                foreach (var item in data)
                {
                    /*
                    //var punctuation = item.Key.Where(Char.IsPunctuation).Distinct().ToArray();
                    var words = item.Key.Split().Select(x => x.Trim(' '));
                    bool check = words.Contains(NameBox.Text, StringComparer.OrdinalIgnoreCase);
                    */
                    
                    bool check = item.Key.Split()
                                            .Select(x=>x.Trim(' '))
                                                .Contains(NameBox.Text, StringComparer.OrdinalIgnoreCase);
                    

                    if (check)
                    {
                        sb.AppendFormat("Matric No.: {0} \tName: {1}{2}", item.Value, item.Key, Environment.NewLine);
                        result = sb.ToString().TrimEnd();
                        status = 1;
                    }
                }

                Message(status);
            }
            catch (Exception ex)
            {
                MessageBox.Show("File is not exist.\n Error: " + ex.Message);
            }

            ClearBox();
        }
        
        private void Message(int message)
        {
            switch(message)
            {
                case 0:
                    MessageBox.Show("No user found.\n");
                    break;
                case 1:
                    MessageBox.Show("Found:\n\n" + result);
                    break;
                default:
                    break;
            }
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
