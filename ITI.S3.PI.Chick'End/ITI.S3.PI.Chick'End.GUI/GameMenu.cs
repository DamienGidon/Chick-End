using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
            using (FileStream fs = new FileStream("save.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                BinaryFormatter ser = new BinaryFormatter();
                ser.Serialize(fs, _controler.FinalForm.CurrentGame);
            }
        }

        private void buttonQuit_Click( object sender, EventArgs e )
        {
            if( MessageBox.Show("Do you really want to quit the current game ?", "Confirmation", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                foreach (KeyValuePair<Enemy, ProgressBar> dicoE in _controler.Gamecontrol.EnemiesLifebar)
                {
                    dicoE.Value.Dispose();
                }

                foreach (KeyValuePair<Tower, ProgressBar> dicoE in _controler.Gamecontrol.TowersLifeBar)
                {
                    dicoE.Value.Dispose();
                }
                _controler.HideGameMenu();
                _controler.HideGamecontrol();
                _controler.DisplayMainMenu();
            }
        }

        // Code d'affichage des boutons
        private void buttonBestiary_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 28F );
        }
        private void buttonBestiary_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 25F );
        }

        private void buttonResume_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 28F );
        }
        private void buttonResume_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 25F );
        }

        private void buttonSave_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 28F );
        }
        private void buttonSave_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 25F );
        }
        
        private void buttonQuit_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 28F );
        }
        private void buttonQuit_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize( sender, 25F );
        }
    }
}
