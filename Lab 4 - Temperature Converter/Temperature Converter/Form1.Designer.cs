namespace Temperature_Converter
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
            this.enterTempLabel = new System.Windows.Forms.Label();
            this.fahrenheitButton = new System.Windows.Forms.Button();
            this.celciusButton = new System.Windows.Forms.Button();
            this.temperatureOutputLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterTempLabel
            // 
            this.enterTempLabel.AutoSize = true;
            this.enterTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTempLabel.Location = new System.Drawing.Point(61, 27);
            this.enterTempLabel.Name = "enterTempLabel";
            this.enterTempLabel.Size = new System.Drawing.Size(130, 18);
            this.enterTempLabel.TabIndex = 0;
            this.enterTempLabel.Text = "Enter temperature:";
            // 
            // fahrenheitButton
            // 
            this.fahrenheitButton.Location = new System.Drawing.Point(64, 79);
            this.fahrenheitButton.Name = "fahrenheitButton";
            this.fahrenheitButton.Size = new System.Drawing.Size(75, 56);
            this.fahrenheitButton.TabIndex = 1;
            this.fahrenheitButton.Text = "Fahrenheit Temperature";
            this.fahrenheitButton.UseVisualStyleBackColor = true;
            this.fahrenheitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // celciusButton
            // 
            this.celciusButton.Location = new System.Drawing.Point(221, 79);
            this.celciusButton.Name = "celciusButton";
            this.celciusButton.Size = new System.Drawing.Size(75, 56);
            this.celciusButton.TabIndex = 2;
            this.celciusButton.Text = "Celcius Temperature";
            this.celciusButton.UseVisualStyleBackColor = true;
            this.celciusButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // temperatureOutputLabel
            // 
            this.temperatureOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperatureOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureOutputLabel.Location = new System.Drawing.Point(64, 179);
            this.temperatureOutputLabel.Name = "temperatureOutputLabel";
            this.temperatureOutputLabel.Size = new System.Drawing.Size(232, 23);
            this.temperatureOutputLabel.TabIndex = 3;
            this.temperatureOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(64, 242);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(221, 242);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(197, 28);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(100, 20);
            this.temperatureTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 299);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.temperatureOutputLabel);
            this.Controls.Add(this.celciusButton);
            this.Controls.Add(this.fahrenheitButton);
            this.Controls.Add(this.enterTempLabel);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterTempLabel;
        private System.Windows.Forms.Button fahrenheitButton;
        private System.Windows.Forms.Button celciusButton;
        private System.Windows.Forms.Label temperatureOutputLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox temperatureTextBox;
    }
}

