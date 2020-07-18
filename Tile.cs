namespace Minesweeper
{
    abstract class Tile : TileButton
    {
        protected bool isCovered;
        protected bool isFlagged;
        protected bool isQuestionMark;
        protected int number;
        private int x;
        private int y;
        public Tile(int x, int y, int number) : base(x, y)
        {
            this.x = x;
            this.y = y;
            this.number = number;
            isCovered = true;
            isFlagged = false;
            isQuestionMark = false;
        }

        public abstract void Uncover();
        /// <summary>
        /// Marks tile with question mark, flag or clears all markings according to current tile state.
        /// </summary>
        /// <returns>Returns value of flags that should be added or deleted from flag count.</returns>
        public int MarkFlagOrQuestion(bool areFlagsAvailable)
        {
            if (isCovered)
            {
                if (!isFlagged && !isQuestionMark && areFlagsAvailable)
                {
                    isFlagged = true;
                    ShowFlag();
                    return -1;
                }
                else if (isFlagged)
                {
                    isFlagged = false;
                    isQuestionMark = true;
                    ShowQuestionMark();
                    return 1;
                }
                else if(!areFlagsAvailable && !isQuestionMark)
                {
                    isQuestionMark = true;
                    ShowQuestionMark();
                    return 0;
                }
                else
                {
                    isFlagged = false;
                    isQuestionMark = false;
                    Clear();
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Resets all tile parameters to default state. Used to restart current game.
        /// </summary>
        public void Reset()
        {
            Clear();
            isFlagged = false;
            isQuestionMark = false;
            isCovered = true;
            Enabled = true;
        }

        public int GetNumber()
        {
            return number;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public bool GetIsCovered()
        {
            return isCovered;
        }

        public bool GetIsFlagged()
        {
            return isFlagged;
        }

        public bool GetIsQuestionMark()
        {
            return isQuestionMark;
        }
    }
}
