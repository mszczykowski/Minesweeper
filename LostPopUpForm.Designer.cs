namespace Minesweeper
{
    partial class LostPopUpForm
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
            this.topLabel = new System.Windows.Forms.Label();
            this.okNoName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topLabel.Location = new System.Drawing.Point(12, 23);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(238, 39);
            this.topLabel.TabIndex = 12;
            this.topLabel.Text = "You lost!";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okNoName
            // 
            this.okNoName.Location = new System.Drawing.Point(80, 92);
            this.okNoName.Margin = new System.Windows.Forms.Padding(4);
            this.okNoName.Name = "okNoName";
            this.okNoName.Size = new System.Drawing.Size(100, 28);
            this.okNoName.TabIndex = 16;
            this.okNoName.Text = "OK";
            this.okNoName.UseVisualStyleBackColor = true;
            this.okNoName.Click += new System.EventHandler(this.okNoName_Click);
            // 
            // LostPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 133);
            this.Controls.Add(this.okNoName);
            this.Controls.Add(this.topLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LostPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = ":(";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button okNoName;
    }
}