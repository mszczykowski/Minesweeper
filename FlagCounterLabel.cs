using System;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Used to display flag count
    /// </summary>
    abstract class FlagCounterLabel : Label
    {
        protected FlagCounterLabel()
        {
            Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            Location = new System.Drawing.Point(12, 30);
            Size = new System.Drawing.Size(45, 25);
        }
        public void UpdateLabel(String text)
        {
            this.Text = text;
        }
    }
}
