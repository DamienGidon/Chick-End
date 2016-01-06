using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class MainMenu : UserControl
    {
        internal Controler _controler;

        public MainMenu( Controler controler )
        {
            InitializeComponent();

            _controler = controler;

            Bitmap p = new Bitmap( @"HenLeft.png" );
            Graphics g = Graphics.FromImage( p );
            g.DrawImage( p, 60, 60 );
            pictureBox1.Image = p;

            Bitmap p1 = new Bitmap( @"Wolf.png" );
            Graphics g1 = Graphics.FromImage( p1 );
            g1.DrawImage( p, 60, 60 );
            pictureBox2.Image = p1;
        }

        IGameContext GameContext
        {
            get { return (IGameContext)FindForm(); }
        }

        internal Controler Controler
        {
            get { return _controler; }
        }

        private void buttonPlay_Click( object sender, EventArgs e )
        {
            Controler.DisplayLevelMenu();
        }

        private void ManageUsersControl_Load( object sender, EventArgs e )
        {
            this.Dock = DockStyle.Fill;
        }

        private void buttonContinue_Click( object sender, EventArgs e )
        {
            //gamecontrol g1 = new gamecontrol();
            //g1.SetPanel(MenuPanel);
            //this.Controls.Add(g1);

            //using (FileStream fs = new FileStream("objet.bin", FileMode.Open, FileAccess.Read, FileShare.None))
            //{
            //    BinaryFormatter ser = new BinaryFormatter();
            //    Game game = (Game)ser.Deserialize(fs);
            //    MenuPanel.Hide();
            //    //g1.dgv.DataSource = new List<Game> { game };

            //}
        }

        private void buttonRules_Click( object sender, EventArgs e )
        {
            _controler.DisplayRules();
        }

        private void buttonBestiary_Click( object sender, EventArgs e )
        {
            _controler.DisplayBestiary();
        }

        private void buttonQuit_Click( object sender, EventArgs e )
        {
            _controler.CloseGame();
        }

        private void buttonLeaderboard_Click( object sender, EventArgs e )
        {
            _controler.DisplayLeaderbord();
        }

        private void pictureBox1_Click( object sender, EventArgs e )
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "poule2.wav";
            player.Play();
        }

        private void pictureBox2_Click( object sender, EventArgs e )
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "loup.wav";
            player.Play();
        }

        // Rendre les boutons plus propres
        private void ChangeFont_MouseEnter( object sender )
        {
            MouseEventsHelper.ChangeFontSize(sender, 58F);
        }
        private void buttonPlay_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 58F);
        }

        private void buttonPlay_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 48F);
        }

        private void buttonBestiary_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 58F);
        }

        private void buttonBestiary_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 48F);
        }

        private void buttonContinue_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 58F);
        }

        private void buttonContinue_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 48F);
        }

        private void buttonRules_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 58F);
        }

        private void buttonRules_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 48F);
        }

        private void buttonLeaderboard_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 58F);
        }

        private void buttonLeaderboard_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 48F);
        }

        private void buttonQuit_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 58F);
        }

        private void buttonQuit_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFontSize(sender, 48F);
        }
    }
}
