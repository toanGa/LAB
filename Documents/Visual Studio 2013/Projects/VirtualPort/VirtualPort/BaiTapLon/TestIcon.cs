using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort.BaiTapLon
{
    public partial class TestIcon : Form
    {
        Rectangle rect;
        Icon icon;
        Image image;

        Rectangle toan;
        Graphics graphic;

        public TestIcon()
        {
            InitializeComponent();

            toan = new Rectangle(100, 100, 50, 50);
            image = VirtualPort.Properties.Resources.bowling;

            //DrawIcon();
        }

        

        void DrawIcon()
        {
            Graphics g = pictureBox1.CreateGraphics();


            rect = new Rectangle(50, 50, 50, 50);
            Icon newIcon = new Icon(@"C:\Users\toan\Desktop\icon\girl.ico");


            icon = new Icon(@"C:\Users\toan\Desktop\icon\girl.ico");
            g.DrawIcon(newIcon,rect);


            Image newImage = VirtualPort.Properties.Resources.bowling;

            Rectangle destRect = new Rectangle(100, 100, 450, 150);

            // Create rectangle for source image.
            Rectangle srcRect = new Rectangle(50, 50, 150, 150);
            GraphicsUnit units = GraphicsUnit.Pixel;

            // Draw image to screen.
            Graphics gra = pictureBox1.CreateGraphics();
            gra.DrawImage(newImage, destRect, srcRect, units);

            


            graphic = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TestIcon_Load(object sender, EventArgs e)
        {

        }

        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.DrawIcon(icon, rect);
            g.DrawImage(image, toan);
        }


        
        private void timer1_Tick(object sender, EventArgs e)
        {
            toan.X += 10;
            toan.Y += 10;
            //rect.X++;
            //rect.Y++;
            //Console.WriteLine("iiiii");
            //graphic.DrawImage(image, toan);
            Invalidate();
        }

        private void TestIcon_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.DrawIcon(icon, rect);
            g.DrawImage(image, toan);
        }
    }
}
