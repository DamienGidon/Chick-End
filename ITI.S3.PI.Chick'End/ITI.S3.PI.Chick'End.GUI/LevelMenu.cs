using System;
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
            Anchor = (AnchorStyles.Top);
        }

        private void buttonLevel1_Click( object sender, EventArgs e )
        {
            if (_controler.FinalForm.CurrentGame == null || MessageBox.Show( "Do you really want to begin a new game ?", "Confirmation", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                _controler.FinalForm.CurrentGame = new Game( "Map1.bin" );
                _controler.HideLevelMenu();
                ViewMapControler VMC = (ViewMapControler)_controler.Gamecontrol.Controls[0];
                VMC.TestWidth = _controler.FinalForm.CurrentGame.Map.NbCaseWidth * FinalVariables.SquareWidthInMeters;
                VMC.TestHeight = _controler.FinalForm.CurrentGame.Map.NbCaseHeight * FinalVariables.SquareHeightInMeters;

                _controler.DisplayExistingGame();

                _controler.Gamecontrol.Minute = 0;
                _controler.Gamecontrol.Seconde = 0;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "poule2.wav";
                player.Play();

            }
        }

        private void buttonReturn_Click( object sender, EventArgs e )
        {
            _controler.HideLevelMenu();
        }

        private void buttonLevel1_MouseEnter(object sender, EventArgs e)
        {
            MouseEventsHelper.ChangeFontSize(sender, 34F);
        }

        private void buttonLevel1_MouseLeave(object sender, EventArgs e)
        {
            MouseEventsHelper.ChangeFontSize(sender, 30F);
        }

        private void buttonReturn_MouseEnter(object sender, EventArgs e)
        {
            MouseEventsHelper.ChangeFontSize(sender, 34F);
        }

        private void buttonReturn_MouseLeave(object sender, EventArgs e)
        {
            MouseEventsHelper.ChangeFontSize(sender, 30F);
        }

        private void buttonLevel2_Click( object sender, EventArgs e )
        {
            if (_controler.FinalForm.CurrentGame == null || MessageBox.Show( "Do you really want to begin a new game ?", "Confirmation", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                _controler.FinalForm.CurrentGame = new Game( "Map2.bin" );
                _controler.HideLevelMenu();
                ViewMapControler VMC = (ViewMapControler)_controler.Gamecontrol.Controls[0];
                VMC.TestWidth = _controler.FinalForm.CurrentGame.Map.NbCaseWidth * FinalVariables.SquareWidthInMeters;
                VMC.TestHeight = _controler.FinalForm.CurrentGame.Map.NbCaseHeight * FinalVariables.SquareHeightInMeters;

                _controler.DisplayExistingGame();

                _controler.Gamecontrol.Minute = 0;
                _controler.Gamecontrol.Seconde = 0;

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "poule2.wav";
                player.Play();
            }
        }

        private void buttonLevel2_MouseEnter(object sender, EventArgs e)
        {
            MouseEventsHelper.ChangeFontSize(sender, 34F);
        }

        private void buttonLevel2_MouseLeave(object sender, EventArgs e)
        {
            MouseEventsHelper.ChangeFontSize(sender, 30F);
        }
    }
}
