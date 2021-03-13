
namespace it_lab_3_8
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
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.funcGroupBox = new System.Windows.Forms.GroupBox();
            this.shRadioButton = new System.Windows.Forms.RadioButton();
            this.chRadioButton = new System.Windows.Forms.RadioButton();
            this.expRadioButton = new System.Windows.Forms.RadioButton();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.funcGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(61, 62);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(59, 17);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Enter X:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(141, 62);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(264, 22);
            this.textBoxX.TabIndex = 1;
            // 
            // funcGroupBox
            // 
            this.funcGroupBox.Controls.Add(this.expRadioButton);
            this.funcGroupBox.Controls.Add(this.chRadioButton);
            this.funcGroupBox.Controls.Add(this.shRadioButton);
            this.funcGroupBox.Location = new System.Drawing.Point(470, 62);
            this.funcGroupBox.Name = "funcGroupBox";
            this.funcGroupBox.Size = new System.Drawing.Size(164, 131);
            this.funcGroupBox.TabIndex = 2;
            this.funcGroupBox.TabStop = false;
            this.funcGroupBox.Text = "F(x)";
            // 
            // shRadioButton
            // 
            this.shRadioButton.AutoSize = true;
            this.shRadioButton.Checked = true;
            this.shRadioButton.Location = new System.Drawing.Point(19, 32);
            this.shRadioButton.Name = "shRadioButton";
            this.shRadioButton.Size = new System.Drawing.Size(44, 21);
            this.shRadioButton.TabIndex = 0;
            this.shRadioButton.TabStop = true;
            this.shRadioButton.Text = "sh";
            this.shRadioButton.UseVisualStyleBackColor = true;
            // 
            // chRadioButton
            // 
            this.chRadioButton.AutoSize = true;
            this.chRadioButton.Location = new System.Drawing.Point(19, 59);
            this.chRadioButton.Name = "chRadioButton";
            this.chRadioButton.Size = new System.Drawing.Size(44, 21);
            this.chRadioButton.TabIndex = 1;
            this.chRadioButton.Text = "ch";
            this.chRadioButton.UseVisualStyleBackColor = true;
            // 
            // expRadioButton
            // 
            this.expRadioButton.AutoSize = true;
            this.expRadioButton.Location = new System.Drawing.Point(19, 86);
            this.expRadioButton.Name = "expRadioButton";
            this.expRadioButton.Size = new System.Drawing.Size(51, 21);
            this.expRadioButton.TabIndex = 2;
            this.expRadioButton.Text = "exp";
            this.expRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(64, 127);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(341, 161);
            this.resultTextBox.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(470, 234);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(164, 54);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 346);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.funcGroupBox);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.funcGroupBox.ResumeLayout(false);
            this.funcGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.GroupBox funcGroupBox;
        private System.Windows.Forms.RadioButton expRadioButton;
        private System.Windows.Forms.RadioButton chRadioButton;
        private System.Windows.Forms.RadioButton shRadioButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button calcButton;
    }
}

