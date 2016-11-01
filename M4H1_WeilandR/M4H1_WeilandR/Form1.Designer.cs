namespace M4H1_WeilandR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerDMGLabel = new System.Windows.Forms.Label();
            this.playerABLabel = new System.Windows.Forms.Label();
            this.playerACLabel = new System.Windows.Forms.Label();
            this.playerHPLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monsterHPLabel = new System.Windows.Forms.Label();
            this.monsterACLabel = new System.Windows.Forms.Label();
            this.monsterABLabel = new System.Windows.Forms.Label();
            this.monsterDMGLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.displayStatsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerHPLabel);
            this.groupBox1.Controls.Add(this.playerACLabel);
            this.groupBox1.Controls.Add(this.playerABLabel);
            this.groupBox1.Controls.Add(this.playerDMGLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DMG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "AB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "AC:";
            // 
            // playerDMGLabel
            // 
            this.playerDMGLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerDMGLabel.Location = new System.Drawing.Point(47, 67);
            this.playerDMGLabel.Name = "playerDMGLabel";
            this.playerDMGLabel.Size = new System.Drawing.Size(100, 18);
            this.playerDMGLabel.TabIndex = 1;
            this.playerDMGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerABLabel
            // 
            this.playerABLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerABLabel.Location = new System.Drawing.Point(47, 49);
            this.playerABLabel.Name = "playerABLabel";
            this.playerABLabel.Size = new System.Drawing.Size(100, 18);
            this.playerABLabel.TabIndex = 1;
            this.playerABLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerACLabel
            // 
            this.playerACLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerACLabel.Location = new System.Drawing.Point(47, 31);
            this.playerACLabel.Name = "playerACLabel";
            this.playerACLabel.Size = new System.Drawing.Size(100, 18);
            this.playerACLabel.TabIndex = 1;
            this.playerACLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerHPLabel
            // 
            this.playerHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHPLabel.Location = new System.Drawing.Point(47, 13);
            this.playerHPLabel.Name = "playerHPLabel";
            this.playerHPLabel.Size = new System.Drawing.Size(100, 18);
            this.playerHPLabel.TabIndex = 1;
            this.playerHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monsterHPLabel);
            this.groupBox2.Controls.Add(this.monsterACLabel);
            this.groupBox2.Controls.Add(this.monsterABLabel);
            this.groupBox2.Controls.Add(this.monsterDMGLabel);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(178, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monster";
            // 
            // monsterHPLabel
            // 
            this.monsterHPLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monsterHPLabel.Location = new System.Drawing.Point(47, 13);
            this.monsterHPLabel.Name = "monsterHPLabel";
            this.monsterHPLabel.Size = new System.Drawing.Size(100, 18);
            this.monsterHPLabel.TabIndex = 1;
            this.monsterHPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monsterACLabel
            // 
            this.monsterACLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monsterACLabel.Location = new System.Drawing.Point(47, 31);
            this.monsterACLabel.Name = "monsterACLabel";
            this.monsterACLabel.Size = new System.Drawing.Size(100, 18);
            this.monsterACLabel.TabIndex = 1;
            this.monsterACLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monsterABLabel
            // 
            this.monsterABLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monsterABLabel.Location = new System.Drawing.Point(47, 49);
            this.monsterABLabel.Name = "monsterABLabel";
            this.monsterABLabel.Size = new System.Drawing.Size(100, 18);
            this.monsterABLabel.TabIndex = 1;
            this.monsterABLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // monsterDMGLabel
            // 
            this.monsterDMGLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monsterDMGLabel.Location = new System.Drawing.Point(47, 67);
            this.monsterDMGLabel.Name = "monsterDMGLabel";
            this.monsterDMGLabel.Size = new System.Drawing.Size(100, 18);
            this.monsterDMGLabel.TabIndex = 1;
            this.monsterDMGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "DMG:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "AB:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "AC:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "HP:";
            // 
            // displayStatsButton
            // 
            this.displayStatsButton.Location = new System.Drawing.Point(97, 141);
            this.displayStatsButton.Name = "displayStatsButton";
            this.displayStatsButton.Size = new System.Drawing.Size(75, 23);
            this.displayStatsButton.TabIndex = 2;
            this.displayStatsButton.Text = "Display";
            this.displayStatsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(178, 141);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 176);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayStatsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerHPLabel;
        private System.Windows.Forms.Label playerACLabel;
        private System.Windows.Forms.Label playerABLabel;
        private System.Windows.Forms.Label playerDMGLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label monsterHPLabel;
        private System.Windows.Forms.Label monsterACLabel;
        private System.Windows.Forms.Label monsterABLabel;
        private System.Windows.Forms.Label monsterDMGLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button displayStatsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

