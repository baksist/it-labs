namespace it_lab_6_15
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
            this.arrayTextBox = new System.Windows.Forms.TextBox();
            this.fillArrayButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // arrayTextBox
            // 
            this.arrayTextBox.Location = new System.Drawing.Point(32, 30);
            this.arrayTextBox.Multiline = true;
            this.arrayTextBox.Name = "arrayTextBox";
            this.arrayTextBox.ReadOnly = true;
            this.arrayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.arrayTextBox.Size = new System.Drawing.Size(316, 304);
            this.arrayTextBox.TabIndex = 0;
            this.arrayTextBox.TabStop = false;
            // 
            // fillArrayButton
            // 
            this.fillArrayButton.Location = new System.Drawing.Point(32, 353);
            this.fillArrayButton.Name = "fillArrayButton";
            this.fillArrayButton.Size = new System.Drawing.Size(99, 38);
            this.fillArrayButton.TabIndex = 1;
            this.fillArrayButton.Text = "Fill Array";
            this.fillArrayButton.UseVisualStyleBackColor = true;
            this.fillArrayButton.Click += new System.EventHandler(this.fillArrayButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(287, 371);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of elements:";
            // 
            // resultButton
            // 
            this.resultButton.Enabled = false;
            this.resultButton.Location = new System.Drawing.Point(32, 421);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(99, 38);
            this.resultButton.TabIndex = 4;
            this.resultButton.Text = "Calculate";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(154, 431);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(194, 20);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 494);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.fillArrayButton);
            this.Controls.Add(this.arrayTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arrayTextBox;
        private System.Windows.Forms.Button fillArrayButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

