using System;
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
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            panelMenu.Dispose();
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
            buttonBestiary.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBestiary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonBestiary.Refresh();
        }

        private void buttonBestiary_MouseLeave(object sender, EventArgs e)
        {
            buttonBestiary.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonBestiary.Refresh();
        }

        private void buttonResume_MouseEnter(object sender, EventArgs e)
        {
            buttonResume.Font = new System.Drawing.Font("Playbill", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            buttonResume.Refresh();
        }

        private void buttonResume_MouseLeave(object sender, EventArgs e)
        {
            buttonResume.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonResume.Refresh();
        }
    }
}
