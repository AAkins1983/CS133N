namespace Program6_6
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
            this.daysLabel = new System.Windows.Forms.Label();
            this.medsLabel = new System.Windows.Forms.Label();
            this.surgLabel = new System.Windows.Forms.Label();
            this.labLabel = new System.Windows.Forms.Label();
            this.rehabLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.medsTextBox = new System.Windows.Forms.TextBox();
            this.surgTextBox = new System.Windows.Forms.TextBox();
            this.labTextBox = new System.Windows.Forms.TextBox();
            this.rehabTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(13, 13);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(114, 13);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "No. of days in hospital:";
            // 
            // medsLabel
            // 
            this.medsLabel.AutoSize = true;
            this.medsLabel.Location = new System.Drawing.Point(13, 39);
            this.medsLabel.Name = "medsLabel";
            this.medsLabel.Size = new System.Drawing.Size(104, 13);
            this.medsLabel.TabIndex = 1;
            this.medsLabel.Text = "Medication Charges:";
            // 
            // surgLabel
            // 
            this.surgLabel.AutoSize = true;
            this.surgLabel.Location = new System.Drawing.Point(13, 65);
            this.surgLabel.Name = "surgLabel";
            this.surgLabel.Size = new System.Drawing.Size(90, 13);
            this.surgLabel.TabIndex = 2;
            this.surgLabel.Text = "Surgical Charges:";
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Location = new System.Drawing.Point(13, 92);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(54, 13);
            this.labLabel.TabIndex = 3;
            this.labLabel.Text = "Lab Fees:";
            // 
            // rehabLabel
            // 
            this.rehabLabel.AutoSize = true;
            this.rehabLabel.Location = new System.Drawing.Point(12, 122);
            this.rehabLabel.Name = "rehabLabel";
            this.rehabLabel.Size = new System.Drawing.Size(120, 13);
            this.rehabLabel.TabIndex = 4;
            this.rehabLabel.Text = "Physical Rehab Chares:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(134, 13);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 5;
            // 
            // medsTextBox
            // 
            this.medsTextBox.Location = new System.Drawing.Point(134, 40);
            this.medsTextBox.Name = "medsTextBox";
            this.medsTextBox.Size = new System.Drawing.Size(100, 20);
            this.medsTextBox.TabIndex = 6;
            // 
            // surgTextBox
            // 
            this.surgTextBox.Location = new System.Drawing.Point(134, 67);
            this.surgTextBox.Name = "surgTextBox";
            this.surgTextBox.Size = new System.Drawing.Size(100, 20);
            this.surgTextBox.TabIndex = 7;
            // 
            // labTextBox
            // 
            this.labTextBox.Location = new System.Drawing.Point(134, 92);
            this.labTextBox.Name = "labTextBox";
            this.labTextBox.Size = new System.Drawing.Size(100, 20);
            this.labTextBox.TabIndex = 8;
            // 
            // rehabTextBox
            // 
            this.rehabTextBox.Location = new System.Drawing.Point(134, 119);
            this.rehabTextBox.Name = "rehabTextBox";
            this.rehabTextBox.Size = new System.Drawing.Size(100, 20);
            this.rehabTextBox.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(159, 190);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(15, 155);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(218, 23);
            this.outputLabel.TabIndex = 11;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 225);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.rehabTextBox);
            this.Controls.Add(this.labTextBox);
            this.Controls.Add(this.surgTextBox);
            this.Controls.Add(this.medsTextBox);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.rehabLabel);
            this.Controls.Add(this.labLabel);
            this.Controls.Add(this.surgLabel);
            this.Controls.Add(this.medsLabel);
            this.Controls.Add(this.daysLabel);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label medsLabel;
        private System.Windows.Forms.Label surgLabel;
        private System.Windows.Forms.Label labLabel;
        private System.Windows.Forms.Label rehabLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox medsTextBox;
        private System.Windows.Forms.TextBox surgTextBox;
        private System.Windows.Forms.TextBox labTextBox;
        private System.Windows.Forms.TextBox rehabTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

