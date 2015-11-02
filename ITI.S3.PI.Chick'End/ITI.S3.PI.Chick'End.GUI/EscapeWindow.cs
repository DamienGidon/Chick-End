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
    public partial class EscapeWindow : Form
    {
        Play _window;
        public EscapeWindow(Play window)
        {
            InitializeComponent();
            _window = window;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quit(object sender, EventArgs e)
        {
            using (Form m = new Menu())
            {
                m.ShowDialog();
                _window.Close();
                Close();
            }
        }

        private void continueGame(object sender, EventArgs e)
        {
            Close();
        }
    }
}
