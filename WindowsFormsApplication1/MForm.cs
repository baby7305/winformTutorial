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
    public partial class MForm : Form
    {
        private ImageList toolBarIcons;
        private ToolBarButton save;
        private ToolBarButton exit;
        private ToolBar toolBar;

        public MForm()
        {
            Size = new Size(250, 200);
            Text = "Simple toolbar";

            toolBar = new ToolBar();
            toolBar.Parent = this;
            toolBarIcons = new ImageList();
            save = new ToolBarButton();
            exit = new ToolBarButton();

            save.ImageIndex = 0;
            save.Tag = "Save";
            exit.ImageIndex = 1;
            exit.Tag = "Exit";

            toolBar.ImageList = toolBarIcons;
            toolBar.ShowToolTips = true;
            toolBar.Buttons.AddRange(new ToolBarButton[] { save, exit });
            toolBar.ButtonClick += new ToolBarButtonClickEventHandler(OnClicked);

            toolBarIcons.Images.Add(new Icon("res/web.ico"));
            toolBarIcons.Images.Add(new Icon("res/web.ico"));

            CenterToScreen();
        }

        void OnClicked(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.Tag.Equals("Exit"))
                Close();
        }
    }
}
