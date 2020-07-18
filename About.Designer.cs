namespace Minesweeper
{
    partial class About
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
            this.labelTop = new System.Windows.Forms.Label();
            this.okNoName = new System.Windows.Forms.Button();
            this.labelBottom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTop.Location = new System.Drawing.Point(12, 9);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(238, 41);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Minesweeper";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okNoName
            // 
            this.okNoName.Location = new System.Drawing.Point(83, 92);
            this.okNoName.Margin = new System.Windows.Forms.Padding(4);
            this.okNoName.Name = "okNoName";
            this.okNoName.Size = new System.Drawing.Size(100, 28);
            this.okNoName.TabIndex = 17;
            this.okNoName.Text = "OK";
            this.okNoName.UseVisualStyleBackColor = true;
            this.okNoName.Click += new System.EventHandler(this.okNoName_Click);
            // 
            // labelBottom
            // 
            this.labelBottom.Location = new System.Drawing.Point(17, 50);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(233, 38);
            this.labelBottom.TabIndex = 18;
            this.labelBottom.Text = "Michał Szczykowski 2020";
            this.labelBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 133);
            this.Controls.Add(this.labelBottom);
            this.Controls.Add(this.okNoName);
            this.Controls.Add(this.labelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Button okNoName;
        private System.Windows.Forms.Label labelBottom;
    }
}