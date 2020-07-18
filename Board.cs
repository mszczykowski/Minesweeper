using System;

namespace Minesweeper
{
    /// <summary>
    /// Grid of tiles
    /// </summary>
    class Board : Game
    {
        protected int mineCount;
        protected int lastMineCount;
        protected int xSize, ySize;
        private Tile[,] grid;
        private Random rand = new Random();
        /// <summary>
        /// Generates new board.
        /// </summary>
        /// <param name="xSize">Width</param>
        /// <param name="ySize">Length</param>
        /// <param name="mineCount">Number of mines</param>
        public override void GenerateBoard(int xSize, int ySize, int mineCount)
        {
            this.xSize = xSize;
            this.ySize = ySize;
            this.mineCount = lastMineCount = mineCount;
            flagCounter.SetFlagCount(mineCount);
            ResizePanel(xSize, ySize);
            if (grid != null) ClearTiles();
            grid = new Tile[xSize, ySize];
            int x, y;
            for (int i = 0; i < mineCount; i++)
            {
                do
                {
                    x = rand.Next(xSize);
                    y = rand.Next(ySize);
                } while (grid[x, y] != null);
                grid[x, y] = new Mine(x, y);
                AddElement(grid[x, y]);
                AddTileButtonMouseActions(grid[x, y]);
            }
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    if (grid[i, j] == null)
                    {
                        int minesAround = CountAround(i, j);
                        if (minesAround == 0)
                        {
                            grid[i, j] = new Empty(i, j);
                        }
                        else
                        {
                            grid[i, j] = new Number(i, j, minesAround);
                        }
                        AddElement(grid[i, j]);
                        AddTileButtonMouseActions(grid[i, j]);
                    }
                }
            }
        }
        /// <summary>
        /// Clears old buttons when creating new game
        /// </summary>
        private void ClearTiles()
        {
            foreach (Tile t in grid)
            {
                t.Delete();
            }
            mineCount = lastMineCount;
            flagCounter.SetFlagCount(mineCount);
        }
        /// <summary>
        /// Resets current board
        /// </summary>
        public override void ResetBoard()
        {
            foreach (Tile t in grid)
            {
                t.Reset();
            }
            mineCount = lastMineCount;
            flagCounter.SetFlagCount(mineCount);
        }
        /// <summary>
        /// Counts mines around tile. Used to generate non mine tiles.
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        /// <returns>Numbers of mines around x,y tile</returns>
        private int CountAround(int x, int y)
        {
            int bombsAround = 0;
            for (int i = Math.Max(0, x - 1); i <= Math.Min(x + 1, xSize - 1); i++)
            {
                for (int j = Math.Max(0, y - 1); j <=Math.Min(y + 1, ySize - 1); j++)
                {
                    if (grid[i, j] != null && grid[i, j].GetNumber() == -1)
                    {
                        bombsAround++;
                    }
                }
            }
            return bombsAround;
        }
        /// <summary>
        /// Checks if all bombs are correctly marked and non-mine tiles uncovered
        /// </summary>
        private void IsGameDone()
        {
            bool isGameDone = true;
            foreach (Tile t in grid)
            {
                if (t.GetNumber() == -1)
                {
                    if (!t.GetIsFlagged()) isGameDone = false;
                }
                else
                {
                    if (t.GetIsCovered()) isGameDone = false;
                }
            }
            if (isGameDone)
            {
                Win();
            }
        }
        /// <summary>
        /// Shows all mines after lose
        /// </summary>
        protected override void ShowAllMines()
        {
            foreach (Tile t in grid)
            {
                if (t.GetNumber() == -1)
                {
                    t.Uncover();
                }
            }
        }
        /// <summary>
        /// Used to uncover all non - mine tiles around empty tile
        /// </summary>
        /// <param name="t">Empty tile</param>
        private void UncoverAround(Tile t)
        {
            if (t.GetIsCovered())
            {
                if (t.GetIsFlagged())
                {
                    flagCounter.AddRemoveFlag(1);
                }
                t.Uncover();
                if (t.GetNumber() == 0)
                {
                    int x = t.GetX();
                    int y = t.GetY();
                    for (int i = Math.Max(0, x - 1); i <= Math.Min(x + 1, xSize - 1); i++)
                    {
                        for (int j = Math.Max(0, y - 1); j <= Math.Min(y + 1, ySize - 1); j++)
                        {
                            if (!(i == x && j == y))
                            {
                                UncoverAround(grid[i, j]);
                            }
                        }
                    }
                }
            }
        }

        private void LeftMouseClick(Tile clicked)
        {
            if (!clicked.GetIsFlagged() && !clicked.GetIsQuestionMark())
            {
                if (clicked.GetNumber() == -1)
                {
                    Lose();
                }
                else
                {
                    if (clicked.GetNumber() != 0)
                    {
                        clicked.Uncover();
                    }
                    else
                    {
                        UncoverAround(clicked);
                    }
                }
            }
        }

        private void RightMouseClick(Tile clicked)
        {
            flagCounter.AddRemoveFlag(clicked.MarkFlagOrQuestion(flagCounter.GetAreFlagsAvailable()));
        }

        protected override void TileMouseActions(Tile clicked, bool isLeftClick)
        {
            if (isGameAvailable)
            {
                gameButton.Clicked();
                stopwatch.Start();
                if (isLeftClick)
                {
                    LeftMouseClick(clicked);
                }
                else
                {
                    RightMouseClick(clicked);
                }
                if (!flagCounter.GetAreFlagsAvailable()) IsGameDone();
            }
        }
    }
}
