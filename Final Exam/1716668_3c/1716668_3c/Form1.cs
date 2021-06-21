using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1716668_3c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_en.Click += (a, e) => { textBox2.Text = Encrypt(textBox1.Text, "IIUMMCTE"); };
            btn_de.Click += (s, e) => textBox1.Text = Decrypt(textBox2.Text, "IIUMMCTE");
            Find();
        }
        private void Find()
        {

        }

        private void btn_en_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_de_Click(object sender, EventArgs e)
        {

        }

        public string Encrypt(string plantext, string key)
        {
            byte[] message = Encoding.ASCII.GetBytes(textBox1.Text);
            byte[] key_bytes = Encoding.ASCII.GetBytes("iium4372");

            var provider = new DESCryptoServiceProvider();
            var stream = new MemoryStream();

            var cryptoStream = new CryptoStream(stream, provider.CreateEncryptor(key_bytes, key_bytes), CryptoStreamMode.Write);
            cryptoStream.Write(message, 0, message.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encrypted = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(encrypted, 0, encrypted.Length);
            return Convert.ToBase64String(encrypted); //Convert to base64 representation (otherwise textbox cannot display)
        }
        public string Decrypt(string ciphertext, string key)
        {
            try
            {
                byte[] message = Convert.FromBase64String(textBox2.Text);
                byte[] key_bytes = ASCIIEncoding.ASCII.GetBytes("iium4372");

                var provider = new DESCryptoServiceProvider();
                var stream = new MemoryStream();

                var cryptoStream = new CryptoStream(stream, provider.CreateDecryptor(key_bytes, key_bytes), CryptoStreamMode.Write);
                cryptoStream.Write(message, 0, message.Length);
                cryptoStream.FlushFinalBlock();

                byte[] decrypted = new byte[stream.Length];
                stream.Position = 0;
                stream.Read(decrypted, 0, decrypted.Length);
                return Encoding.ASCII.GetString(decrypted);
            }
            catch
            {
                return "Error";
            }
            
        }
    }
}
