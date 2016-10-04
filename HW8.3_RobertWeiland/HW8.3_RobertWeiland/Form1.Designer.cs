namespace HW8._3_RobertWeiland
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.capitalizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.capitalizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(260, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // capitalizeButton
            // 
            this.capitalizeButton.Location = new System.Drawing.Point(12, 58);
            this.capitalizeButton.Name = "capitalizeButton";
            this.capitalizeButton.Size = new System.Drawing.Size(116, 29);
            this.capitalizeButton.TabIndex = 1;
            this.capitalizeButton.Text = "Capitalize Sentences";
            this.capitalizeButton.UseVisualStyleBackColor = true;
            this.capitalizeButton.Click += new System.EventHandler(this.capitalizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(156, 58);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 29);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // capitalizeLabel
            // 
            this.capitalizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capitalizeLabel.Location = new System.Drawing.Point(12, 35);
            this.capitalizeLabel.Name = "capitalizeLabel";
            this.capitalizeLabel.Size = new System.Drawing.Size(260, 20);
            this.capitalizeLabel.TabIndex = 2;
            this.capitalizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.capitalizeLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.capitalizeButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Sentence Capitalizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button capitalizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label capitalizeLabel;
    }
}

