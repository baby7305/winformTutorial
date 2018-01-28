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


        public MForm()
        {
            Text = "Anchor";
            Size = new Size(210, 210);

            Button btn1 = new Button();
            btn1.Text = "Button";
            btn1.Parent = this;
            btn1.Location = new Point(30, 30);

            Button btn2 = new Button();
            btn2.Text = "Button";
            btn2.Parent = this;
            btn2.Location = new Point(30, 80);
            btn2.Anchor = AnchorStyles.Right;

            CenterToScreen();
        }
    }
}
