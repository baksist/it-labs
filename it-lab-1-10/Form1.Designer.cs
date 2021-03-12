
namespace it_lab_1_10
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
            this.asteriskButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.zeroesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asteriskButton
            // 
            this.asteriskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asteriskButton.Location = new System.Drawing.Point(29, 36);
            this.asteriskButton.Name = "asteriskButton";
            this.asteriskButton.Size = new System.Drawing.Size(125, 55);
            this.asteriskButton.TabIndex = 0;
            this.asteriskButton.Text = "*****";
            this.asteriskButton.UseVisualStyleBackColor = true;
            this.asteriskButton.Click += new System.EventHandler(this.asteriskButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(102, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(208, 36);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(125, 55);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+++++";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // zeroesButton
            // 
            this.zeroesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroesButton.Location = new System.Drawing.Point(385, 36);
            this.zeroesButton.Name = "zeroesButton";
            this.zeroesButton.Size = new System.Drawing.Size(125, 55);
            this.zeroesButton.TabIndex = 3;
            this.zeroesButton.Text = "00000";
            this.zeroesButton.UseVisualStyleBackColor = true;
            this.zeroesButton.Click += new System.EventHandler(this.zeroesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 291);
            this.Controls.Add(this.zeroesButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.asteriskButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button asteriskButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button zeroesButton;
    }
}

