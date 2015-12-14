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
    public partial class MainMenu : UserControl
    {
        IGameContext _context;

        public MainMenu()
        {
            InitializeComponent();
        }

        IGameContext GameContext { get { return (IGameContext)FindForm(); } }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if( _context.CurrentGame == null 
                || MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.CurrentGame = new Game();
                Hide();
            }
        }
    }
}
