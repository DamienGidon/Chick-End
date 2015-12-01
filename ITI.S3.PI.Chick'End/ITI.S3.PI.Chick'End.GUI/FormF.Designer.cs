namespace ITI.S3.PI.Chick_End.GUI
{
    partial class FormF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormF));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonLevelFour = new System.Windows.Forms.Button();
            this.buttonLevelThree = new System.Windows.Forms.Button();
            this.buttonLevelTwo = new System.Windows.Forms.Button();
            this.buttonLevelOne = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonLeaderboard = new System.Windows.Forms.Button();
            this.buttonBestiary = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel.Controls.Add(this.pictureBox2);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.panelLevel);
            this.MenuPanel.Controls.Add(this.buttonQuit);
            this.MenuPanel.Controls.Add(this.buttonRules);
            this.MenuPanel.Controls.Add(this.buttonLeaderboard);
            this.MenuPanel.Controls.Add(this.buttonBestiary);
            this.MenuPanel.Controls.Add(this.buttonContinue);
            this.MenuPanel.Controls.Add(this.buttonPlay);
            this.MenuPanel.Location = new System.Drawing.Point(-2, -2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1010, 731);
            this.MenuPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(852, 440);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 56);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 56);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelLevel
            // 
            this.panelLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLevel.BackColor = System.Drawing.Color.Cornsilk;
            this.panelLevel.Controls.Add(this.buttonReturn);
            this.panelLevel.Controls.Add(this.buttonLevelFour);
            this.panelLevel.Controls.Add(this.buttonLevelThree);
            this.panelLevel.Controls.Add(this.buttonLevelTwo);
            this.panelLevel.Controls.Add(this.buttonLevelOne);
            this.panelLevel.Location = new System.Drawing.Point(378, 189);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(242, 440);
            this.panelLevel.TabIndex = 6;
            this.panelLevel.Visible = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Playbill", 30F);
            this.buttonReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonReturn.Location = new System.Drawing.Point(50, 339);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(140, 70);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            this.buttonReturn.MouseEnter += new System.EventHandler(this.buttonReturn_MouseEnter);
            this.buttonReturn.MouseLeave += new System.EventHandler(this.buttonReturn_MouseLeave);
            // 
            // buttonLevelFour
            // 
            this.buttonLevelFour.Enabled = false;
            this.buttonLevelFour.FlatAppearance.BorderSize = 0;
            this.buttonLevelFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLevelFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevelFour.Font = new System.Drawing.Font("Playbill", 30F);
            this.buttonLevelFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLevelFour.Location = new System.Drawing.Point(50, 263);
            this.buttonLevelFour.Name = "buttonLevelFour";
            this.buttonLevelFour.Size = new System.Drawing.Size(140, 70);
            this.buttonLevelFour.TabIndex = 3;
            this.buttonLevelFour.Text = "Level 4";
            this.buttonLevelFour.UseVisualStyleBackColor = true;
            // 
            // buttonLevelThree
            // 
            this.buttonLevelThree.Enabled = false;
            this.buttonLevelThree.FlatAppearance.BorderSize = 0;
            this.buttonLevelThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLevelThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevelThree.Font = new System.Drawing.Font("Playbill", 30F);
            this.buttonLevelThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLevelThree.Location = new System.Drawing.Point(50, 187);
            this.buttonLevelThree.Name = "buttonLevelThree";
            this.buttonLevelThree.Size = new System.Drawing.Size(140, 70);
            this.buttonLevelThree.TabIndex = 2;
            this.buttonLevelThree.Text = "Level 3";
            this.buttonLevelThree.UseVisualStyleBackColor = true;
            // 
            // buttonLevelTwo
            // 
            this.buttonLevelTwo.Enabled = false;
            this.buttonLevelTwo.FlatAppearance.BorderSize = 0;
            this.buttonLevelTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLevelTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevelTwo.Font = new System.Drawing.Font("Playbill", 30F);
            this.buttonLevelTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLevelTwo.Location = new System.Drawing.Point(50, 109);
            this.buttonLevelTwo.Name = "buttonLevelTwo";
            this.buttonLevelTwo.Size = new System.Drawing.Size(140, 70);
            this.buttonLevelTwo.TabIndex = 1;
            this.buttonLevelTwo.Text = "Level 2";
            this.buttonLevelTwo.UseVisualStyleBackColor = true;
            this.buttonLevelTwo.Click += new System.EventHandler(this.buttonLevelTwo_Click);
            // 
            // buttonLevelOne
            // 
            this.buttonLevelOne.FlatAppearance.BorderSize = 0;
            this.buttonLevelOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLevelOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevelOne.Font = new System.Drawing.Font("Playbill", 30F);
            this.buttonLevelOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLevelOne.Location = new System.Drawing.Point(50, 37);
            this.buttonLevelOne.Name = "buttonLevelOne";
            this.buttonLevelOne.Size = new System.Drawing.Size(140, 66);
            this.buttonLevelOne.TabIndex = 0;
            this.buttonLevelOne.Text = "Level 1";
            this.buttonLevelOne.UseVisualStyleBackColor = false;
            this.buttonLevelOne.Click += new System.EventHandler(this.buttonLevelOne_Click);
            this.buttonLevelOne.MouseEnter += new System.EventHandler(this.buttonLevelOne_MouseEnter);
            this.buttonLevelOne.MouseLeave += new System.EventHandler(this.buttonLevelOne_MouseLeave);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonQuit.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonQuit.Location = new System.Drawing.Point(402, 600);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(199, 88);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            this.buttonQuit.MouseEnter += new System.EventHandler(this.buttonQuit_MouseEnter);
            this.buttonQuit.MouseLeave += new System.EventHandler(this.buttonQuit_MouseLeave);
            // 
            // buttonRules
            // 
            this.buttonRules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRules.BackColor = System.Drawing.Color.Transparent;
            this.buttonRules.FlatAppearance.BorderSize = 0;
            this.buttonRules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRules.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRules.Location = new System.Drawing.Point(402, 504);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(200, 92);
            this.buttonRules.TabIndex = 4;
            this.buttonRules.Text = "Rules";
            this.buttonRules.UseVisualStyleBackColor = false;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            this.buttonRules.MouseEnter += new System.EventHandler(this.buttonRules_MouseEnter);
            this.buttonRules.MouseLeave += new System.EventHandler(this.buttonRules_MouseLeave);
            // 
            // buttonLeaderboard
            // 
            this.buttonLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.buttonLeaderboard.FlatAppearance.BorderSize = 0;
            this.buttonLeaderboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeaderboard.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaderboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLeaderboard.Location = new System.Drawing.Point(352, 401);
            this.buttonLeaderboard.Name = "buttonLeaderboard";
            this.buttonLeaderboard.Size = new System.Drawing.Size(309, 107);
            this.buttonLeaderboard.TabIndex = 3;
            this.buttonLeaderboard.Text = "Leaderboard";
            this.buttonLeaderboard.UseVisualStyleBackColor = false;
            this.buttonLeaderboard.Click += new System.EventHandler(this.buttonLeaderboard_Click);
            this.buttonLeaderboard.MouseEnter += new System.EventHandler(this.buttonLeaderboard_MouseEnter);
            this.buttonLeaderboard.MouseLeave += new System.EventHandler(this.buttonLeaderboard_MouseLeave);
            // 
            // buttonBestiary
            // 
            this.buttonBestiary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBestiary.BackColor = System.Drawing.Color.Transparent;
            this.buttonBestiary.FlatAppearance.BorderSize = 0;
            this.buttonBestiary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBestiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBestiary.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBestiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonBestiary.Location = new System.Drawing.Point(402, 319);
            this.buttonBestiary.Name = "buttonBestiary";
            this.buttonBestiary.Size = new System.Drawing.Size(208, 95);
            this.buttonBestiary.TabIndex = 2;
            this.buttonBestiary.Text = "Bestiary";
            this.buttonBestiary.UseVisualStyleBackColor = false;
            this.buttonBestiary.Click += new System.EventHandler(this.buttonBestiary_Click);
            this.buttonBestiary.MouseEnter += new System.EventHandler(this.buttonBestiary_MouseEnter);
            this.buttonBestiary.MouseLeave += new System.EventHandler(this.buttonBestiary_MouseLeave);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonContinue.BackColor = System.Drawing.Color.Transparent;
            this.buttonContinue.FlatAppearance.BorderSize = 0;
            this.buttonContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonContinue.Location = new System.Drawing.Point(402, 226);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(206, 105);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.MouseEnter += new System.EventHandler(this.buttonContinue_MouseEnter);
            this.buttonContinue.MouseLeave += new System.EventHandler(this.buttonContinue_MouseLeave);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPlay.Location = new System.Drawing.Point(402, 130);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(200, 104);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseEnter += new System.EventHandler(this.buttonPlay_MouseEnter);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.buttonPlay_MouseLeave);
            // 
            // FormF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(0, 650);
            this.Name = "FormF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormF";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLevel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button buttonLeaderboard;
        private System.Windows.Forms.Button buttonBestiary;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Panel panelLevel;
        private System.Windows.Forms.Button buttonLevelFour;
        private System.Windows.Forms.Button buttonLevelThree;
        private System.Windows.Forms.Button buttonLevelTwo;
        private System.Windows.Forms.Button buttonLevelOne;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}