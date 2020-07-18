using System;
using System.Windows.Forms;

namespace Minesweeper
{
    /// <summary>
    /// Scoreboard gui.
    /// </summary>
    public partial class ScoreboardForm : Form
    {
        public ScoreboardForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Checks if scoreboard is available and displays scoreboard or error message accordingly.
        /// </summary>
        public void ShowForm()
        {
            if (GetIsScoreboardAvailable())
            {
                ShowDialog();
            }
            else
            {
                new ErrorMessageForm("Scoreboard is currently unavailable");
            }
        }

        protected void SetDataSources()
        {
            dataGridViewEasy.DataSource = PickTable(0);
            dataGridViewAdvanced.DataSource = PickTable(1);
            dataGridViewExpert.DataSource = PickTable(2);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (PickTable(tabControl.SelectedIndex)[0] == null)
            {
                new ErrorMessageForm("Selected scoreboard is empty");
            }
            else
            {
                ResetAreYouSureForm areYouSure = new ResetAreYouSureForm();
                areYouSure.ShowDialog();
                if (areYouSure.GetIsOkPressed())
                {
                    Reset(tabControl.SelectedIndex);
                    dataGridViewEasy.Refresh();
                    dataGridViewAdvanced.Refresh();
                    dataGridViewExpert.Refresh();
                }
            }
        }

        protected virtual ScoreboardEntry[] PickTable(int diffLevel)
        {
            return null;
        }

        public virtual bool IsEligible(int time, int diffLevel)
        {
            return false;
        }

        public virtual void AddEntry(ScoreboardEntry entry, int diffLevel)
        {

        }

        protected virtual void Reset(int diffLevel)
        {

        }

        protected virtual bool GetIsScoreboardAvailable()
        {
            return false;
        }

        /// <summary>
        /// Used to disable focus on data grid view, scoreboard entries shouldn't be focusable.
        /// </summary>
        private void dataGridViewEasy_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewEasy.ClearSelection();
        }

        private void dataGridViewAdvanced_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewAdvanced.ClearSelection();
        }

        private void dataGridViewExpert_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewExpert.ClearSelection();
        }
    }
}
