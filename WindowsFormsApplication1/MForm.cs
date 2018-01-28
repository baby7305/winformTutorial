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

        private ToolBar toolbar;
        private ToolBarButton open;
        private Color color;

        private int rectWidth = 100;
        private int rectHeight = 100;
        private Rectangle r;

        public MForm()
        {
            Text = "ColorDialog";

            color = Color.Blue;

            toolbar = new ToolBar();
            open = new ToolBarButton("color");

            toolbar.Buttons.Add(open);
            toolbar.ButtonClick += new ToolBarButtonClickEventHandler(OnClicked);

            LocateRect();

            SetStyle(ControlStyles.ResizeRedraw, true);
            Controls.Add(toolbar);
            Paint += new PaintEventHandler(OnPaint);

            CenterToScreen();
        }


        void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LocateRect();

            SolidBrush brush = new SolidBrush(color);

            g.FillRectangle(brush, r);
        }


        void OnClicked(object sender, ToolBarButtonClickEventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                color = dialog.Color;
                Invalidate();
            }
        }

        void LocateRect()
        {
            int x = (ClientSize.Width - rectWidth) / 2;
            int y = (ClientSize.Height - rectHeight) / 2;
            r = new Rectangle(x, y, rectWidth, rectHeight);
        }
    }
}
