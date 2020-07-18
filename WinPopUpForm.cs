using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class WinPopUpForm : Form
    {
        private string name;
        private int time;
        private bool isOkPressed;
        /// <summary>
        /// Form popups after game is won. It is used to get user name if time can be put on scoreboard.
        /// Or if time is to long for scoreboard it shows simple message.
        /// </summary>
        /// <param name="time">Time to display on form</param>
        /// <param name="isEligible">Sets window accordingly. If set to true window shows text box for name input.
        /// If set to false is hides text box and show only ok button.</param>
        public WinPopUpForm(int time, bool isEligible)
        {
            InitializeComponent();
            this.labelTime.Text = "You finished in " + time + " seconds";
            if (isEligible)
            {
                this.okNoName.Visible = false;
                this.okName.Enabled = false;
                this.Height = 190;
                this.time = time;
                isOkPressed = false;
                AcceptButton = okName;
            }
            else
            {
                this.okName.Visible = false;
                this.cancelButton.Visible = false;
                this.labelName.Visible = false;
                this.nameBox.Visible = false;
                this.Height = 160;
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            this.okName.Enabled = false;
            nameBox.Text = nameBox.Text.Replace(" ", string.Empty); //avoid spacebar input
            if (nameBox.Text != "")
            {
                name = this.nameBox.Text;
                this.okName.Enabled = true;
            }
        }

        public ScoreboardEntry GetScoreboardEntry()
        {
            return new ScoreboardEntry(name, time);
        }

        public bool GetIsOkPressed()
        {
            return isOkPressed;
        }

        private void okNoName_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okName_Click(object sender, EventArgs e)
        {
            isOkPressed = true;
            this.Close();
        }
    }
}
