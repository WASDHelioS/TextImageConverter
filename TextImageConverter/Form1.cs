using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextImageConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ConvertTextToImage_Click(object sender, EventArgs e)
        {
            string input = TextBox.Text;
            List<Color> colors = input.ToByteArrayUTF8().ToColors();
            pictureBox.Image = colors.ToBitmap();
            TextBox.Text = "";
        }

        private void ConvertImageToText_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox.Image;
            string input = bmp.ToColors().ToByteArray().ToStringUTF8();
            TextBox.Text = input;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG(*.Png)|*.Png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(save.FileName, ImageFormat.Png);
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(Image.FromFile(open.FileName));
                
            }
        }
    }
}
