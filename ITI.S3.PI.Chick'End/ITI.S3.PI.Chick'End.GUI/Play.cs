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
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }

        private void escapeWindow(object sender, EventArgs e)
        {
            using (Form ew = new EscapeWindow(this))
            {
                ew.ShowDialog();
            }
        }

        private void button3_Click( object sender, EventArgs e )
        {

        }
    }
}