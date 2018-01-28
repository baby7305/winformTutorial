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

        private ComboBox cb;
        private Label label;

        public MForm()
        {
            Text = "ComboBox";
            Size = new Size(240, 240);

            cb = new ComboBox();
            cb.Parent = this;
            cb.Location = new Point(50, 30);

            cb.Items.AddRange(new object[] {"Ubuntu",
                "Mandriva",
                "Red Hat",
                "Fedora",
                "Gentoo"});

            cb.SelectionChangeCommitted += new EventHandler(OnChanged);

            label = new Label();
            label.Location = new Point(50, 140);
            label.Parent = this;
            label.Text = "...";

            CenterToScreen();
        }

        void OnChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            label.Text = combo.Text;
        }
    }
}
