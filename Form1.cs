using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimTrainer
{
    public partial class Form1 : Form
    {
        Image terr = Image.FromFile("terr.png");
        Image terar = (Image)(new Bitmap(Image.FromFile("terr.png"), new Size(30, 30)));
        Image swat = Image.FromFile("swat.png");
        Image back = Image.FromFile("back.png");
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = back; 
            //new Bitmap((@"C:\Users\Mena\Desktop\1.png"), new Point(182, 213)
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(terar, 12, 12);
            }
            pictureBox1.Image = bmp;
        }
    }
}
