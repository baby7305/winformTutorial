using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Snake : Form
    {

        public Snake()
        {

            Text = "Snake";
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            int borderWidth = (this.Width - this.ClientSize.Width) / 2;
            int titleBarHeight = this.Height - this.ClientSize.Height - borderWidth;

            Board board = new Board();
            board.BORDER_WIDTH = borderWidth;
            board.TITLEBAR_HEIGHT = titleBarHeight;

            Controls.Add(board);
            CenterToScreen();

        }
    }
}