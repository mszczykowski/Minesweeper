using System;
using System.IO;

namespace Minesweeper
{
    /// <summary>
    /// Class used to load and save current difficulty level or board size.
    /// Game sets last used board size and difficulty level on start.
    /// </summary>
    class LastGame
    {
        private readonly string directoryName = "./data";
        private readonly string lastGameFileName = "/lastgame.txt";
        private readonly string filePath;
        private int lastDiffLevel;
        private CustomGameSize customGameSize;
        private bool isLastGameAvailable;

        public LastGame()
        {
            filePath = directoryName + lastGameFileName;
            if (!File.Exists(filePath))
            {
                try
                {
                    Directory.CreateDirectory(directoryName);
                    using (StreamWriter writer = File.CreateText(filePath))
                    {
                        writer.Write("0 0 0 0");
                    }
                }
                catch
                {
                    isLastGameAvailable = false;
                    new ErrorMessageForm("Error creating last game file\nGame will always start on beginner mode");
                    return;
                }
            }
            isLastGameAvailable = true;
            LoadFile();
        }

        private void LoadFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    try
                    {
                        string fileLine = reader.ReadLine();
                        string[] fileLineSplitted = fileLine.Split(null);
                        lastDiffLevel = Convert.ToInt32(fileLineSplitted[0], 10);
                        if (lastDiffLevel == 3)
                        {
                            customGameSize = new CustomGameSize(Convert.ToInt32(fileLineSplitted[1], 10),
                                Convert.ToInt32(fileLineSplitted[2], 10), Convert.ToInt32(fileLineSplitted[3], 10));
                        }
                    }
                    catch (Exception e)
                    {
                        if (e is FormatException || e is IndexOutOfRangeException)
                        {
                            new ErrorMessageForm("Error loading last game data\nGame will start with default difficulty");
                            reader.Close();
                            Save(0,null);
                        }
                    }
                }
            }
            catch
            {
                isLastGameAvailable = false;
                new ErrorMessageForm("Error loading last game data\nGame will start with default difficulty");
            }
        }

        public void Save(int diffLevel, CustomGameSize customGameSize)
        {
            lastDiffLevel = diffLevel;
            if(!isLastGameAvailable) return;
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write("" + lastDiffLevel);
                    if (customGameSize != null)
                    {
                        writer.Write(" " + customGameSize.GetXSize() + " " + customGameSize.GetYSize() + " " +
                                     customGameSize.GetMines());
                    }
                }
            }
            catch
            {
                isLastGameAvailable = false;
                new ErrorMessageForm("Error saving last game data\nGame will start with default difficulty");
            }
        }

        public int GetDifficultyLevel()
        {
            if (isLastGameAvailable)
            {
                return lastDiffLevel;
            }
            else
            {
                return 0;
            }
        }

        public CustomGameSize GetCustomGameSize()
        {
            return customGameSize;
        }
    }
}
