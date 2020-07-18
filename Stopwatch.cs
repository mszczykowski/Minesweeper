using System;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Counts current game time
    /// </summary>
    class Stopwatch : StopwatchLabel
    {
        private int time;
        private bool isRunning;
        private Timer timer;
        public Stopwatch()
        {
            time = 0;
            isRunning = false;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            time++;
            UpdateLabel(ToString());
        }

        public void Start()
        {
            if (!isRunning)
            {
                timer.Start();
            }
        }

        public void Stop()
        {
            timer.Stop();
            isRunning = false;
        }

        public void Reset()
        {
            time = 0;
            timer.Stop();
            UpdateLabel(ToString());
        }

        public int GetTime()
        {
            return time;
        }

        public override String ToString()
        {
            return Convert.ToString(time, 10).PadLeft(3, '0');
        }
    }
}
