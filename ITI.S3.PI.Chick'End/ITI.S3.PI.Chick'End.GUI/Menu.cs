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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quit(object sender, EventArgs e)
        {
            Close();
        }

        private void play(object sender, EventArgs e)
        {
            using (Form p = new Play())
            {
                p.ShowDialog();
                this.Close();
            }
        }
    }
}
