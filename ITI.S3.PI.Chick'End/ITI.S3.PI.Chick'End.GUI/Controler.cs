using System.Diagnostics;

namespace ITI.S3.PI.Chick_End.GUI
{
    public class Controler
    {
        readonly FormF _finalForm;
        readonly MainMenu _mainMenu;
        readonly gamecontrol _gamecontrol;
        readonly Bestiary _bestiary;
        readonly Leaderboard _leaderbord;
        readonly Rules _rules;
        readonly LevelMenu _levelMenu;
        readonly GameMenu _gameMenu;

        public Controler( FormF finalForm )
        {
            _finalForm = finalForm;
            _mainMenu = new MainMenu( this );
            _gamecontrol = new gamecontrol( this, "1" );
            _levelMenu = new LevelMenu( this );
            _rules = new Rules( this );
            _leaderbord = new Leaderboard( this );
            _bestiary = new Bestiary( this );
            _gameMenu = new GameMenu( this );

            _finalForm.Controls.Add( _levelMenu );
            _finalForm.Controls.Add( _gamecontrol );
            _finalForm.Controls.Add( _gameMenu );
            _finalForm.Controls.Add( _mainMenu );

            _gamecontrol.Hide();
            _levelMenu.Hide();
            _gameMenu.Hide();
        }

        public FormF FinalForm
        {
            get { return _finalForm; }
        }

        public gamecontrol Gamecontrol
        {
            get { return _gamecontrol; }
        }

        public void DisplayMainMenu()
        {
            _mainMenu.Show();
            _mainMenu.BringToFront();
        }

        public void HideMainMenu()
        {
            _mainMenu.Hide();
        }

        public void DisplayNewGame()
        {
            _finalForm.CurrentGame = new Game();
            _gamecontrol.BringToFront();
            _gamecontrol.Show();
        }

        public void DisplayExistingGame()
        {
            Debug.Assert( _finalForm.CurrentGame != null );
            _gamecontrol.BringToFront();
            _gamecontrol.Show();
        }

        public void HideGamecontrol()
        {
            _gamecontrol.Hide();
        }

        public void DisplayBestiary()
        {
            _bestiary.ShowDialog();
        }

        public void HideBestiary()
        {
            _bestiary.Close();
        }

        public void DisplayLeaderbord()
        {
            _leaderbord.ActualiseLeaderboard();
            _leaderbord.ShowDialog();
        }

        public void HideLeaderbord()
        {
            _leaderbord.Close();
        }

        public void DisplayLevelMenu()
        {
            _levelMenu.BringToFront();
            _levelMenu.Show();
        }

        public void HideLevelMenu()
        {
            _levelMenu.Hide();
        }

        public void DisplayRules()
        {
            _rules.ShowDialog();
        }

        public void HideRules()
        {
            _rules.Close();
        }

        public void DisplayGameMenu()
        {
            _gameMenu.Show();
            _gameMenu.BringToFront();
        }

        public void HideGameMenu()
        {
            _gameMenu.Hide();
        }

        public void CloseGame()
        {
            _finalForm.Close();
        }
    }
}
