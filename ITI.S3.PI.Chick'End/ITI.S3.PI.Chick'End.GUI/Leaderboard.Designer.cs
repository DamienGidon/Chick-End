namespace ITI.S3.PI.Chick_End.GUI
{
    partial class Leaderboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
            this.tabLevel = new System.Windows.Forms.TabControl();
            this.tabLevelOne = new System.Windows.Forms.TabPage();
            this.labelVide1 = new System.Windows.Forms.Label();
            this.labelScoreOne = new System.Windows.Forms.Label();
            this.labelPseudoOne = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelPseudo = new System.Windows.Forms.Label();
            this.tabLevelTwo = new System.Windows.Forms.TabPage();
            this.labelVide2 = new System.Windows.Forms.Label();
            this.labelScoreTwo = new System.Windows.Forms.Label();
            this.labelPseudoTwo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabLevelThree = new System.Windows.Forms.TabPage();
            this.labelVide3 = new System.Windows.Forms.Label();
            this.labelScoreThree = new System.Windows.Forms.Label();
            this.labelPseudoThree = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabLevelFour = new System.Windows.Forms.TabPage();
            this.labelVide4 = new System.Windows.Forms.Label();
            this.labelScoreFour = new System.Windows.Forms.Label();
            this.labelPseudoFour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.tabLevel.SuspendLayout();
            this.tabLevelOne.SuspendLayout();
            this.tabLevelTwo.SuspendLayout();
            this.tabLevelThree.SuspendLayout();
            this.tabLevelFour.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLevel
            // 
            this.tabLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLevel.Controls.Add(this.tabLevelOne);
            this.tabLevel.Controls.Add(this.tabLevelTwo);
            this.tabLevel.Controls.Add(this.tabLevelThree);
            this.tabLevel.Controls.Add(this.tabLevelFour);
            this.tabLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabLevel.ItemSize = new System.Drawing.Size(50, 20);
            this.tabLevel.Location = new System.Drawing.Point(2, 0);
            this.tabLevel.Multiline = true;
            this.tabLevel.Name = "tabLevel";
            this.tabLevel.SelectedIndex = 0;
            this.tabLevel.Size = new System.Drawing.Size(496, 526);
            this.tabLevel.TabIndex = 0;
            // 
            // tabLevelOne
            // 
            this.tabLevelOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(108)))));
            this.tabLevelOne.Controls.Add(this.labelVide1);
            this.tabLevelOne.Controls.Add(this.labelScoreOne);
            this.tabLevelOne.Controls.Add(this.labelPseudoOne);
            this.tabLevelOne.Controls.Add(this.labelScore);
            this.tabLevelOne.Controls.Add(this.labelPseudo);
            this.tabLevelOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabLevelOne.Location = new System.Drawing.Point(4, 24);
            this.tabLevelOne.Name = "tabLevelOne";
            this.tabLevelOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabLevelOne.Size = new System.Drawing.Size(488, 498);
            this.tabLevelOne.TabIndex = 0;
            this.tabLevelOne.Text = "Level 1";
            // 
            // labelVide1
            // 
            this.labelVide1.AutoSize = true;
            this.labelVide1.Font = new System.Drawing.Font("Playbill", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVide1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelVide1.Location = new System.Drawing.Point(129, 204);
            this.labelVide1.Name = "labelVide1";
            this.labelVide1.Size = new System.Drawing.Size(63, 35);
            this.labelVide1.TabIndex = 4;
            this.labelVide1.Text = "label7";
            // 
            // labelScoreOne
            // 
            this.labelScoreOne.AutoSize = true;
            this.labelScoreOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelScoreOne.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelScoreOne.Location = new System.Drawing.Point(280, 60);
            this.labelScoreOne.Name = "labelScoreOne";
            this.labelScoreOne.Size = new System.Drawing.Size(58, 20);
            this.labelScoreOne.TabIndex = 3;
            this.labelScoreOne.Text = "{score}";
            // 
            // labelPseudoOne
            // 
            this.labelPseudoOne.AutoSize = true;
            this.labelPseudoOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPseudoOne.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelPseudoOne.Location = new System.Drawing.Point(140, 60);
            this.labelPseudoOne.Name = "labelPseudoOne";
            this.labelPseudoOne.Size = new System.Drawing.Size(72, 20);
            this.labelPseudoOne.TabIndex = 2;
            this.labelPseudoOne.Text = "{pseudo}";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Playbill", 22F);
            this.labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelScore.Location = new System.Drawing.Point(279, 20);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(51, 31);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score";
            // 
            // labelPseudo
            // 
            this.labelPseudo.AutoSize = true;
            this.labelPseudo.Font = new System.Drawing.Font("Playbill", 22F);
            this.labelPseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPseudo.Location = new System.Drawing.Point(139, 20);
            this.labelPseudo.Name = "labelPseudo";
            this.labelPseudo.Size = new System.Drawing.Size(60, 31);
            this.labelPseudo.TabIndex = 0;
            this.labelPseudo.Text = "Pseudo";
            // 
            // tabLevelTwo
            // 
            this.tabLevelTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(108)))));
            this.tabLevelTwo.Controls.Add(this.labelVide2);
            this.tabLevelTwo.Controls.Add(this.labelScoreTwo);
            this.tabLevelTwo.Controls.Add(this.labelPseudoTwo);
            this.tabLevelTwo.Controls.Add(this.label1);
            this.tabLevelTwo.Controls.Add(this.label2);
            this.tabLevelTwo.Location = new System.Drawing.Point(4, 24);
            this.tabLevelTwo.Name = "tabLevelTwo";
            this.tabLevelTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLevelTwo.Size = new System.Drawing.Size(488, 498);
            this.tabLevelTwo.TabIndex = 1;
            this.tabLevelTwo.Text = "Level 2";
            // 
            // labelVide2
            // 
            this.labelVide2.AutoSize = true;
            this.labelVide2.Font = new System.Drawing.Font("Playbill", 26.25F);
            this.labelVide2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelVide2.Location = new System.Drawing.Point(129, 204);
            this.labelVide2.Name = "labelVide2";
            this.labelVide2.Size = new System.Drawing.Size(63, 35);
            this.labelVide2.TabIndex = 6;
            this.labelVide2.Text = "label7";
            // 
            // labelScoreTwo
            // 
            this.labelScoreTwo.AutoSize = true;
            this.labelScoreTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelScoreTwo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelScoreTwo.Location = new System.Drawing.Point(280, 60);
            this.labelScoreTwo.Name = "labelScoreTwo";
            this.labelScoreTwo.Size = new System.Drawing.Size(58, 20);
            this.labelScoreTwo.TabIndex = 5;
            this.labelScoreTwo.Text = "{score}";
            // 
            // labelPseudoTwo
            // 
            this.labelPseudoTwo.AutoSize = true;
            this.labelPseudoTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPseudoTwo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelPseudoTwo.Location = new System.Drawing.Point(140, 60);
            this.labelPseudoTwo.Name = "labelPseudoTwo";
            this.labelPseudoTwo.Size = new System.Drawing.Size(72, 20);
            this.labelPseudoTwo.TabIndex = 4;
            this.labelPseudoTwo.Text = "{pseudo}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 22F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(279, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Playbill", 22F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(139, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pseudo";
            // 
            // tabLevelThree
            // 
            this.tabLevelThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(108)))));
            this.tabLevelThree.Controls.Add(this.labelVide3);
            this.tabLevelThree.Controls.Add(this.labelScoreThree);
            this.tabLevelThree.Controls.Add(this.labelPseudoThree);
            this.tabLevelThree.Controls.Add(this.label3);
            this.tabLevelThree.Controls.Add(this.label4);
            this.tabLevelThree.Location = new System.Drawing.Point(4, 24);
            this.tabLevelThree.Name = "tabLevelThree";
            this.tabLevelThree.Padding = new System.Windows.Forms.Padding(3);
            this.tabLevelThree.Size = new System.Drawing.Size(488, 498);
            this.tabLevelThree.TabIndex = 2;
            this.tabLevelThree.Text = "Level 3";
            // 
            // labelVide3
            // 
            this.labelVide3.AutoSize = true;
            this.labelVide3.Font = new System.Drawing.Font("Playbill", 26.25F);
            this.labelVide3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelVide3.Location = new System.Drawing.Point(129, 204);
            this.labelVide3.Name = "labelVide3";
            this.labelVide3.Size = new System.Drawing.Size(63, 35);
            this.labelVide3.TabIndex = 6;
            this.labelVide3.Text = "label7";
            // 
            // labelScoreThree
            // 
            this.labelScoreThree.AutoSize = true;
            this.labelScoreThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelScoreThree.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelScoreThree.Location = new System.Drawing.Point(280, 60);
            this.labelScoreThree.Name = "labelScoreThree";
            this.labelScoreThree.Size = new System.Drawing.Size(58, 20);
            this.labelScoreThree.TabIndex = 5;
            this.labelScoreThree.Text = "{score}";
            // 
            // labelPseudoThree
            // 
            this.labelPseudoThree.AutoSize = true;
            this.labelPseudoThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPseudoThree.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelPseudoThree.Location = new System.Drawing.Point(140, 60);
            this.labelPseudoThree.Name = "labelPseudoThree";
            this.labelPseudoThree.Size = new System.Drawing.Size(72, 20);
            this.labelPseudoThree.TabIndex = 4;
            this.labelPseudoThree.Text = "{pseudo}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playbill", 22F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(279, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Playbill", 22F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(139, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pseudo";
            // 
            // tabLevelFour
            // 
            this.tabLevelFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(108)))));
            this.tabLevelFour.Controls.Add(this.labelVide4);
            this.tabLevelFour.Controls.Add(this.labelScoreFour);
            this.tabLevelFour.Controls.Add(this.labelPseudoFour);
            this.tabLevelFour.Controls.Add(this.label5);
            this.tabLevelFour.Controls.Add(this.label6);
            this.tabLevelFour.Location = new System.Drawing.Point(4, 24);
            this.tabLevelFour.Name = "tabLevelFour";
            this.tabLevelFour.Padding = new System.Windows.Forms.Padding(3);
            this.tabLevelFour.Size = new System.Drawing.Size(488, 498);
            this.tabLevelFour.TabIndex = 3;
            this.tabLevelFour.Text = "Level 4";
            // 
            // labelVide4
            // 
            this.labelVide4.AutoSize = true;
            this.labelVide4.Font = new System.Drawing.Font("Playbill", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVide4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelVide4.Location = new System.Drawing.Point(129, 204);
            this.labelVide4.Name = "labelVide4";
            this.labelVide4.Size = new System.Drawing.Size(63, 35);
            this.labelVide4.TabIndex = 6;
            this.labelVide4.Text = "label7";
            // 
            // labelScoreFour
            // 
            this.labelScoreFour.AutoSize = true;
            this.labelScoreFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelScoreFour.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelScoreFour.Location = new System.Drawing.Point(280, 60);
            this.labelScoreFour.Name = "labelScoreFour";
            this.labelScoreFour.Size = new System.Drawing.Size(58, 20);
            this.labelScoreFour.TabIndex = 5;
            this.labelScoreFour.Text = "{score}";
            // 
            // labelPseudoFour
            // 
            this.labelPseudoFour.AutoSize = true;
            this.labelPseudoFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPseudoFour.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelPseudoFour.Location = new System.Drawing.Point(140, 60);
            this.labelPseudoFour.Name = "labelPseudoFour";
            this.labelPseudoFour.Size = new System.Drawing.Size(72, 20);
            this.labelPseudoFour.TabIndex = 4;
            this.labelPseudoFour.Text = "{pseudo}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Playbill", 22F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(279, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Playbill", 22F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(139, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pseudo";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReturn.BackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Playbill", 20F);
            this.buttonReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonReturn.Location = new System.Drawing.Point(176, 528);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(149, 34);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            this.buttonReturn.MouseEnter += new System.EventHandler(this.buttonReturn_MouseEnter);
            this.buttonReturn.MouseLeave += new System.EventHandler(this.buttonReturn_MouseLeave);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 563);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.tabLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Leaderboard";
            this.tabLevel.ResumeLayout(false);
            this.tabLevelOne.ResumeLayout(false);
            this.tabLevelOne.PerformLayout();
            this.tabLevelTwo.ResumeLayout(false);
            this.tabLevelTwo.PerformLayout();
            this.tabLevelThree.ResumeLayout(false);
            this.tabLevelThree.PerformLayout();
            this.tabLevelFour.ResumeLayout(false);
            this.tabLevelFour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLevel;
        private System.Windows.Forms.TabPage tabLevelOne;
        private System.Windows.Forms.TabPage tabLevelTwo;
        private System.Windows.Forms.TabPage tabLevelThree;
        private System.Windows.Forms.TabPage tabLevelFour;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelPseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelScoreOne;
        private System.Windows.Forms.Label labelPseudoOne;
        private System.Windows.Forms.Label labelScoreTwo;
        private System.Windows.Forms.Label labelPseudoTwo;
        private System.Windows.Forms.Label labelScoreThree;
        private System.Windows.Forms.Label labelPseudoThree;
        private System.Windows.Forms.Label labelScoreFour;
        private System.Windows.Forms.Label labelPseudoFour;
        private System.Windows.Forms.Label labelVide1;
        private System.Windows.Forms.Label labelVide2;
        private System.Windows.Forms.Label labelVide3;
        private System.Windows.Forms.Label labelVide4;
    }
}