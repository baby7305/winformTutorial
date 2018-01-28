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
            Text = "MenuStrip";
            Size = new Size(250, 200);

            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem titem1 = new ToolStripMenuItem("File");
            menuStrip.Items.Add(titem1);

            ToolStripMenuItem titem2 = new ToolStripMenuItem("Tools");
            menuStrip.Items.Add(titem2);

            ToolStripMenuItem subm1 = new ToolStripMenuItem("New");
            subm1.Image = Image.FromFile("res/new.png");
            titem1.DropDownItems.Add(subm1);

            ToolStripMenuItem subm2 = new ToolStripMenuItem("Open");
            subm2.Image = Image.FromFile("res/open.png");
            titem1.DropDownItems.Add(subm2);

            titem1.DropDownItems.Add(new ToolStripSeparator());

            ToolStripMenuItem subm3 = new ToolStripMenuItem("Exit");
            subm3.Image = Image.FromFile("res/exit.png");
            titem1.DropDownItems.Add(subm3);

            subm3.Click += OnExit;
            Controls.Add(menuStrip);

            MainMenuStrip = menuStrip;

            CenterToScreen();
        }

        void OnExit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
