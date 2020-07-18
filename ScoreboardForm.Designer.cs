namespace Minesweeper
{
    partial class ScoreboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEasy = new System.Windows.Forms.TabPage();
            this.dataGridViewEasy = new System.Windows.Forms.DataGridView();
            this.ColumnRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAdvanced = new System.Windows.Forms.TabPage();
            this.dataGridViewAdvanced = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageExpert = new System.Windows.Forms.TabPage();
            this.dataGridViewExpert = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageEasy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEasy)).BeginInit();
            this.tabPageAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvanced)).BeginInit();
            this.tabPageExpert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpert)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEasy);
            this.tabControl.Controls.Add(this.tabPageAdvanced);
            this.tabControl.Controls.Add(this.tabPageExpert);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(456, 372);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageEasy
            // 
            this.tabPageEasy.Controls.Add(this.dataGridViewEasy);
            this.tabPageEasy.Location = new System.Drawing.Point(4, 25);
            this.tabPageEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEasy.Name = "tabPageEasy";
            this.tabPageEasy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEasy.Size = new System.Drawing.Size(448, 343);
            this.tabPageEasy.TabIndex = 0;
            this.tabPageEasy.Text = "Beginner";
            this.tabPageEasy.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEasy
            // 
            this.dataGridViewEasy.AllowUserToAddRows = false;
            this.dataGridViewEasy.AllowUserToDeleteRows = false;
            this.dataGridViewEasy.AllowUserToResizeColumns = false;
            this.dataGridViewEasy.AllowUserToResizeRows = false;
            this.dataGridViewEasy.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewEasy.ColumnHeadersHeight = 29;
            this.dataGridViewEasy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEasy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRank,
            this.ColumnName,
            this.ColumnTime});
            this.dataGridViewEasy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEasy.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEasy.MultiSelect = false;
            this.dataGridViewEasy.Name = "dataGridViewEasy";
            this.dataGridViewEasy.ReadOnly = true;
            this.dataGridViewEasy.RowHeadersVisible = false;
            this.dataGridViewEasy.RowHeadersWidth = 51;
            this.dataGridViewEasy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEasy.RowTemplate.Height = 24;
            this.dataGridViewEasy.RowTemplate.ReadOnly = true;
            this.dataGridViewEasy.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEasy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewEasy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEasy.ShowCellErrors = false;
            this.dataGridViewEasy.ShowCellToolTips = false;
            this.dataGridViewEasy.ShowEditingIcon = false;
            this.dataGridViewEasy.Size = new System.Drawing.Size(442, 339);
            this.dataGridViewEasy.TabIndex = 2;
            this.dataGridViewEasy.TabStop = false;
            this.dataGridViewEasy.SelectionChanged += new System.EventHandler(this.dataGridViewEasy_SelectionChanged);
            // 
            // ColumnRank
            // 
            this.ColumnRank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnRank.DataPropertyName = "Rank";
            this.ColumnRank.HeaderText = "Rank";
            this.ColumnRank.MinimumWidth = 6;
            this.ColumnRank.Name = "ColumnRank";
            this.ColumnRank.ReadOnly = true;
            this.ColumnRank.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnRank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnRank.Width = 50;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnName.Width = 212;
            // 
            // ColumnTime
            // 
            this.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTime.DataPropertyName = "Time";
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.MinimumWidth = 6;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTime.Width = 70;
            // 
            // tabPageAdvanced
            // 
            this.tabPageAdvanced.Controls.Add(this.dataGridViewAdvanced);
            this.tabPageAdvanced.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdvanced.Name = "tabPageAdvanced";
            this.tabPageAdvanced.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAdvanced.Size = new System.Drawing.Size(448, 343);
            this.tabPageAdvanced.TabIndex = 1;
            this.tabPageAdvanced.Text = "Advanced";
            this.tabPageAdvanced.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdvanced
            // 
            this.dataGridViewAdvanced.AllowUserToAddRows = false;
            this.dataGridViewAdvanced.AllowUserToDeleteRows = false;
            this.dataGridViewAdvanced.AllowUserToResizeColumns = false;
            this.dataGridViewAdvanced.AllowUserToResizeRows = false;
            this.dataGridViewAdvanced.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewAdvanced.ColumnHeadersHeight = 29;
            this.dataGridViewAdvanced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAdvanced.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAdvanced.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAdvanced.MultiSelect = false;
            this.dataGridViewAdvanced.Name = "dataGridViewAdvanced";
            this.dataGridViewAdvanced.ReadOnly = true;
            this.dataGridViewAdvanced.RowHeadersVisible = false;
            this.dataGridViewAdvanced.RowHeadersWidth = 51;
            this.dataGridViewAdvanced.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAdvanced.RowTemplate.Height = 24;
            this.dataGridViewAdvanced.RowTemplate.ReadOnly = true;
            this.dataGridViewAdvanced.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdvanced.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewAdvanced.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAdvanced.ShowCellErrors = false;
            this.dataGridViewAdvanced.ShowCellToolTips = false;
            this.dataGridViewAdvanced.ShowEditingIcon = false;
            this.dataGridViewAdvanced.Size = new System.Drawing.Size(442, 339);
            this.dataGridViewAdvanced.TabIndex = 3;
            this.dataGridViewAdvanced.TabStop = false;
            this.dataGridViewAdvanced.SelectionChanged += new System.EventHandler(this.dataGridViewAdvanced_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Rank";
            this.dataGridViewTextBoxColumn1.HeaderText = "Rank";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 212;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // tabPageExpert
            // 
            this.tabPageExpert.Controls.Add(this.dataGridViewExpert);
            this.tabPageExpert.Location = new System.Drawing.Point(4, 25);
            this.tabPageExpert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageExpert.Name = "tabPageExpert";
            this.tabPageExpert.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageExpert.Size = new System.Drawing.Size(448, 343);
            this.tabPageExpert.TabIndex = 2;
            this.tabPageExpert.Text = "Expert";
            this.tabPageExpert.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExpert
            // 
            this.dataGridViewExpert.AllowUserToAddRows = false;
            this.dataGridViewExpert.AllowUserToDeleteRows = false;
            this.dataGridViewExpert.AllowUserToResizeColumns = false;
            this.dataGridViewExpert.AllowUserToResizeRows = false;
            this.dataGridViewExpert.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewExpert.ColumnHeadersHeight = 29;
            this.dataGridViewExpert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewExpert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewExpert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExpert.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewExpert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewExpert.MultiSelect = false;
            this.dataGridViewExpert.Name = "dataGridViewExpert";
            this.dataGridViewExpert.ReadOnly = true;
            this.dataGridViewExpert.RowHeadersVisible = false;
            this.dataGridViewExpert.RowHeadersWidth = 51;
            this.dataGridViewExpert.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewExpert.RowTemplate.Height = 24;
            this.dataGridViewExpert.RowTemplate.ReadOnly = true;
            this.dataGridViewExpert.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExpert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewExpert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExpert.ShowCellErrors = false;
            this.dataGridViewExpert.ShowCellToolTips = false;
            this.dataGridViewExpert.ShowEditingIcon = false;
            this.dataGridViewExpert.Size = new System.Drawing.Size(442, 339);
            this.dataGridViewExpert.TabIndex = 4;
            this.dataGridViewExpert.TabStop = false;
            this.dataGridViewExpert.SelectionChanged += new System.EventHandler(this.dataGridViewExpert_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rank";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rank";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 212;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn6.HeaderText = "Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(346, 380);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Close";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(13, 380);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 28);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ScoreboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 418);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScoreboardForm";
            this.ShowIcon = false;
            this.Text = "Scoreboard";
            this.tabControl.ResumeLayout(false);
            this.tabPageEasy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEasy)).EndInit();
            this.tabPageAdvanced.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdvanced)).EndInit();
            this.tabPageExpert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEasy;
        private System.Windows.Forms.TabPage tabPageAdvanced;
        private System.Windows.Forms.TabPage tabPageExpert;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataGridViewEasy;
        private System.Windows.Forms.DataGridView dataGridViewAdvanced;
        private System.Windows.Forms.DataGridView dataGridViewExpert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}