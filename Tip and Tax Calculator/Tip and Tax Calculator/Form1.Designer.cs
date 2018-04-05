namespace Tip_and_Tax_Calculator
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
            this.foodChargeLabel = new System.Windows.Forms.Label();
            this.foodChargeTextBox = new System.Windows.Forms.TextBox();
            this.tipLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tipPercentageOutputLabel = new System.Windows.Forms.Label();
            this.taxPercentageOutputLabel = new System.Windows.Forms.Label();
            this.totalChargeOutputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodChargeLabel
            // 
            this.foodChargeLabel.AutoSize = true;
            this.foodChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodChargeLabel.Location = new System.Drawing.Point(6, 35);
            this.foodChargeLabel.Name = "foodChargeLabel";
            this.foodChargeLabel.Size = new System.Drawing.Size(135, 16);
            this.foodChargeLabel.TabIndex = 0;
            this.foodChargeLabel.Text = "Enter food charge:";
            // 
            // foodChargeTextBox
            // 
            this.foodChargeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodChargeTextBox.Location = new System.Drawing.Point(147, 32);
            this.foodChargeTextBox.Name = "foodChargeTextBox";
            this.foodChargeTextBox.Size = new System.Drawing.Size(100, 22);
            this.foodChargeTextBox.TabIndex = 1;
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.Location = new System.Drawing.Point(73, 74);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(68, 16);
            this.tipLabel.TabIndex = 2;
            this.tipLabel.Text = "15% Tip:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(34, 115);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(107, 16);
            this.taxLabel.TabIndex = 3;
            this.taxLabel.Text = "7% Sales Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(93, 177);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 16);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total:";
            // 
            // tipPercentageOutputLabel
            // 
            this.tipPercentageOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipPercentageOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipPercentageOutputLabel.Location = new System.Drawing.Point(147, 74);
            this.tipPercentageOutputLabel.Name = "tipPercentageOutputLabel";
            this.tipPercentageOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.tipPercentageOutputLabel.TabIndex = 5;
            this.tipPercentageOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxPercentageOutputLabel
            // 
            this.taxPercentageOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxPercentageOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxPercentageOutputLabel.Location = new System.Drawing.Point(147, 112);
            this.taxPercentageOutputLabel.Name = "taxPercentageOutputLabel";
            this.taxPercentageOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.taxPercentageOutputLabel.TabIndex = 6;
            this.taxPercentageOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalChargeOutputLabel
            // 
            this.totalChargeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalChargeOutputLabel.Location = new System.Drawing.Point(147, 177);
            this.totalChargeOutputLabel.Name = "totalChargeOutputLabel";
            this.totalChargeOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalChargeOutputLabel.TabIndex = 7;
            this.totalChargeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(47, 226);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(147, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalChargeOutputLabel);
            this.Controls.Add(this.taxPercentageOutputLabel);
            this.Controls.Add(this.tipPercentageOutputLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.foodChargeTextBox);
            this.Controls.Add(this.foodChargeLabel);
            this.Name = "Form1";
            this.Text = "Tip and Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodChargeLabel;
        private System.Windows.Forms.TextBox foodChargeTextBox;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tipPercentageOutputLabel;
        private System.Windows.Forms.Label taxPercentageOutputLabel;
        private System.Windows.Forms.Label totalChargeOutputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

