using System;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Used to ask user if he is sure about resetting scoreboard
    /// </summary>
    public partial class ResetAreYouSureForm : Form
    {
        private bool isOkPressed;
        public ResetAreYouSureForm()
        {
            InitializeComponent();
            isOkPressed = false;
        }
        private void yesButton_Click(object sender, EventArgs e)
        {
            isOkPressed = true;
            Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool GetIsOkPressed()
        {
            return isOkPressed;
        }
    }
}
