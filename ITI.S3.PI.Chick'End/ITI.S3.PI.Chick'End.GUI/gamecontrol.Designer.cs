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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamecontrol));
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBestiary = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.panelSeed = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSeedNumber = new System.Windows.Forms.Label();
            this.labelSeed = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPriceT = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUnit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.viewMapControler1 = new ITI.S3.PI.Chick_End.GUI.ViewMapControler();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonMenu.Location = new System.Drawing.Point(1225, 4);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(113, 55);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            this.buttonMenu.MouseEnter += new System.EventHandler(this.buttonMenu_MouseEnter);
            this.buttonMenu.MouseLeave += new System.EventHandler(this.buttonMenu_MouseLeave);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelMenu.BackColor = System.Drawing.Color.Orange;
            this.panelMenu.Controls.Add(this.buttonQuit);
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Controls.Add(this.buttonBestiary);
            this.panelMenu.Controls.Add(this.buttonResume);
            this.panelMenu.Location = new System.Drawing.Point(533, 308);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 322);
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
            this.buttonQuit.Location = new System.Drawing.Point(59, 235);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(156, 70);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            this.buttonQuit.MouseEnter += new System.EventHandler(this.buttonQuit_MouseEnter);
            this.buttonQuit.MouseLeave += new System.EventHandler(this.buttonQuit_MouseLeave);
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
            this.buttonSave.Location = new System.Drawing.Point(59, 153);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(156, 75);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.buttonSave_MouseLeave);
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
            this.buttonBestiary.Location = new System.Drawing.Point(59, 82);
            this.buttonBestiary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBestiary.Name = "buttonBestiary";
            this.buttonBestiary.Size = new System.Drawing.Size(156, 63);
            this.buttonBestiary.TabIndex = 1;
            this.buttonBestiary.Text = "Bestiary";
            this.buttonBestiary.UseVisualStyleBackColor = true;
            this.buttonBestiary.Click += new System.EventHandler(this.buttonBestiary_Click);
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
            this.buttonResume.Location = new System.Drawing.Point(59, 4);
            this.buttonResume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(156, 71);
            this.buttonResume.TabIndex = 0;
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            this.buttonResume.MouseEnter += new System.EventHandler(this.buttonResume_MouseEnter);
            this.buttonResume.MouseLeave += new System.EventHandler(this.buttonResume_MouseLeave);
            // 
            // panelSeed
            // 
            this.panelSeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSeed.BackColor = System.Drawing.Color.Orange;
            this.panelSeed.Controls.Add(this.pictureBox10);
            this.panelSeed.Controls.Add(this.pictureBox11);
            this.panelSeed.Controls.Add(this.labelTimer);
            this.panelSeed.Controls.Add(this.label1);
            this.panelSeed.Controls.Add(this.labelSeedNumber);
            this.panelSeed.Controls.Add(this.labelSeed);
            this.panelSeed.Controls.Add(this.buttonMenu);
            this.panelSeed.Location = new System.Drawing.Point(0, 0);
            this.panelSeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSeed.Name = "panelSeed";
            this.panelSeed.Size = new System.Drawing.Size(1343, 71);
            this.panelSeed.TabIndex = 4;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Orange;
            this.pictureBox11.Location = new System.Drawing.Point(1100, 0);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(73, 64);
            this.pictureBox11.TabIndex = 7;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Playbill", 20F);
            this.labelTimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTimer.Location = new System.Drawing.Point(564, 15);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(89, 34);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "{mm\'ss}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 20F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(488, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timer :";
            // 
            // labelSeedNumber
            // 
            this.labelSeedNumber.AutoSize = true;
            this.labelSeedNumber.Font = new System.Drawing.Font("Playbill", 22F);
            this.labelSeedNumber.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSeedNumber.Location = new System.Drawing.Point(89, 12);
            this.labelSeedNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeedNumber.Name = "labelSeedNumber";
            this.labelSeedNumber.Size = new System.Drawing.Size(108, 38);
            this.labelSeedNumber.TabIndex = 4;
            this.labelSeedNumber.Text = "{Number}";
            // 
            // labelSeed
            // 
            this.labelSeed.AutoSize = true;
            this.labelSeed.Font = new System.Drawing.Font("Playbill", 22F);
            this.labelSeed.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSeed.Location = new System.Drawing.Point(21, 15);
            this.labelSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(72, 38);
            this.labelSeed.TabIndex = 3;
            this.labelSeed.Text = "Seed :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(29, 613);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(88, 82);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseEnter += new System.EventHandler(this.pictureBox6_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(133, 496);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 81);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 896);
            this.panel1.TabIndex = 4;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Controls.Add(this.labelPrice);
            this.panel5.Controls.Add(this.labelPriceT);
            this.panel5.Location = new System.Drawing.Point(0, 703);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 49);
            this.panel5.TabIndex = 5;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Playbill", 20F);
            this.labelPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPrice.Location = new System.Drawing.Point(127, 7);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(76, 34);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "{price}";
            // 
            // labelPriceT
            // 
            this.labelPriceT.AutoSize = true;
            this.labelPriceT.Font = new System.Drawing.Font("Playbill", 20F);
            this.labelPriceT.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPriceT.Location = new System.Drawing.Point(53, 7);
            this.labelPriceT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriceT.Name = "labelPriceT";
            this.labelPriceT.Size = new System.Drawing.Size(69, 34);
            this.labelPriceT.TabIndex = 0;
            this.labelPriceT.Text = "Price :";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(75, 327);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(88, 82);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.MouseEnter += new System.EventHandler(this.pictureBox9_MouseEnter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(4, 417);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 49);
            this.panel4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Playbill", 20F);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(60, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Farmer Units";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 49);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playbill", 20F);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(68, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hen Units";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(133, 598);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(88, 81);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(133, 231);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(88, 81);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseEnter += new System.EventHandler(this.pictureBox7_MouseEnter);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(133, 129);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(88, 82);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseEnter += new System.EventHandler(this.pictureBox5_MouseEnter);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(29, 495);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 82);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(24, 231);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 82);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 129);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 81);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.labelUnit);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 71);
            this.panel2.TabIndex = 1;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Playbill", 30F);
            this.labelUnit.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelUnit.Location = new System.Drawing.Point(81, 12);
            this.labelUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(78, 50);
            this.labelUnit.TabIndex = 5;
            this.labelUnit.Text = "Units";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // viewMapControler1
            // 
            this.viewMapControler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewMapControler1.BackColor = System.Drawing.Color.Green;
            this.viewMapControler1.Context = ((ITI.S3.PI.Chick_End.Game)(resources.GetObject("viewMapControler1.Context")));
            this.viewMapControler1.Location = new System.Drawing.Point(333, 151);
            this.viewMapControler1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewMapControler1.Name = "viewMapControler1";
            this.viewMapControler1.Size = new System.Drawing.Size(933, 554);
            this.viewMapControler1.TabIndex = 4;
            this.viewMapControler1.Text = "viewMapControler1";
            this.viewMapControler1.Resize += new System.EventHandler(this.viewMapControler1_Resize);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Orange;
            this.pictureBox10.Location = new System.Drawing.Point(1181, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(73, 64);
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // gamecontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.viewMapControler1);
            this.Controls.Add(this.panelSeed);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "gamecontrol";
            this.Size = new System.Drawing.Size(1343, 896);
            this.Load += new System.EventHandler(this.ManageUsersControl_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSeed.ResumeLayout(false);
            this.panelSeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
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
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPriceT;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}
