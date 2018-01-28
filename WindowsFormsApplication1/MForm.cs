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

        private CheckBox cb;

        public MForm()
        {
            Text = "CheckBox";
            Size = new Size(220, 170);

            cb = new CheckBox();
            cb.Parent = this;
            cb.Location = new Point(30, 30);
            cb.Text = "Show Title";
            cb.Checked = true;

            cb.CheckedChanged += new EventHandler(OnChanged);

            CenterToScreen();
        }

        void OnChanged(object sender, EventArgs e)
        {
            if (cb.Checked)
            {
                Text = "CheckBox";
            }
            else
            {
                Text = "";
            }
        }
    }
}
