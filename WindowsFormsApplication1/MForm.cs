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
            Text = "Tooltips";
            Size = new Size(250, 200);

            ToolTip btnTlp = new ToolTip();

            btnTlp.SetToolTip(this, "This is a Form");

            Button button = new Button();
            btnTlp.SetToolTip(button, "This is a Button Control");
            button.Text = "Button";
            button.Location = new Point(30, 70);
            button.Parent = this;

            CenterToScreen();
        }
    }
}
