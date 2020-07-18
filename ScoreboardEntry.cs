using System;

namespace Minesweeper
{
    public class ScoreboardEntry
    {
        private int time;
        private int rank;
        private string name;

        public ScoreboardEntry(string name, int time)
        {
            this.name = name;
            this.time = time;
        }
        public ScoreboardEntry(string name, string time)
        {
            this.name = name;
            this.time = Convert.ToInt32(time, 10);
        }

        public string GetName()
        {
            return name;
        }

        public int GetTime()
        {
            return time;
        }

        public void SetRank(int rank)
        {
            this.rank = rank;
        }
        public string Name //used for datagridview
        {
            get
            {
                return name;
            }
        }

        public string Rank //used for datagridview
        {
            get
            {
                return rank.ToString();
            }
        }

        public string Time //used for datagridview
        {
            get
            {
                string minutes = "" + time / 60;
                string seconds = "" + (time - ((time / 60) * 60));
                return minutes + ":" + seconds.PadLeft(2, '0'); ;
            }
        }
    }
}
