using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Panel to contain game and board elements
    /// </summary>
    class GamePanel : Panel
    {
        public GamePanel()
        {
            Location = new Point(2, 0);
        }
        /// <summary>
        /// Resizes window as needed
        /// </summary>
        /// <param name="xSize">width</param>
        /// <param name="ySize">legth</param>
        public void ResizePanel(int xSize, int ySize)
        {
            Size = new Size(30 * xSize, 30 * ySize + 60);
        }

        public void AddElement(System.Windows.Forms.Control o)
        {
            Controls.Add(o);
        }

        protected void AddGameButtonMouseActions(Button b)
        {
            b.MouseClick += gameButton_MouseClick;
        }

        protected void AddTileButtonMouseActions(Button b)
        {
            b.MouseDown += new MouseEventHandler(tile_MouseClick);
        }

        private void gameButton_MouseClick(object sender, MouseEventArgs e)
        {
            GameButtonAction();
        }
        private void tile_MouseClick(object sender, MouseEventArgs e)
        {
            Tile clicked = (Tile)sender;
            if (e.Button == MouseButtons.Left)
            {
                TileMouseActions(clicked, true);
            }
            if (e.Button == MouseButtons.Right)
            {
                TileMouseActions(clicked,false);
            }
        }

        protected virtual void TileMouseActions(Tile clicked, bool isLeftClick)
        {

        }

        protected virtual void GameButtonAction()
        {

        }
    }
}
