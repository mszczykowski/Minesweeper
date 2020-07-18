using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Form used to get custom game sizes.
    /// </summary>
    public partial class CustomFieldCreatorForm : Form
    {
        private bool isLenghtCorrect, isWidthCorrect, isOkPressed;
        private int length, width, mines;
        private int maxLength, maxWidth;
        private int minLength, minWidth;
        private int maxMines;
        public CustomFieldCreatorForm()
        {
            InitializeComponent();
            isLenghtCorrect = false;
            isWidthCorrect = false;
            okButton.Enabled = false;
            minesTextBox.Enabled = false;
            maxLength = 24;
            minLength = 5;
            maxWidth = 50;
            minWidth = 5;
            this.infoLabel.Text = "Enter correct board size first";
            AcceptButton = okButton;
        }

        private void CheckIsSizeCorrect()
        {
            this.okButton.Enabled = this.minesTextBox.Enabled = false;
            this.minesTextBox.Text = "";
            mines = -1;
            if (isWidthCorrect)
            {
                if (isLenghtCorrect)
                {
                    this.minesTextBox.Enabled = true;
                    maxMines = (length - 1) * (width - 1);
                }
            }
        }
        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (WidthTextBox.Text != "")
            {
                width = Convert.ToInt32(this.WidthTextBox.Text, 10);
                if (width >= minWidth && width <= maxWidth)
                {
                    isWidthCorrect = true;
                    this.WidthTextBox.ForeColor = Color.Black;
                }
                else
                {
                    isWidthCorrect = false;
                    this.WidthTextBox.ForeColor = Color.Red;
                }
                CheckIsSizeCorrect();
            }
        }

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LengthTextBox.Text != "")
            {
                length = Convert.ToInt32(this.LengthTextBox.Text, 10);
                if (length >= minLength && length <= maxLength)
                {
                    isLenghtCorrect = true;
                    this.LengthTextBox.ForeColor = Color.Black;
                }
                else
                {
                    isLenghtCorrect = false;
                    this.LengthTextBox.ForeColor = Color.Red;
                }
                CheckIsSizeCorrect();
            }
        }

        private void minesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (minesTextBox.Text != "")
            {
                mines = Convert.ToInt32(this.minesTextBox.Text, 10);
                if (mines >= 1 && mines <= maxMines)
                {
                    this.okButton.Enabled = true;
                    this.minesTextBox.ForeColor = Color.Black;
                }
                else
                {
                    this.okButton.Enabled  = false;
                    this.minesTextBox.ForeColor = Color.Red;
                }
            }
        }

        private void WidthTextBox_Enter(object sender, EventArgs e)
        {
            this.infoLabel.Text = "Minimum width is " + minWidth + " and max is " + maxWidth;
        }

        private void LengthTextBox_Enter(object sender, EventArgs e)
        {
            this.infoLabel.Text = "Minimum length is " + minLength + " and max is " + maxLength;
        }

        private void minesTextBox_Enter(object sender, EventArgs e)
        {
            this.infoLabel.Text = "Minimum amount is 1 max is " + maxMines;
        }

        public CustomGameSize GetCustomGameSize()
        {
            return new CustomGameSize(width,length,mines);
        }
        public bool GetisOkPressed()
        {
            return isOkPressed;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            isOkPressed = true;
            this.Close();
        }

        private void avoidLetters(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }
    }
}
