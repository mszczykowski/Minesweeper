namespace Minesweeper
{
    /// <summary>
    /// Tile with mine
    /// </summary>
    class Mine : Tile
    {
        public Mine(int x, int y) : base(x, y, -1)
        {

        }
        public override void Uncover()
        {
            ShowMine();
        }
    }
}
