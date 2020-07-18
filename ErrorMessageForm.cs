using System;
using System.Media;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Simple error popup that shows message and plays error sound.
    /// </summary>
    public partial class ErrorMessageForm : Form
    {
        public ErrorMessageForm(string info)
        {
            InitializeComponent();
            infoLabel.Text = info;
            SystemSounds.Hand.Play();
            ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
