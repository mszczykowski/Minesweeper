namespace Minesweeper
{
    /// <summary>
    /// Empty tile with no number
    /// </summary>
    class Empty : Tile
    {
        public Empty(int x, int y) : base(x, y, 0)
        {

        }

        public override void Uncover()
        {
            this.isCovered = false;
            this.Enabled = false;
            this.isFlagged = false;
            this.isQuestionMark = false;
            Clear();
        }
    }
}
