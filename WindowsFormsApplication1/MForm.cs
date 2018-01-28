using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class MForm : Form
    {

        PictureBox pb;
        TrackBar tb;
        Bitmap mute, min, med, max;

        public MForm()
        {
            Text = "TrackBar";
            Size = new Size(260, 190);

            tb = new TrackBar();
            tb.Parent = this;
            tb.Size = new Size(160, 30);
            tb.Location = new Point(20, 40);
            tb.TickStyle = TickStyle.None;

            tb.ValueChanged += new EventHandler(OnChanged);

            LoadImages();

            pb = new PictureBox();
            pb.Parent = this;
            pb.Location = new Point(210, 50);
            pb.Image = mute;

            CenterToScreen();

        }

        void LoadImages()
        {
            mute = new Bitmap("res/mute.png");
            min = new Bitmap("res/min.png");
            med = new Bitmap("res/med.png");
            max = new Bitmap("res/max.png");
        }


        void OnChanged(object sender, EventArgs e)
        {
            int val = tb.Value;

            if (val == 0)
            {
                pb.Image = mute;
            }
            else if (val > 0 && val <= 3)
            {
                pb.Image = min;
            }
            else if (val > 3 && val < 8)
            {
                pb.Image = med;
            }
            else
            {
                pb.Image = max;
            }
        }
    }
}
