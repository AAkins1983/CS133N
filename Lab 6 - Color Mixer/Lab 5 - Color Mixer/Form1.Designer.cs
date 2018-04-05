namespace Lab_5___Color_Mixer
{
    partial class colorMixer
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
            this.firstGroupBox = new System.Windows.Forms.GroupBox();
            this.secondGroupBox = new System.Windows.Forms.GroupBox();
            this.redRadioButton1 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton1 = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton1 = new System.Windows.Forms.RadioButton();
            this.redRadioButton2 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton2 = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton2 = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstGroupBox.SuspendLayout();
            this.secondGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstGroupBox
            // 
            this.firstGroupBox.Controls.Add(this.redRadioButton1);
            this.firstGroupBox.Controls.Add(this.blueRadioButton1);
            this.firstGroupBox.Controls.Add(this.yellowRadioButton1);
            this.firstGroupBox.Location = new System.Drawing.Point(12, 12);
            this.firstGroupBox.Name = "firstGroupBox";
            this.firstGroupBox.Size = new System.Drawing.Size(162, 141);
            this.firstGroupBox.TabIndex = 0;
            this.firstGroupBox.TabStop = false;
            this.firstGroupBox.Text = "Select the First Color";
            // 
            // secondGroupBox
            // 
            this.secondGroupBox.Controls.Add(this.redRadioButton2);
            this.secondGroupBox.Controls.Add(this.blueRadioButton2);
            this.secondGroupBox.Controls.Add(this.yellowRadioButton2);
            this.secondGroupBox.Location = new System.Drawing.Point(180, 12);
            this.secondGroupBox.Name = "secondGroupBox";
            this.secondGroupBox.Size = new System.Drawing.Size(166, 141);
            this.secondGroupBox.TabIndex = 0;
            this.secondGroupBox.TabStop = false;
            this.secondGroupBox.Text = "Select the Second Color";
            // 
            // redRadioButton1
            // 
            this.redRadioButton1.AutoSize = true;
            this.redRadioButton1.Location = new System.Drawing.Point(39, 29);
            this.redRadioButton1.Name = "redRadioButton1";
            this.redRadioButton1.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton1.TabIndex = 1;
            this.redRadioButton1.TabStop = true;
            this.redRadioButton1.Text = "Red";
            this.redRadioButton1.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton1
            // 
            this.blueRadioButton1.AutoSize = true;
            this.blueRadioButton1.Location = new System.Drawing.Point(39, 66);
            this.blueRadioButton1.Name = "blueRadioButton1";
            this.blueRadioButton1.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton1.TabIndex = 2;
            this.blueRadioButton1.TabStop = true;
            this.blueRadioButton1.Text = "Blue";
            this.blueRadioButton1.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButton1
            // 
            this.yellowRadioButton1.AutoSize = true;
            this.yellowRadioButton1.Location = new System.Drawing.Point(39, 106);
            this.yellowRadioButton1.Name = "yellowRadioButton1";
            this.yellowRadioButton1.Size = new System.Drawing.Size(56, 17);
            this.yellowRadioButton1.TabIndex = 3;
            this.yellowRadioButton1.TabStop = true;
            this.yellowRadioButton1.Text = "Yellow";
            this.yellowRadioButton1.UseVisualStyleBackColor = true;
            // 
            // redRadioButton2
            // 
            this.redRadioButton2.AutoSize = true;
            this.redRadioButton2.Location = new System.Drawing.Point(43, 29);
            this.redRadioButton2.Name = "redRadioButton2";
            this.redRadioButton2.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton2.TabIndex = 1;
            this.redRadioButton2.TabStop = true;
            this.redRadioButton2.Text = "Red";
            this.redRadioButton2.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton2
            // 
            this.blueRadioButton2.AutoSize = true;
            this.blueRadioButton2.Location = new System.Drawing.Point(43, 66);
            this.blueRadioButton2.Name = "blueRadioButton2";
            this.blueRadioButton2.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton2.TabIndex = 2;
            this.blueRadioButton2.TabStop = true;
            this.blueRadioButton2.Text = "Blue";
            this.blueRadioButton2.UseVisualStyleBackColor = true;
            // 
            // yellowRadioButton2
            // 
            this.yellowRadioButton2.AutoSize = true;
            this.yellowRadioButton2.Location = new System.Drawing.Point(43, 106);
            this.yellowRadioButton2.Name = "yellowRadioButton2";
            this.yellowRadioButton2.Size = new System.Drawing.Size(56, 17);
            this.yellowRadioButton2.TabIndex = 3;
            this.yellowRadioButton2.TabStop = true;
            this.yellowRadioButton2.Text = "Yellow";
            this.yellowRadioButton2.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(99, 159);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(75, 38);
            this.mixButton.TabIndex = 1;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(180, 159);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // colorMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 208);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.secondGroupBox);
            this.Controls.Add(this.firstGroupBox);
            this.Name = "colorMixer";
            this.Text = "Color Mixer";
            this.firstGroupBox.ResumeLayout(false);
            this.firstGroupBox.PerformLayout();
            this.secondGroupBox.ResumeLayout(false);
            this.secondGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox firstGroupBox;
        private System.Windows.Forms.RadioButton redRadioButton1;
        private System.Windows.Forms.RadioButton blueRadioButton1;
        private System.Windows.Forms.RadioButton yellowRadioButton1;
        private System.Windows.Forms.GroupBox secondGroupBox;
        private System.Windows.Forms.RadioButton redRadioButton2;
        private System.Windows.Forms.RadioButton blueRadioButton2;
        private System.Windows.Forms.RadioButton yellowRadioButton2;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

