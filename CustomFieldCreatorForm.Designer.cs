namespace Minesweeper
{
    partial class CustomFieldCreatorForm
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
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.minesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.minesLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(136, 73);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WidthTextBox.MaxLength = 2;
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(92, 22);
            this.WidthTextBox.TabIndex = 0;
            this.WidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            this.WidthTextBox.Enter += new System.EventHandler(this.WidthTextBox_Enter);
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.avoidLetters);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(136, 105);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthTextBox.MaxLength = 2;
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(92, 22);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.lengthTextBox_TextChanged);
            this.LengthTextBox.Enter += new System.EventHandler(this.LengthTextBox_Enter);
            this.LengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.avoidLetters);
            // 
            // minesTextBox
            // 
            this.minesTextBox.Location = new System.Drawing.Point(136, 137);
            this.minesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.minesTextBox.MaxLength = 4;
            this.minesTextBox.Name = "minesTextBox";
            this.minesTextBox.Size = new System.Drawing.Size(92, 22);
            this.minesTextBox.TabIndex = 2;
            this.minesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minesTextBox.TextChanged += new System.EventHandler(this.minesTextBox_TextChanged);
            this.minesTextBox.Enter += new System.EventHandler(this.minesTextBox_Enter);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create custom game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.widthLabel.Location = new System.Drawing.Point(45, 73);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(57, 20);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lengthLabel.Location = new System.Drawing.Point(45, 105);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(65, 20);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Length:";
            // 
            // minesLabel
            // 
            this.minesLabel.AutoSize = true;
            this.minesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minesLabel.Location = new System.Drawing.Point(45, 137);
            this.minesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minesLabel.Name = "minesLabel";
            this.minesLabel.Size = new System.Drawing.Size(59, 20);
            this.minesLabel.TabIndex = 6;
            this.minesLabel.Text = "Mines:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(19, 200);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(166, 200);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(19, 163);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(247, 36);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "infolabel";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomFieldCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 241);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.minesLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minesTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomFieldCreator";
            this.ShowIcon = false;
            this.Text = "Custom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox minesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label minesLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label infoLabel;
    }
}