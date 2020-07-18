using System;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Button with yellow face :)
    /// </summary>
    class GameButton : Button
    {
        private Timer timer;
        public GameButton()
        {
            Anchor = System.Windows.Forms.AnchorStyles.Top;
            Location = new System.Drawing.Point(86, 25);
            Margin = new System.Windows.Forms.Padding(2);
            Size = new System.Drawing.Size(33, 33);
            TabStop = false;
            timer = new Timer();
            timer.Interval = 300;
            timer.Tick += new EventHandler(FaceUpdate);
        }
        public void Happy()
        {
            this.Image = Properties.Resources.happy;
            timer.Stop();
        }
        public void Dead()
        {
            this.Image = Properties.Resources.dead;
            timer.Stop();
        }
        public void Clicked()
        {
            this.Image = Properties.Resources.click;
            timer.Start();
        }
        public void Win()
        {
            this.Image = Properties.Resources.win;
            timer.Stop();
        }
        private void FaceUpdate(object sender, EventArgs e)
        {
            Happy();
        }
    }
}
