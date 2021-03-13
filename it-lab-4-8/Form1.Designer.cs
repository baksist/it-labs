
namespace it_lab_4_8
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumRadioButton = new System.Windows.Forms.RadioButton();
            this.productRadioButton = new System.Windows.Forms.RadioButton();
            this.calcButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(173, 60);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(159, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(59, 115);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(351, 169);
            this.resultTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productRadioButton);
            this.groupBox1.Controls.Add(this.sumRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(483, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choice";
            // 
            // sumRadioButton
            // 
            this.sumRadioButton.AutoSize = true;
            this.sumRadioButton.Checked = true;
            this.sumRadioButton.Location = new System.Drawing.Point(19, 22);
            this.sumRadioButton.Name = "sumRadioButton";
            this.sumRadioButton.Size = new System.Drawing.Size(57, 21);
            this.sumRadioButton.TabIndex = 0;
            this.sumRadioButton.TabStop = true;
            this.sumRadioButton.Text = "Sum";
            this.sumRadioButton.UseVisualStyleBackColor = true;
            // 
            // productRadioButton
            // 
            this.productRadioButton.AutoSize = true;
            this.productRadioButton.Location = new System.Drawing.Point(19, 49);
            this.productRadioButton.Name = "productRadioButton";
            this.productRadioButton.Size = new System.Drawing.Size(78, 21);
            this.productRadioButton.TabIndex = 1;
            this.productRadioButton.Text = "Product";
            this.productRadioButton.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(483, 230);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(166, 54);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 362);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton productRadioButton;
        private System.Windows.Forms.RadioButton sumRadioButton;
        private System.Windows.Forms.Button calcButton;
    }
}

