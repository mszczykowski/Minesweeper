using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void okNoName_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
