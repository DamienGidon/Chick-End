﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class gamecontrol : UserControl
    {
        Panel _panel;
        public gamecontrol(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
            viewMapControler1.MouseClick += new MouseEventHandler(viewMapControler1_Click);
        }

        private void viewMapControler1_Click(object sender, MouseEventArgs e)
        {
            MessageBox.Show( string.Format("X = {0} ,Y= {1} " , e.X, e.Y));
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            //Form1 p = ((Form1)this.Parent);
            //p.Controls.Remove(this);
            //p.Controls.Add(_panel);
            _panel.Show();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
        }

        private void buttonBestiary_MouseEnter(object sender, EventArgs e)
        {
            buttonBestiary.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBestiary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonBestiary.Refresh();
        }

        private void buttonBestiary_MouseLeave(object sender, EventArgs e)
        {
            buttonBestiary.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBestiary.Refresh();
        }

        private void buttonResume_MouseEnter(object sender, EventArgs e)
        {
            buttonResume.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonResume.Refresh();
        }

        private void buttonResume_MouseLeave(object sender, EventArgs e)
        {
            buttonResume.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonResume.Refresh();
        }

        private void buttonMenu_MouseEnter(object sender, EventArgs e)
        {
            buttonMenu.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonMenu.Refresh();
        }

        private void buttonMenu_MouseLeave(object sender, EventArgs e)
        {
            buttonMenu.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonMenu.Refresh();
        }

        private void buttonTrash_MouseEnter(object sender, EventArgs e)
        {
            buttonTrash.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonTrash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonTrash.Refresh();
        }

        private void buttonTrash_MouseLeave(object sender, EventArgs e)
        {
            buttonTrash.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonTrash.Refresh();
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            buttonSave.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonSave.Refresh();
        }

        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonSave.Refresh();
        }

        private void buttonQuit_MouseEnter(object sender, EventArgs e)
        {
            buttonQuit.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonQuit.Refresh();
        }

        private void buttonQuit_MouseLeave(object sender, EventArgs e)
        {
            buttonQuit.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonQuit.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewMapControler1.Context.Map.CreateHen(viewMapControler1.Context.Map);
        }
    }
}
