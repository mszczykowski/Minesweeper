namespace Minesweeper
{
    /// <summary>
    /// Tile with number
    /// </summary>
    class Number : Tile
    {
        public Number(int x, int y, int number) : base(x, y, number)
        {

        }
        public override void Uncover()
        {
            isCovered = false;
            Enabled = false;
            isFlagged = false;
            isQuestionMark = false;
            ShowNumber(number);
        }
    }
}
