using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class MForm : Form
    {

        private Bitmap castle;

        public MForm()
        {
            Text = "Red Rock";
            loadImage();
            ClientSize = new Size(castle.Width, castle.Height);

            Paint += new PaintEventHandler(OnPaint);

            CenterToScreen();
        }

        void loadImage()
        {
            try
            {
                castle = new Bitmap("res/redrock.png");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }
        }

        void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle r = new Rectangle(1, 1, castle.Width, castle.Height);
            g.DrawImage(castle, r);
        }
    }
}
