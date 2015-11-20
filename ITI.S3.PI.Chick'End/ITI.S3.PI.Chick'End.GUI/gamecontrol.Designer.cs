namespace ITI.S3.PI.Chick_End.GUI
{
    partial class gamecontrol
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamecontrol));
            ITI.S3.PI.Chick_End.Game game1 = new ITI.S3.PI.Chick_End.Game();
            ITI.S3.PI.Chick_End.Game game2 = new ITI.S3.PI.Chick_End.Game();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonTrash = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBestiary = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.panelSeed = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSeedNumber = new System.Windows.Forms.Label();
            this.labelSeed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUnit = new System.Windows.Forms.Label();
            this.viewMapControler1 = new ITI.S3.PI.Chick_End.GUI.ViewMapControler();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSeed.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonMenu.Location = new System.Drawing.Point(843, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(85, 45);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            this.buttonMenu.MouseEnter += new System.EventHandler(this.buttonMenu_MouseEnter);
            this.buttonMenu.MouseLeave += new System.EventHandler(this.buttonMenu_MouseLeave);
            // 
            // buttonTrash
            // 
            this.buttonTrash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTrash.BackColor = System.Drawing.Color.Transparent;
            this.buttonTrash.FlatAppearance.BorderSize = 0;
            this.buttonTrash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrash.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrash.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonTrash.Location = new System.Drawing.Point(749, 3);
            this.buttonTrash.Name = "buttonTrash";
            this.buttonTrash.Size = new System.Drawing.Size(88, 45);
            this.buttonTrash.TabIndex = 2;
            this.buttonTrash.Text = "Trash";
            this.buttonTrash.UseVisualStyleBackColor = true;
            this.buttonTrash.MouseEnter += new System.EventHandler(this.buttonTrash_MouseEnter);
            this.buttonTrash.MouseLeave += new System.EventHandler(this.buttonTrash_MouseLeave);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Orange;
            this.panelMenu.Controls.Add(this.buttonQuit);
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Controls.Add(this.buttonBestiary);
            this.panelMenu.Controls.Add(this.buttonResume);
            this.panelMenu.Location = new System.Drawing.Point(400, 250);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 262);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Visible = false;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonQuit.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Playbill", 20F);
            this.buttonQuit.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonQuit.Location = new System.Drawing.Point(44, 191);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(117, 57);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Playbill", 20F);
            this.buttonSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSave.Location = new System.Drawing.Point(44, 124);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 61);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonBestiary
            // 
            this.buttonBestiary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBestiary.BackColor = System.Drawing.Color.Transparent;
            this.buttonBestiary.FlatAppearance.BorderSize = 0;
            this.buttonBestiary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBestiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBestiary.Font = new System.Drawing.Font("Playbill", 20F);
            this.buttonBestiary.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonBestiary.Location = new System.Drawing.Point(44, 67);
            this.buttonBestiary.Name = "buttonBestiary";
            this.buttonBestiary.Size = new System.Drawing.Size(117, 51);
            this.buttonBestiary.TabIndex = 1;
            this.buttonBestiary.Text = "Bestiary";
            this.buttonBestiary.UseVisualStyleBackColor = true;
            this.buttonBestiary.MouseEnter += new System.EventHandler(this.buttonBestiary_MouseEnter);
            this.buttonBestiary.MouseLeave += new System.EventHandler(this.buttonBestiary_MouseLeave);
            // 
            // buttonResume
            // 
            this.buttonResume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonResume.BackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatAppearance.BorderSize = 0;
            this.buttonResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResume.Font = new System.Drawing.Font("Playbill", 20F);
            this.buttonResume.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonResume.Location = new System.Drawing.Point(44, 3);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(117, 58);
            this.buttonResume.TabIndex = 0;
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            this.buttonResume.MouseEnter += new System.EventHandler(this.buttonResume_MouseEnter);
            this.buttonResume.MouseLeave += new System.EventHandler(this.buttonResume_MouseLeave);
            // 
            // panelSeed
            // 
            this.panelSeed.BackColor = System.Drawing.Color.Orange;
            this.panelSeed.Controls.Add(this.label2);
            this.panelSeed.Controls.Add(this.label1);
            this.panelSeed.Controls.Add(this.labelSeedNumber);
            this.panelSeed.Controls.Add(this.labelSeed);
            this.panelSeed.Controls.Add(this.buttonTrash);
            this.panelSeed.Controls.Add(this.buttonMenu);
            this.panelSeed.Location = new System.Drawing.Point(0, 0);
            this.panelSeed.Name = "panelSeed";
            this.panelSeed.Size = new System.Drawing.Size(1007, 58);
            this.panelSeed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Playbill", 20F);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(423, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "{mm\'ss}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 20F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(366, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timer :";
            // 
            // labelSeedNumber
            // 
            this.labelSeedNumber.AutoSize = true;
            this.labelSeedNumber.Font = new System.Drawing.Font("Playbill", 22F);
            this.labelSeedNumber.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSeedNumber.Location = new System.Drawing.Point(67, 10);
            this.labelSeedNumber.Name = "labelSeedNumber";
            this.labelSeedNumber.Size = new System.Drawing.Size(89, 31);
            this.labelSeedNumber.TabIndex = 4;
            this.labelSeedNumber.Text = "{Number}";
            // 
            // labelSeed
            // 
            this.labelSeed.AutoSize = true;
            this.labelSeed.Font = new System.Drawing.Font("Playbill", 22F);
            this.labelSeed.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSeed.Location = new System.Drawing.Point(16, 12);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(59, 31);
            this.labelSeed.TabIndex = 3;
            this.labelSeed.Text = "Seed :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 728);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(40, 318);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 61);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 66);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.labelUnit);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 58);
            this.panel2.TabIndex = 1;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Playbill", 30F);
            this.labelUnit.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelUnit.Location = new System.Drawing.Point(43, 10);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(63, 40);
            this.labelUnit.TabIndex = 5;
            this.labelUnit.Text = "Units";
            // 
            // viewMapControler1
            // 
            this.viewMapControler1.BackColor = System.Drawing.Color.Cyan;
            this.viewMapControler1.Context = game2;
            this.viewMapControler1.Location = new System.Drawing.Point(226, 132);
            this.viewMapControler1.Name = "viewMapControler1";
            this.viewMapControler1.Size = new System.Drawing.Size(700, 450);
            this.viewMapControler1.TabIndex = 4;
            this.viewMapControler1.Text = "viewMapControler1";
            // 
            // pictureBox3
            this.pictureBox3.Location = new System.Drawing.Point(40, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 67);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // gamecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSeed);
            this.Controls.Add(this.viewMapControler1);
            this.Name = "gamecontrol";
            this.Size = new System.Drawing.Size(1007, 728);
            this.panelMenu.ResumeLayout(false);
            this.panelSeed.ResumeLayout(false);
            this.panelSeed.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonTrash;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBestiary;
        private System.Windows.Forms.Button buttonResume;
        private ViewMapControler viewMapControler1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSeed;
        private System.Windows.Forms.Label labelSeedNumber;
        private System.Windows.Forms.Label labelSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
