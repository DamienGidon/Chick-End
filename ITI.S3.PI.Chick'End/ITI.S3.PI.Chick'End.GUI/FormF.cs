using System;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class FormF : Form, IGameContext
    {
        Controler _controler;
        Game _currentGame;
        public event EventHandler CurrentGameChanged;

        public FormF()
        {
            _controler = new Controler( this );
            InitializeComponent();
        }

        public Game CurrentGame
        {
            get { return _currentGame; }
            set
            {
                if (_currentGame != value)
                {
                    _currentGame = value;
                    var h = CurrentGameChanged;
                    if (h != null) h( this, EventArgs.Empty );
                }
            }
        }

        private void FormF_Load( object sender, EventArgs e )
        {
            _controler.DisplayMainMenu();
        }
    }
}
