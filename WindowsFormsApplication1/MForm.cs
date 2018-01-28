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
        public MForm()
        {
            Text = "Icon";
            Size = new Size(250, 200);

            try
            {
                Icon = new Icon("res/web.ico");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }

            CenterToScreen();
        }
    }
}
