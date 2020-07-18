namespace Minesweeper
{
    /// <summary>
    /// Class used to store custom game size and mine count
    /// </summary>
    public class CustomGameSize
    {
        private int xSize;
        private int ySize;
        private int mines;
        public CustomGameSize(int xSize, int ySize, int mines)
        {
            this.xSize = xSize;
            this.ySize = ySize;
            this.mines = mines;
        }
        public int GetXSize()
        {
            return xSize;
        }

        public int GetYSize()
        {
            return ySize;
        }
        public int GetMines()
        {
            return mines;
        }
    }
}
