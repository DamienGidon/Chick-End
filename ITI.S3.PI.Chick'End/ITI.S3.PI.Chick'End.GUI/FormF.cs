using System;
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
    public partial class FormF : Form
    {
        public FormF()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            panelLevel.Show(); 
        }

        private void buttonLevelOne_Click(object sender, EventArgs e)
        {
            MenuPanel.Hide();
            panelLevel.Hide();
            this.Controls.Add(new gamecontrol(MenuPanel));
            //buttonPlay.BackColor = System.Drawing.Color.Transparent;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReturn_MouseEnter(object sender, EventArgs e)
        {
            buttonReturn.Font = new System.Drawing.Font("Playbill", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonReturn.Refresh();
        }

        private void buttonReturn_MouseLeave(object sender, EventArgs e)
        {
            buttonReturn.Font = new System.Drawing.Font("Playbill", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonReturn.Refresh();
        }

        private void buttonLevelOne_MouseEnter(object sender, EventArgs e)
        {
            buttonLevelOne.Font = new System.Drawing.Font("Playbill", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonLevelOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonLevelOne.Refresh();
        }

        private void buttonLevelOne_MouseLeave(object sender, EventArgs e)
        {
            buttonLevelOne.Font = new System.Drawing.Font("Playbill", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonLevelOne.Refresh();
        }

        private void buttonPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.Font = new System.Drawing.Font("Playbill", 58F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonPlay.Refresh();
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonPlay.Refresh();
        }

        private void buttonBestiary_MouseEnter(object sender, EventArgs e)
        {
            buttonBestiary.Font = new System.Drawing.Font("Playbill", 58F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBestiary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonBestiary.Refresh();
        }

        private void buttonBestiary_MouseLeave(object sender, EventArgs e)
        {
            buttonBestiary.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBestiary.Refresh();
        }

        private void buttonContinue_MouseEnter(object sender, EventArgs e)
        {
            buttonContinue.Font = new System.Drawing.Font("Playbill", 58F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonContinue.Refresh();
        }

        private void buttonContinue_MouseLeave(object sender, EventArgs e)
        {
            buttonContinue.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonContinue.Refresh();
        }

        private void buttonRules_MouseEnter(object sender, EventArgs e)
        {
            buttonRules.Font = new System.Drawing.Font("Playbill", 58F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonRules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonRules.Refresh();
        }

        private void buttonRules_MouseLeave(object sender, EventArgs e)
        {
            buttonRules.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonRules.Refresh();
        }

        private void buttonLeaderboard_MouseEnter(object sender, EventArgs e)
        {
            buttonLeaderboard.Font = new System.Drawing.Font("Playbill", 58F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonLeaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonLeaderboard.Refresh();
        }

        private void buttonLeaderboard_MouseLeave(object sender, EventArgs e)
        {
            buttonLeaderboard.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonLeaderboard.Refresh();
        }

        private void buttonQuit_MouseEnter(object sender, EventArgs e)
        {
            buttonQuit.Font = new System.Drawing.Font("Playbill", 58F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonQuit.Refresh();
        }

        private void buttonQuit_MouseLeave(object sender, EventArgs e)
        {
            buttonQuit.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonQuit.Refresh();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            panelLevel.Hide();
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard l = new Leaderboard();
            l.ShowDialog();
        }

        private void buttonLevelTwo_Click(object sender, EventArgs e)
        {

        }
    }
}
