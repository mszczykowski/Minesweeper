using System;
using System.IO;
using System.Linq.Expressions;

namespace Minesweeper
{
    class Scoreboard : ScoreboardForm
    {
        private bool isScoreboardAvailable;
        private readonly string directoryName = "./data";
        private readonly string scoreboardFileName = "/scoreboard.txt";
        private readonly string filePath;
        protected ScoreboardEntry[] beginner;
        protected ScoreboardEntry[] advanced;
        protected ScoreboardEntry[] expert;

        public Scoreboard()
        {
            beginner = new ScoreboardEntry[10];
            advanced = new ScoreboardEntry[10];
            expert = new ScoreboardEntry[10];
            filePath = directoryName + scoreboardFileName;
            SetDataSources();
            isScoreboardAvailable = true;
            if (!File.Exists(filePath))
            {
                try
                {
                    Directory.CreateDirectory(directoryName);
                }
                catch
                {
                    isScoreboardAvailable = false;
                    new ErrorMessageForm("Error creating scoreboard file\nScoreboard will be disabled");
                }
            }
            else
            {
                LoadFile();
            }
        }

        public void LoadFile()
        {
            int i;
            string fileLine;
            string[] fileLineSplited;
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        i = 0;
                        try
                        {
                            while ((fileLine = reader.ReadLine()) != null && fileLine != "-")
                            {
                                fileLineSplited = fileLine.Split(null);
                                PickTable(j)[i] = new ScoreboardEntry(fileLineSplited[0], fileLineSplited[1]);
                                PickTable(j)[i].SetRank(i + 1);
                                i++;
                            }
                        }
                        catch (Exception e)
                        {
                            if (e is FormatException || e is IndexOutOfRangeException)
                            {
                                new ErrorMessageForm("Error loading scoreboard data\nData will be lost");
                                reader.Close();
                                Reset(j);
                                break;
                            }
                        }

                    }
                }
            }
            catch
            {
                isScoreboardAvailable = false;
                new ErrorMessageForm("Error loading scoreboard data\nScoreboard will be disabled");
            }
        }

        private void Save()
        {
            try
            {
                File.WriteAllText(filePath, String.Empty);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        foreach (ScoreboardEntry entry in PickTable(i))
                        {
                            if (entry != null)
                            {
                                writer.Write(entry.GetName() + " ");
                                writer.WriteLine(entry.GetTime());
                            }
                        }

                        writer.WriteLine("-");
                    }
                }
            }
            catch
            {
                isScoreboardAvailable = false;
                new ErrorMessageForm("Error saving scoreboard data\nScoreboard will be disabled");
            }

        }

        /// <summary>
        /// Used to access all arrays in loop.
        /// </summary>
        /// <param name="diffLevel">0 for beginner
        /// 1 for advanced
        /// 2 for expert</param>
        /// <returns>Returns choosed array</returns>
        protected override ScoreboardEntry[] PickTable(int diffLevel)
        {
            switch (diffLevel)
            {
                case 0:
                    return beginner;
                case 1:
                    return advanced;
                case 2:
                    return expert;
                default:
                    return null; //never used
            }
        }

        public override bool IsEligible(int time, int diffLevel)
        //check is entry eliagable for leaderboard
        {
            if (!isScoreboardAvailable) return false;
            ScoreboardEntry[] tab = PickTable(diffLevel);
            foreach (ScoreboardEntry entry in tab)
            {
                if (entry == null) return true;
                else if (entry.GetTime() > time) return true;
            }
            return false;
        }

        public override void AddEntry(ScoreboardEntry entry, int diffLevel)
        {
            ScoreboardEntry[] tab = PickTable(diffLevel);
            for (int i = 0; i < tab.Length; i++)
            {
                try
                {
                    if (tab[i] == null)
                    {
                        entry.SetRank(i + 1);
                        tab[i] = entry;
                        break;
                    }
                    if (tab[i].GetTime() < entry.GetTime()) continue;
                    if (tab[i].GetTime() > entry.GetTime())
                    {
                        for (int j = tab.Length - 1; j > i; j--)
                        {
                            if (tab[j] != null || (tab[j] == null && tab[j - 1] != null))
                            {
                                tab[j] = tab[j - 1];
                                tab[j].SetRank(j + 1);
                            }
                        }
                        entry.SetRank(i + 1);
                        tab[i] = entry;
                        break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    new ErrorMessageForm("Scorboard data corupted!\nData will be lost!");
                    Reset(diffLevel);
                    break;
                }
            }
            Save();
        }
        /// <summary>
        /// Resets choosed array.
        /// </summary>
        /// <param name="diffLevel">Used to pick array to reset</param>
        protected override void Reset(int diffLevel) //resets picked leaderboard
        {
            ScoreboardEntry[] tab = PickTable(diffLevel);
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = null;
            }
            Save();
        }

        protected override bool GetIsScoreboardAvailable()
        {
            return isScoreboardAvailable;
        }
    }
}
