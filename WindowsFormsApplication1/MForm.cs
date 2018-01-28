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

        private StatusBar sb;

        public MForm()
        {
            Text = "ListBox";
            Size = new Size(210, 210);

            ListBox lb = new ListBox();
            lb.Parent = this;
            lb.Items.Add("Jessica");
            lb.Items.Add("Rachel");
            lb.Items.Add("Angelina");
            lb.Items.Add("Amy");
            lb.Items.Add("Jennifer");
            lb.Items.Add("Scarlett");

            lb.Dock = DockStyle.Fill;
            lb.SelectedIndexChanged += new EventHandler(OnChanged);

            sb = new StatusBar();
            sb.Parent = this;

            CenterToScreen();
        }


        void OnChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            sb.Text = lb.SelectedItem.ToString();
        }
    }
}
