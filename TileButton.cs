using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// This class connects tiles logic with button interface.
    /// </summary>
    abstract class TileButton : Button
    {
        public TileButton(int x, int y)
        {
            this.Size = new Size(30, 30);
            this.Location = new Point(x * 30, y * 30 + 60);
            this.Image = null;
            this.TabStop = false;
        }

        public void ShowFlag()
        {
            this.Image = Properties.Resources.flag;
        }
        public void ShowQuestionMark()
        {
            this.Image = Properties.Resources.questionmark;
        }

        public void Clear()
        {
            this.Image = null;
            this.Text = "";
        }

        public void ShowMine()
        {
            this.Image = Properties.Resources.mine;
        }
        public void ShowNumber(int number)
        {
            this.Image = null;
            this.Text = "" + number;
        }

        public void Delete()
        {
            Dispose();
        }
    }
}
