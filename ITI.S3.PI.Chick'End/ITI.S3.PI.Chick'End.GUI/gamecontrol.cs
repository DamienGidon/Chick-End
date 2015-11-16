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
            viewMapControler1.Size = new System.Drawing.Size( 700, 450 );
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
    }
}
