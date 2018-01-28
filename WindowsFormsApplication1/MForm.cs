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
        private StatusBar statusbar;

        public MForm()
        {
            Text = "FolderBrowserDialog";

            toolbar = new ToolBar();
            open = new ToolBarButton("File");

            statusbar = new StatusBar();
            statusbar.Parent = this;

            toolbar.Buttons.Add(open);
            toolbar.ButtonClick += new ToolBarButtonClickEventHandler(OnClicked);

            Controls.Add(toolbar);

            CenterToScreen();
        }


        void OnClicked(object sender, ToolBarButtonClickEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                statusbar.Text = dialog.SelectedPath;
            }
        }
    }
}
