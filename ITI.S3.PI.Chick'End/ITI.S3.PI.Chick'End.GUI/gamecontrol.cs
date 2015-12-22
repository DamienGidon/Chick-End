using System;
using System.Drawing;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public partial class gamecontrol : UserControl
    {
        Controler _controler;

        int _tick = 0;
        int _countM = 0;
        int _countR = 0;
        int _countS = 0;
        int _second = 0;
        int _minute = 0;
        int _seeds = 200;
        string _level;
        string _Ssecond;
        string _Sminute;
        bool sound = true;
        HenCreater _henCreater = new HenCreater();


        public gamecontrol( Controler controler, string level )
        {
            _controler = controler;
            _controler.FinalForm.CurrentGameChanged += OnCurrentGameChanged;
            viewMapControler1 = new ViewMapControler();
            InitializeComponent();

            _level = level;

            labelPrice.Text = "";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "bassecour.wav";
            player.Play();

            
            pictureBox1.AllowDrop = false;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            panelSeed.AllowDrop = true;
            viewMapControler1.AllowDrop = true;
            panel1.AllowDrop = true;
        }

        private void OnCurrentGameChanged( object sender, EventArgs e )
        {
            Pause();
            var game = _controler.FinalForm.CurrentGame;
            viewMapControler1.Map = game != null ? game.Map : null;
            Resume();
        }

        public void Resume()
        {
            timer1.Enabled = _controler.FinalForm.CurrentGame != null;
        }

        public void Pause()
        {
            timer1.Enabled = false;
        }

        private void ManageUsersControl_Load( object sender, EventArgs e )
        {
            this.Dock = DockStyle.Fill;
        }

        private void buttonMenu_Click( object sender, EventArgs e )
        {
            timer1.Stop();
            _controler.DisplayGameMenu();
        }
        
        private void buttonMenu_MouseEnter( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseEnter( sender );
        }

        private void buttonMenu_MouseLeave( object sender, EventArgs e )
        {
            MouseEventsHelper.ChangeFont_MouseLeave( sender );

        }

        private void viewMapControler1_DragEnter( object sender, DragEventArgs e )
        {
            if (e.Data.GetDataPresent( DataFormats.Bitmap ))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pictureBox10_DragEnter( object sender, DragEventArgs e )
        {
            if (e.Data.GetDataPresent( DataFormats.Bitmap ))
            {
                e.Effect = DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.Copy;
                Bitmap p10 = new Bitmap( @"OpenedLitter.png" );
                Graphics g10 = Graphics.FromImage( p10 );
                g10.DrawImage( p10, 60, 60 );
                pictureBox10.Image = p10;

            }
        }

        private void pictureBox1_DragDrop( object sender, DragEventArgs e )
        {
            PictureBox pb = ((PictureBox)sender);
            pb.Image = (Image)e.Data.GetData( DataFormats.Bitmap );
        }

        private void pictureBox1_MouseDown( object sender, MouseEventArgs e )
        {
            PictureBox pb = ((PictureBox)sender);
            pb.Select();
            pb.DoDragDrop( pb.Image, DragDropEffects.Copy );

            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (viewMapControler1.Width / 14)) * (viewMapControler1.Width / 14));
            int topLeftCornerY = ((relativePoint.Y / (viewMapControler1.Height / 9)) * (viewMapControler1.Height / 9));
            int line = topLeftCornerY / (viewMapControler1.Height / 9);
            int column = topLeftCornerX / (viewMapControler1.Width / 14);

            if (viewMapControler1.Map.Square[line, column].Decoration != "path" || viewMapControler1.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (_henCreater.HenCost <= _seeds)
                {
                    _seeds = _seeds - _henCreater.HenCost;
                    viewMapControler1.Map.CreateHen( line, column, viewMapControler1.Map );
                    //viewMapControler1.Context.HenCreater.CreateHen(line, column, viewMapControler1.Context.Map);
                }
            }
        }

        private void pictureBox2_DragDrop( object sender, DragEventArgs e )
        {
            PictureBox pb2 = ((PictureBox)sender);
            pb2.Image = (Image)e.Data.GetData( DataFormats.Bitmap );
        }

        private void pictureBox2_MouseDown( object sender, MouseEventArgs e )
        {
            PictureBox pb2 = ((PictureBox)sender);
            pb2.Select();
            pb2.DoDragDrop( pb2.Image, DragDropEffects.Copy );

            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (viewMapControler1.Width / 14)) * (viewMapControler1.Width / 14));
            int topLeftCornerY = ((relativePoint.Y / (viewMapControler1.Height / 9)) * (viewMapControler1.Height / 9));
            int line = topLeftCornerY / (viewMapControler1.Height / 9);
            int column = topLeftCornerX / (viewMapControler1.Width / 14);

            if (viewMapControler1.Map.Square[line, column].Decoration != "path" || viewMapControler1.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (_henCreater.InfantryFarmerCost <= _seeds)
                {
                    _seeds = _seeds - _henCreater.InfantryFarmerCost;
                    viewMapControler1.Map.CreateInfantryFarmer( line, column, viewMapControler1.Map );
                }
            }
        }

        private void pictureBox3_DragDrop( object sender, DragEventArgs e )
        {
            PictureBox pb3 = ((PictureBox)sender);
            pb3.Image = (Image)e.Data.GetData( DataFormats.Bitmap );
        }

        private void pictureBox4_DragDrop( object sender, DragEventArgs e )
        {
            PictureBox pb4 = ((PictureBox)sender);
            pb4.Image = (Image)e.Data.GetData( DataFormats.Bitmap );
        }

        private void pictureBox4_MouseDown( object sender, MouseEventArgs e )
        {
            PictureBox pb4 = ((PictureBox)sender);
            pb4.Select();
            pb4.DoDragDrop( pb4.Image, DragDropEffects.Copy );

            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (viewMapControler1.Width / 14)) * (viewMapControler1.Width / 14));
            int topLeftCornerY = ((relativePoint.Y / (viewMapControler1.Height / 9)) * (viewMapControler1.Height / 9));
            int line = topLeftCornerY / (viewMapControler1.Height / 9);
            int column = topLeftCornerX / (viewMapControler1.Width / 14);

            if (viewMapControler1.Map.Square[line, column].Decoration != "path" || viewMapControler1.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (_henCreater.GunnerFarmerCost <= _seeds)
                {
                    _seeds = _seeds - _henCreater.GunnerFarmerCost;
                    viewMapControler1.Map.CreateGunnerFarmer( line, column, viewMapControler1.Map );
                }
            }
        }

        private void pictureBox3_MouseDown( object sender, MouseEventArgs e )
        {
            PictureBox pb3 = ((PictureBox)sender);
            pb3.Select();
            pb3.DoDragDrop( pb3.Image, DragDropEffects.Copy );

            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (viewMapControler1.Width / 14)) * (viewMapControler1.Width / 14));
            int topLeftCornerY = ((relativePoint.Y / (viewMapControler1.Height / 9)) * (viewMapControler1.Height / 9));
            int line = topLeftCornerY / (viewMapControler1.Height / 9);
            int column = topLeftCornerX / (viewMapControler1.Width / 14);

            if (viewMapControler1.Map.Square[line, column].Decoration != "path" || viewMapControler1.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (_henCreater.BomberHenCost <= _seeds)
                {
                    _seeds = _seeds - _henCreater.BomberHenCost;
                    viewMapControler1.Map.CreateBomberHen( line, column, viewMapControler1.Map );
                }
            }
        }

        private void pictureBox5_DragDrop( object sender, DragEventArgs e )
        {
            PictureBox pb4 = ((PictureBox)sender);
            pb4.Image = (Image)e.Data.GetData( DataFormats.Bitmap );

        }

        private void pictureBox5_MouseDown( object sender, MouseEventArgs e )
        {
            PictureBox pb5 = ((PictureBox)sender);
            pb5.Select();
            pb5.DoDragDrop( pb5.Image, DragDropEffects.Copy );

            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (viewMapControler1.Width / 14)) * (viewMapControler1.Width / 14));
            int topLeftCornerY = ((relativePoint.Y / (viewMapControler1.Height / 9)) * (viewMapControler1.Height / 9));
            int line = topLeftCornerY / (viewMapControler1.Height / 9);
            int column = topLeftCornerX / (viewMapControler1.Width / 14);

            if (viewMapControler1.Map.Square[line, column].Decoration != "path" || viewMapControler1.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (_henCreater.OldHenCost <= _seeds)
                {
                    _seeds = _seeds - _henCreater.OldHenCost;
                    viewMapControler1.Map.CreateOldHen( line, column, viewMapControler1.Map );
                }
            }
        }

        private void pictureBox6_DragDrop( object sender, DragEventArgs e )
        {
            PictureBox pb6 = ((PictureBox)sender);
            pb6.Image = (Image)e.Data.GetData( DataFormats.Bitmap );
        }

        private void pictureBox6_MouseDown( object sender, MouseEventArgs e )
        {
            PictureBox pb6 = ((PictureBox)sender);
            pb6.Select();
            pb6.DoDragDrop( pb6.Image, DragDropEffects.Copy );

            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (viewMapControler1.Width / 14)) * (viewMapControler1.Width / 14));
            int topLeftCornerY = ((relativePoint.Y / (viewMapControler1.Height / 9)) * (viewMapControler1.Height / 9));
            int line = topLeftCornerY / (viewMapControler1.Height / 9);
            int column = topLeftCornerX / (viewMapControler1.Width / 14);

            if (viewMapControler1.Map.Square[line, column].Decoration != "path" || viewMapControler1.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (_henCreater.BakerCost <= _seeds)
                {
                    _seeds = _seeds - _henCreater.BakerCost;
                    viewMapControler1.Map.CreateBaker( line, column, viewMapControler1.Map );
                }
            }
        }

        private void pictureBox7_DragDrop( object sender, DragEventArgs e )
        {
            PictureBox pb7 = ((PictureBox)sender);
            pb7.Image = (Image)e.Data.GetData( DataFormats.Bitmap );
        }

        private void pictureBox7_MouseDown( object sender, MouseEventArgs e )
        {
            PictureBox pb7 = ((PictureBox)sender);
            pb7.Select();
            pb7.DoDragDrop( pb7.Image, DragDropEffects.Copy );

            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (viewMapControler1.Width / 14)) * (viewMapControler1.Width / 14));
            int topLeftCornerY = ((relativePoint.Y / (viewMapControler1.Height / 9)) * (viewMapControler1.Height / 9));
            int line = topLeftCornerY / (viewMapControler1.Height / 9);
            int column = topLeftCornerX / (viewMapControler1.Width / 14);

            if (viewMapControler1.Map.Square[line, column].Decoration != "path" || viewMapControler1.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (_henCreater.ExplosiveEggCost <= _seeds)
                {
                    _seeds = _seeds - _henCreater.ExplosiveEggCost;
                    viewMapControler1.Map.CreateExplosiveEgg( line, column, viewMapControler1.Map );
                }
            }
        }

        private void pictureBox8_DragDrop( object sender, DragEventArgs e )
        {
            PictureBox pb8 = ((PictureBox)sender);
            pb8.Image = (Image)e.Data.GetData( DataFormats.Bitmap );
        }

        private void pictureBox8_MouseDown( object sender, MouseEventArgs e )
        {
            PictureBox pb8 = ((PictureBox)sender);
            pb8.Select();
            pb8.DoDragDrop( pb8.Image, DragDropEffects.Copy );

            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (viewMapControler1.Width / 14)) * (viewMapControler1.Width / 14));
            int topLeftCornerY = ((relativePoint.Y / (viewMapControler1.Height / 9)) * (viewMapControler1.Height / 9));
            int line = topLeftCornerY / (viewMapControler1.Height / 9);
            int column = topLeftCornerX / (viewMapControler1.Width / 14);

            if (viewMapControler1.Map.Square[line, column].Decoration != "path" || viewMapControler1.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (_henCreater.ButcherCost <= _seeds)
                {
                    _seeds = _seeds - _henCreater.ButcherCost;
                    viewMapControler1.Map.CreateButcher( line, column, viewMapControler1.Map );
                }
            }
        }

        private void pictureBox9_DragDrop( object sender, DragEventArgs e )
        {
            PictureBox pb9 = ((PictureBox)sender);
            pb9.Image = (Image)e.Data.GetData( DataFormats.Bitmap );
        }

        private void pictureBox9_MouseDown( object sender, MouseEventArgs e )
        {
            PictureBox pb9 = ((PictureBox)sender);
            pb9.Select();
            pb9.DoDragDrop( pb9.Image, DragDropEffects.Copy );

            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
            int topLeftCornerX = ((relativePoint.X / (viewMapControler1.Width / 14)) * (viewMapControler1.Width / 14));
            int topLeftCornerY = ((relativePoint.Y / (viewMapControler1.Height / 9)) * (viewMapControler1.Height / 9));
            int line = topLeftCornerY / (viewMapControler1.Height / 9);
            int column = topLeftCornerX / (viewMapControler1.Width / 14);

            if (viewMapControler1.Map.Square[line, column].Decoration != "path" || viewMapControler1.Map.Square[line, column].Tower != null)
            {

            }
            else
            {
                if (_henCreater.RoosterCost <= _seeds)
                {
                    _seeds = _seeds - _henCreater.RoosterCost;
                    viewMapControler1.Map.CreateRooster( line, column, viewMapControler1.Map );
                }
            }
        }

        private void viewMapControler1_DragDrop( object sender, DragEventArgs e )
        {
            ViewMapControler v = ((ViewMapControler)sender);
            var relativePoint = viewMapControler1.PointToClient( Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y ) );
        }

        private void viewMapControler1_MouseDown( object sender, MouseEventArgs e )
        {
            ViewMapControler v = ((ViewMapControler)sender);
            v.Select();
            v.DoDragDrop( v, DragDropEffects.Copy );
            int line = e.Y / (viewMapControler1.Height / 9);
            int column = e.X / (viewMapControler1.Width / 14);
            var trashPosition = pictureBox10.PointToScreen( new Point( 10, 10 ) );
            var x = Cursor.Position.X;
            var y = Cursor.Position.Y;
            var trashX = trashPosition.X;
            var trashY = trashPosition.Y;

            Bitmap p10 = new Bitmap( @"ClosedLitter.png" );
            Graphics g10 = Graphics.FromImage( p10 );
            g10.DrawImage( p10, 60, 60 );
            pictureBox10.Image = p10;
            if (viewMapControler1.Map.Square[line, column].Tower != null && x < trashX + 50 && x > trashX && y < trashY + 50 && y > trashY)
            {
                viewMapControler1.Map.Square[line, column].Tower.Die();
            }
        }

        private void viewMapControler1_Resize( object sender, EventArgs e )
        {
            ViewMapControler item = (ViewMapControler)sender;
            item.Refresh();
        }

        private void buttonSave_Click( object sender, EventArgs e )
        {
            //using (FileStream fs = new FileStream("objet.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    BinaryFormatter ser = new BinaryFormatter();
            //    ser.Serialize(fs, viewMapControler1.Context);
            //}
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            _tick++;

            //affichage Timer
            _countM++;
            if (_countM == 20)
            {
                _countM = 0;
                _second++;
                if (_second == 60)
                {
                    _second = 0;
                    _minute++;
                }
            }
            _Ssecond = _second < 10 ? Convert.ToString( "0" + _second ) : Convert.ToString( _second );
            _Sminute = _minute < 10 ? Convert.ToString( "0" + _minute ) : Convert.ToString( _minute );
            labelTimer.Text = _Sminute + ":" + _Ssecond;

            //génération ressources
            _countR++;
            if (_countR == 100)
            {
                _countR = 0;
                _seeds += 200;
            }
            labelSeedNumber.Text = Convert.ToString( _seeds );

            //génération du son
            if (sound == true)
            {
                _countS++;
                if (_countS == 100)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = "bassecour.wav";
                    player.Play();
                    _countS = 0;
                }
            }

            //génération ennemis
            Spawn s = new Spawn( _tick, _controler.FinalForm.CurrentGame );

            foreach (Ennemi en in viewMapControler1.Map.Ennemis)
            {
                if (en.Way.Next.Decoration == "HomeHen")
                {
                    _controler.FinalForm.CurrentGame.IsLost = true;
                }
            }
            if (_controler.FinalForm.CurrentGame.IsLost)
            {
                if (sound == true)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = "defaite.wav";
                    player.Play();
                }
                this.timer1.Stop();
                GameOver g = new GameOver( labelTimer.Text, _level );
                g.ShowDialog();
            }
            else
            {
                _controler.FinalForm.CurrentGame.Update(_tick);
                viewMapControler1.Refresh();
            }
        }

        private void pictureBox10_Click( object sender, EventArgs e )
        {
            if (sound == true)
            {
                sound = false;
                _countS = 90;
                pictureBox11.Image = new Bitmap( @"muet.png" );
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "poule2.wav";
                player.Play();
            }
            else
            {
                sound = true;
                pictureBox11.Image = new Bitmap( "volume.png" );
            }
        }

        private void pictureBox1_MouseEnter( object sender, EventArgs e )
        {
            labelPrice.Text = Convert.ToString( _henCreater.HenCost );
        }

        private void pictureBox5_MouseEnter( object sender, EventArgs e )
        {
            labelPrice.Text = Convert.ToString( _henCreater.OldHenCost );
        }

        private void pictureBox3_MouseEnter( object sender, EventArgs e )
        {
            labelPrice.Text = Convert.ToString( _henCreater.BomberHenCost );
        }

        private void pictureBox7_MouseEnter( object sender, EventArgs e )
        {
            labelPrice.Text = Convert.ToString( _henCreater.ExplosiveEggCost );
        }

        private void pictureBox9_MouseEnter( object sender, EventArgs e )
        {
            labelPrice.Text = Convert.ToString( _henCreater.RoosterCost );
        }

        private void pictureBox4_MouseEnter( object sender, EventArgs e )
        {
            labelPrice.Text = Convert.ToString( _henCreater.GunnerFarmerCost );
        }

        private void pictureBox2_MouseEnter( object sender, EventArgs e )
        {
            labelPrice.Text = Convert.ToString( _henCreater.InfantryFarmerCost );
        }

        private void pictureBox6_MouseEnter( object sender, EventArgs e )
        {
            labelPrice.Text = Convert.ToString( _henCreater.BakerCost );
        }

        private void panel1_MouseEnter( object sender, EventArgs e )
        {
            labelPrice.Text = Convert.ToString( _henCreater.ButcherCost );
        }
    }
}