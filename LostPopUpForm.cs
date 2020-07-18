using System;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Simple popup after loss
    /// </summary>
    public partial class LostPopUpForm : Form
    {
        public LostPopUpForm()
        {
            InitializeComponent();
            ShowDialog();
        }

        private void okNoName_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
