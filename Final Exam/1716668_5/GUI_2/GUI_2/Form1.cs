using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace GUI_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t1 = new Thread(listen);
            t1.Start();
            t1.IsBackground = true;
            //successfully received image
            Display();
        }
        
        private void listen()
        {
            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 4327;
                IPAddress localAddr = IPAddress.Any;

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                int readPoint = 0;
                int chunkSize = 256;
                Byte[] bytes = new Byte[256];
                //String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    Socket socketToHandleRequest = server.AcceptSocket(); //accept client request.
                    NetworkStream network = new NetworkStream(socketToHandleRequest);
                    //TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");



                    Stream fileForWrite = File.OpenWrite("D:\\Image.jpg");// write file to desktop
                    while (true)
                    {
                        readPoint = network.Read(bytes, 0, chunkSize);
                        fileForWrite.Write(bytes, 0, readPoint);
                        if (readPoint == 0)
                        {
                            //end of the file read from client
                            break;
                        }
                    }
                    fileForWrite.Close(); // Close file

                                        socketToHandleRequest = null; // assign null to release memeory.
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Display()
        {
            Thread a = new Thread(() =>
            {
                Image img = Image.FromFile("D:\\Image.jpg");
                PictureBox.Image = img;
            });
        }
    }
}
