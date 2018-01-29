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
            Text = "Lines";
            Size = new Size(280, 270);
            ResizeRedraw = true;

            Paint += new PaintEventHandler(OnPaint);
            CenterToScreen();
        }


        void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);

            pen.DashStyle = DashStyle.Dot;
            g.DrawLine(pen, 20, 40, 250, 40);

            pen.DashStyle = DashStyle.DashDot;
            g.DrawLine(pen, 20, 80, 250, 80);

            pen.DashStyle = DashStyle.Dash;
            g.DrawLine(pen, 20, 120, 250, 120);

            pen.DashStyle = DashStyle.DashDotDot;
            g.DrawLine(pen, 20, 160, 250, 160);

            pen.DashPattern = new float[] { 6f, 8f, 1f, 1f, 1f, 1f, 1f, 1f };
            g.DrawLine(pen, 20, 200, 250, 200);

            g.Dispose();
        }
    }
}
