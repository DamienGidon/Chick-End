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
    public partial class LevelMenu : UserControl
    {
        Controler _controler;

        public LevelMenu( Controler controler )
        {
            InitializeComponent();
            _controler = controler;
        }

        private void buttonLevel1_Click( object sender, EventArgs e )
        {
            if (_controler.FinalForm.CurrentGame == null || MessageBox.Show( "Do you really want to begin a new game ?", "Confirmation", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                _controler.FinalForm.CurrentGame = new Game();
                _controler.HideLevelMenu();

                _controler.DisplayNewGame();

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "poule2.wav";
                player.Play();
            }
        }

        private void buttonReturn_Click( object sender, EventArgs e )
        {
            _controler.HideLevelMenu();
        }
    }
}
