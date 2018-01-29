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

        public MForm()
        {
            Text = "Colors";
            Size = new Size(360, 300);

            Paint += new PaintEventHandler(OnPaint);

            CenterToScreen();
        }


        void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Sienna, 10, 15, 90, 60);
            g.FillRectangle(Brushes.Green, 130, 15, 90, 60);
            g.FillRectangle(Brushes.Maroon, 250, 15, 90, 60);
            g.FillRectangle(Brushes.Chocolate, 10, 105, 90, 60);
            g.FillRectangle(Brushes.Gray, 130, 105, 90, 60);
            g.FillRectangle(Brushes.Coral, 250, 105, 90, 60);
            g.FillRectangle(Brushes.Brown, 10, 195, 90, 60);
            g.FillRectangle(Brushes.Teal, 130, 195, 90, 60);
            g.FillRectangle(Brushes.Goldenrod, 250, 195, 90, 60);

            g.Dispose();

        }
    }
}
