using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMDeteccaoRostos
{
    public partial class FRMDeteccaoRosto : Form
    {
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        VideoCapture VideoCapture;
        public FRMDeteccaoRosto()
        {
            InitializeComponent();
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    processarImage(new Bitmap(Image.FromFile(ofd.FileName)));
                }
            }
        }

        private void iniciarWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VideoCapture != null)
            {
                MessageBox.Show("Captura de video já inciada");
                return;
            }
            VideoCapture = new VideoCapture(0);
            VideoCapture.ImageGrabbed += Capture_ImageGrabbed;
            VideoCapture.Start();
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                VideoCapture.Retrieve(m);
                processarImage(m.Bitmap);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pararWebCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VideoCapture == null)
            {
                MessageBox.Show("A captura de video está finalizada");
            }
            VideoCapture.ImageGrabbed -= Capture_ImageGrabbed;
            VideoCapture.Stop();
            VideoCapture.Dispose();
            VideoCapture = null;
            picImage.Image = null;
        }

        private void processarImage(Bitmap bitmap)
        {
            Image<Bgr, byte> graytImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(graytImage, 1.1, 1);
            foreach (var rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Red, 3))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }
            picImage.Image = bitmap;
        }
    }
}
