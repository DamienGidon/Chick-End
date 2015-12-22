using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class GameMenu : UserControl
    {
        Controler _controler;

        public GameMenu( Controler controler )
        {
            InitializeComponent();
            _controler = controler;
        }

        private void buttonResume_Click( object sender, System.EventArgs e )
        {
            _controler.Gamecontrol.Resume();
            _controler.HideGameMenu();
            _controler.Gamecontrol.Refresh();
        }

        private void buttonBestiary_Click( object sender, EventArgs e )
        {
            _controler.DisplayBestiary();
        }

        private void buttonSave_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "Your game has been saved." );
        }

        private void buttonQuit_Click( object sender, EventArgs e )
        {
            if( MessageBox.Show("Do you really want to quit the current game ?", "Confirmation", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                _controler.HideGameMenu();
                _controler.HideGamecontrol();
                _controler.DisplayMainMenu();
            }
        }

        // Code d'affichage des boutons
        private void buttonBestiary_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseEnter( sender );
        }
        private void buttonBestiary_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseLeave( sender );
        }

        private void buttonResume_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseEnter( sender );
        }
        private void buttonResume_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseLeave( sender );
        }

        private void buttonSave_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseEnter( sender );
        }
        private void buttonSave_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseLeave( sender );
        }
        
        private void buttonQuit_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseEnter( sender );
        }
        private void buttonQuit_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseLeave( sender );
        }
    }
}
