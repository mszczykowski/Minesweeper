namespace Minesweeper
{
    /// <summary>
    /// Main game class
    /// </summary>
    abstract class Game : GamePanel
    {
        protected int diffLevel;
        protected bool isGameAvailable;
        protected bool isGameReplayed;
        protected FlagCounter flagCounter;
        protected Stopwatch stopwatch; //timer
        protected GameButton gameButton; //button with yellow face
        private ScoreboardForm scoreboard;
        private CustomGameSize customGameSize;
        private LastGame lastGame; //used to read and save last difficulty level
        protected Game()
        {
            flagCounter = new FlagCounter();
            AddElement(flagCounter);
            stopwatch = new Stopwatch();
            AddElement(stopwatch);
            gameButton = new GameButton();
            AddGameButtonMouseActions(gameButton);
            AddElement(gameButton);
            scoreboard = new Scoreboard();
            lastGame = new LastGame();
            diffLevel = lastGame.GetDifficultyLevel();
            customGameSize = lastGame.GetCustomGameSize();
        }
        /// <summary>
        /// Sets correct size and mine count when changing difficulty level.
        /// Also used to set board for custom game.
        /// </summary>
        /// <param name="diffLevel">Choosed difficulty level.
        /// 0 is beginner
        /// 1 is advanced
        /// 2 is expert
        /// 3 is custom game mode</param>
        public void CreateGame(int diffLevel)
        {
            this.diffLevel = diffLevel;
            switch (diffLevel)
            {
                case 0:
                    GenerateBoard(10,10,8);
                    break;
                case 1:
                    GenerateBoard(16,16,40);
                    break;
                case 2:
                    GenerateBoard(30,16,99);
                    break;
                case 3:
                    GenerateBoard(customGameSize.GetXSize(), customGameSize.GetYSize(),customGameSize.GetMines());
                    break;
            }
            lastGame.Save(diffLevel, customGameSize);
            isGameReplayed = false;
            stopwatch.Reset();
            gameButton.Happy();
            isGameAvailable = true;
        }
        /// <summary>
        /// Opens window to set custom game size.
        /// </summary>
        /// <returns>Returns false when user cancels operation.
        /// Returns true if user enters correct data and accept it.</returns>
        public bool CreateCustomGame()
        {
            bool success = false;
            CustomFieldCreatorForm customFieldCreator = new CustomFieldCreatorForm();
            customFieldCreator.ShowDialog();
            if (customFieldCreator.GetisOkPressed())
            {
                this.customGameSize = customFieldCreator.GetCustomGameSize();
                CreateGame(3);
                success = true;
            }
            return success;
        }
        /// <summary>
        /// Method resets current game. It sets flag "isGameReplayed" to true so it is not eligible for scoreboard.
        /// </summary>
        public void ResetGame()
        {
            isGameReplayed = true;
            ResetBoard();
            stopwatch.Reset();
            gameButton.Happy();
            isGameAvailable = true;
        }
        /// <summary>
        /// Generates new game with the same difficulty level as previous.
        /// </summary>
        public void NewGame()
        {
            CreateGame(diffLevel);
        }
        /// <summary>
        /// Action of button with yellow face.
        /// </summary>
        protected override void GameButtonAction()
        {
            NewGame();
            gameButton.Clicked();
        }
        /// <summary>
        /// Method is used after user wins the game.
        /// It checks if game is eligible for scoreboard, if yes it shows correct window to fill user name.
        /// If not it shows simple popup with time displayed.
        /// </summary>
        protected void Win()
        {
            isGameAvailable = false;
            gameButton.Win();
            stopwatch.Stop();
            bool isEligible;
            if (!isGameReplayed && diffLevel != 3) //checks if entry can be added to scoreboard
            {
                isEligible = scoreboard.IsEligible(stopwatch.GetTime(), diffLevel);
            }
            else
            {
                isEligible = false;
            }
            WinPopUpForm winPopUp = new WinPopUpForm(stopwatch.GetTime(), isEligible);
            winPopUp.ShowDialog();
            if (isEligible && winPopUp.GetIsOkPressed())
            {
                scoreboard.AddEntry(winPopUp.GetScoreboardEntry(), diffLevel);
            }
        }
        /// <summary>
        /// Method is used after user left clicks a bomb.
        /// </summary>
        protected void Lose()
        {
            ShowAllMines();
            isGameAvailable = false;
            gameButton.Dead();
            stopwatch.Stop();
            LostPopUpForm lostPopUp = new LostPopUpForm();
        }

        public int GetDiffLevel()
        {
            return diffLevel;
        }

        public void ShowScoreboard()
        {
            scoreboard.ShowForm();
        }
        
        protected abstract void ShowAllMines();
        public abstract void GenerateBoard(int xSize, int ySize, int mineCount);
        public abstract void ResetBoard();
    }
}
