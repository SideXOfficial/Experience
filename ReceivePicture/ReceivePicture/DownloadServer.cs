using System;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ReceivePicture
{
    public partial class DownloadServer : Form
    {
        public DownloadServer()
        {
            InitializeComponent();
        }

        static TcpListener tcplictener;
        static NetworkStream stream;
        static TcpClient tcpClient;
        static Thread clientThread;

        private void Listen()
        {
            try
            {
                tcplictener = new TcpListener(IPAddress.Any, 8888);
                tcplictener.Start();
                clientThread = new Thread(new ThreadStart(Threadlictener));
                clientThread.IsBackground = true;
                clientThread.Start();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GetPicture()
        {
            byte[] data = new byte[1048576];
            byte[] bufferdata = new byte[0];
            bool flag = false;

            try
            {
                do
                {
                    stream.Read(data, 0, data.Length);
                    bufferdata = bufferdata.Concat(data).ToArray();
                    flag = true;
                }
                while (stream.DataAvailable);

                if (flag == true)
                {
                    MemoryStream stm = new MemoryStream(bufferdata);
                    stm.Position = 0;
                    this.ServerPictureBox.Image = Image.FromStream(stm);
                }
            }
            catch
            {
                if (stream != null) stream.Close();
                if (tcpClient != null) tcpClient.Close();
                tcpClient = null;
            }
        }

        private void DownloadServer_Load(object sender, EventArgs e)
        {
            Listen();
        }

        private void Threadlictener()
        {
            try
            {
                for (;;)
                {
                    if (tcpClient == null)
                    {
                        tcpClient = tcplictener.AcceptTcpClient();
                        stream = tcpClient.GetStream();
                    }
                    else
                    {
                        GetPicture();
                    }

                }
            }
            catch
            {
                if (stream != null) stream.Close();
                if (tcpClient != null) tcpClient.Close();
                tcpClient = null;
            }
        }

        internal static void Disconnect(object sender, EventArgs e)
        {
            tcplictener.Stop();
            if (stream != null) stream.Close();
            if (tcpClient != null) tcpClient.Close();
            Environment.Exit(0);
        }

    }
}
