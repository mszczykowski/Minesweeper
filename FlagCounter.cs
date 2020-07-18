using System;

namespace Minesweeper
{
    /// <summary>
    /// Used to store number of flags
    /// </summary>
    class FlagCounter : FlagCounterLabel
    {
        private int flagCount;
        private bool areFlagsAvailable;

        public void SetFlagCount(int flagCount)
        {
            this.flagCount = flagCount;
            this.areFlagsAvailable = true;
            UpdateLabel(ToString());
        }
        /// <summary>
        /// Changes number of flags and sets "areFlagsAvailable" flag. 
        /// </summary>
        /// <param name="change">1 to add flag and -1 to remove flag</param>
        public void AddRemoveFlag(int change)
        {
            flagCount += change;
            UpdateLabel(ToString());
            if (flagCount == 0)
            {
                areFlagsAvailable = false;
            }
            else
            {
                areFlagsAvailable = true;
            }
        }
        public bool GetAreFlagsAvailable()
        {
            return areFlagsAvailable;
        }
        public override String ToString()
        {
            return Convert.ToString(flagCount, 10).PadLeft(3, '0');
        }
    }
}
