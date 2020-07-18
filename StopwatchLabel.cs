using System;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Used as timer display.
    /// </summary>
    abstract class StopwatchLabel : Label
    {
        public StopwatchLabel()
        {
            Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            AutoSize = true; 
            Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            Location = new System.Drawing.Point(150, 30);
            Size = new System.Drawing.Size(45, 25);
        }

        public void UpdateLabel(String text)
        {
            this.Text = text;
        }
    }
}
