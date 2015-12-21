﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    [Serializable]
    public partial class GameOver : Form
    {
        string _timer;
        string _level;

        public GameOver(string timer, string level)
        {
            InitializeComponent();
            _timer = timer;
            _level = level;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (textBoxPseudo.Text != null && textBoxPseudo.Text != "")
            {
                Xml Xml = new Xml();
                Xml.Pseudo = textBoxPseudo.Text;
                string []_timer2 = _timer.Split(':');
                _timer = _timer2[0] + _timer2[1];
                Xml.Score = _timer;
                Xml.Level = _level;
                Xml.Save("leaderboard.xml");
                Close();
            }
            else
            {
                textBoxPseudo.BackColor = System.Drawing.Color.OrangeRed;
            }
        }

        private void buttonMenu_MouseEnter(object sender, EventArgs e)
        {
            buttonReturn.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonReturn.Refresh();
        }

        private void buttonMenu_MouseLeave(object sender, EventArgs e)
        {
            buttonReturn.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonReturn.Refresh();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            label3.Text = _timer;
        }
    }
}
