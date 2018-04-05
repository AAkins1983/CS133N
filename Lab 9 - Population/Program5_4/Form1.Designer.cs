namespace Program5_4
{
    partial class Form1
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
            this.organismsLabel = new System.Windows.Forms.Label();
            this.increaseLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.organismsTextBox = new System.Windows.Forms.TextBox();
            this.increaseTextBox = new System.Windows.Forms.TextBox();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // organismsLabel
            // 
            this.organismsLabel.AutoSize = true;
            this.organismsLabel.Location = new System.Drawing.Point(13, 13);
            this.organismsLabel.Name = "organismsLabel";
            this.organismsLabel.Size = new System.Drawing.Size(146, 13);
            this.organismsLabel.TabIndex = 0;
            this.organismsLabel.Text = "Starting number of organisms:";
            // 
            // increaseLabel
            // 
            this.increaseLabel.AutoSize = true;
            this.increaseLabel.Location = new System.Drawing.Point(42, 41);
            this.increaseLabel.Name = "increaseLabel";
            this.increaseLabel.Size = new System.Drawing.Size(117, 13);
            this.increaseLabel.TabIndex = 1;
            this.increaseLabel.Text = "Average daily increase:";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(26, 72);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(133, 13);
            this.daysLabel.TabIndex = 2;
            this.daysLabel.Text = "Number of days to multiply:";
            // 
            // organismsTextBox
            // 
            this.organismsTextBox.Location = new System.Drawing.Point(166, 13);
            this.organismsTextBox.Name = "organismsTextBox";
            this.organismsTextBox.Size = new System.Drawing.Size(100, 20);
            this.organismsTextBox.TabIndex = 3;
            // 
            // increaseTextBox
            // 
            this.increaseTextBox.Location = new System.Drawing.Point(166, 41);
            this.increaseTextBox.Name = "increaseTextBox";
            this.increaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.increaseTextBox.TabIndex = 4;
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(166, 69);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 5;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(16, 167);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(250, 173);
            this.outputListBox.TabIndex = 6;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(99, 105);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 41);
            this.outputButton.TabIndex = 7;
            this.outputButton.Text = "Display and Save";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 353);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.increaseTextBox);
            this.Controls.Add(this.organismsTextBox);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.increaseLabel);
            this.Controls.Add(this.organismsLabel);
            this.Name = "Form1";
            this.Text = "Program5_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label organismsLabel;
        private System.Windows.Forms.Label increaseLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox organismsTextBox;
        private System.Windows.Forms.TextBox increaseTextBox;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

