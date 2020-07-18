namespace Minesweeper
{
    partial class WinPopUpForm
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
            this.okName = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.okNoName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okName
            // 
            this.okName.Location = new System.Drawing.Point(189, 142);
            this.okName.Margin = new System.Windows.Forms.Padding(4);
            this.okName.Name = "okName";
            this.okName.Size = new System.Drawing.Size(100, 28);
            this.okName.TabIndex = 10;
            this.okName.Text = "OK";
            this.okName.UseVisualStyleBackColor = true;
            this.okName.Click += new System.EventHandler(this.okName_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(42, 142);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topLabel.Location = new System.Drawing.Point(12, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(308, 39);
            this.topLabel.TabIndex = 11;
            this.topLabel.Text = "Congratulations!";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(17, 58);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(303, 27);
            this.labelTime.TabIndex = 12;
            this.labelTime.Text = "You finished in: <> seconds";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(26, 101);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(137, 20);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Enter your name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(189, 101);
            this.nameBox.MaxLength = 10;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 14;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // okNoName
            // 
            this.okNoName.Location = new System.Drawing.Point(116, 98);
            this.okNoName.Margin = new System.Windows.Forms.Padding(4);
            this.okNoName.Name = "okNoName";
            this.okNoName.Size = new System.Drawing.Size(100, 28);
            this.okNoName.TabIndex = 15;
            this.okNoName.Text = "OK";
            this.okNoName.UseVisualStyleBackColor = true;
            this.okNoName.Click += new System.EventHandler(this.okNoName_Click);
            // 
            // WinPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 183);
            this.Controls.Add(this.okNoName);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.okName);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = ":)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okName;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button okNoName;
    }
}