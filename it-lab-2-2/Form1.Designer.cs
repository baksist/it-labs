
namespace it_lab_2_2
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
            this.argLabel = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.argTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // argLabel
            // 
            this.argLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.argLabel.AutoSize = true;
            this.argLabel.Location = new System.Drawing.Point(39, 42);
            this.argLabel.Name = "argLabel";
            this.argLabel.Size = new System.Drawing.Size(59, 17);
            this.argLabel.TabIndex = 0;
            this.argLabel.Text = "Enter X:";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(39, 94);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(52, 17);
            this.resLabel.TabIndex = 1;
            this.resLabel.Text = "Result:";
            // 
            // resTextBox
            // 
            this.resTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resTextBox.Location = new System.Drawing.Point(42, 114);
            this.resTextBox.Multiline = true;
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.ReadOnly = true;
            this.resTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resTextBox.Size = new System.Drawing.Size(370, 187);
            this.resTextBox.TabIndex = 2;
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Location = new System.Drawing.Point(337, 319);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // argTextBox
            // 
            this.argTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.argTextBox.Location = new System.Drawing.Point(112, 39);
            this.argTextBox.Name = "argTextBox";
            this.argTextBox.Size = new System.Drawing.Size(300, 22);
            this.argTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 365);
            this.Controls.Add(this.argTextBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.resTextBox);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.argLabel);
            this.MinimumSize = new System.Drawing.Size(474, 411);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label argLabel;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.TextBox resTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox argTextBox;
    }
}

