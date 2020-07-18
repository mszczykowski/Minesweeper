using System;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Main window with tool strip menu
    /// </summary>
    public partial class MinesweeperForm : Form
    {
        Game gameBoard;
        public MinesweeperForm()
        {
            InitializeComponent();
            gameBoard = new Board();
            Controls.Add(gameBoard);
            gameBoard.NewGame();
            DifficultyRadioButtons(gameBoard.GetDiffLevel());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameStripMenuItem1_Click(object sender, EventArgs e)
        {
            gameBoard.NewGame();
        }

        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyRadioButtons(0);
            gameBoard.CreateGame(0);
        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyRadioButtons(1);
            gameBoard.CreateGame(1);
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DifficultyRadioButtons(2);
            gameBoard.CreateGame(2);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gameBoard.CreateCustomGame()) DifficultyRadioButtons(3);
        }

        private void restartCurrentGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameBoard.ResetGame();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void DifficultyRadioButtons(int diffLevel)
        {
            this.begginerToolStripMenuItem.Checked = false;
            this.advancedToolStripMenuItem.Checked = false;
            this.exppertToolStripMenuItem.Checked = false;
            this.customToolStripMenuItem.Checked = false;
            switch (diffLevel)
            {
                case 0:
                    this.begginerToolStripMenuItem.Checked = true;
                    break;
                case 1:
                    this.advancedToolStripMenuItem.Checked = true;
                    break;
                case 2:
                    this.exppertToolStripMenuItem.Checked = true;
                    break;
                case 3:
                    this.customToolStripMenuItem.Checked = true;
                    break;
            }
        }

        private void scoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameBoard.ShowScoreboard();
        }
    }
}
