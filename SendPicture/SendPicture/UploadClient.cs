using System;
using System.Net.Sockets;
using System.Drawing;
using System.Windows.Forms;

namespace SendPicture
{
    public partial class UploadClient : Form
    {
        public UploadClient()
        {
            InitializeComponent();
        }
        private static string Link_of_picture;
        private static Image MyImage;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                Link_of_picture = OFD.FileName;
                MyImage = new Bitmap(Link_of_picture);
                UploadPictureBox.Image =(Image)MyImage;
                SendPicture(sender, e);
            }
        }

        private static byte[] ImageToByte()
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(MyImage, typeof(byte[]));
        }

        private void SendPicture(object sender, EventArgs e)
        {
            try
            {
                byte[] data = ImageToByte();
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect(sender, e);
            }
        }

        private void UploadClient_Load(object sender, EventArgs e)
        {
            client = new TcpClient();
            try
            {
                client.Connect(host, port);
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect(sender, e);
            }
        }

        internal static void Disconnect(object sender, EventArgs e)
        {
            if (stream != null) stream.Close();
            if (client != null) client.Close();
            Environment.Exit(0);
        }

    }
}
