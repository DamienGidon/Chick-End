using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public class ViewMapControler : Panel
    {
        Map _map;
        readonly Image _grass;
        readonly Image _path;
        readonly Image _homeHen;
        readonly Image _explosiveEgg;

        public ViewMapControler()
        {
            DoubleBuffered = true;
            //if (this.IsInDesignMode() || _map == null)
            //{
            //    BackColor = Color.Green;
            //}
            //else
            //{
                string directory = Path.GetDirectoryName( Application.ExecutablePath );
                string pathPath = Path.Combine( directory, @"path.png" );
                string pathGrass = Path.Combine( directory, @"grass.png" );
                string pathHomeHen = Path.Combine( directory, @"HomeHen.png" );
                string pathExplosiveEgg = Path.Combine( directory, @"ExplosiveEgg.png" );

                _path = Image.FromFile( pathPath );
                _grass = Image.FromFile( pathGrass );
                _homeHen = Image.FromFile( pathHomeHen );
                _explosiveEgg = Image.FromFile( pathExplosiveEgg );
            //}
            
        }
        public int TestWidth { get; set; }
        public int TestHeight { get; set; }

        public Map Map
        {
            get { return _map; }
            set
            {
                if (_map != value)
                {
                    _map = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            if (this.IsInDesignMode() || _map == null)
            {
                BackColor = Color.Green;
            }
            else
            {
                //double time = (DateTime.Now - DateTime.MinValue).TotalMilliseconds / 500.0;
                //double angle = Math.Sin( time );
                //e.Graphics.RotateTransform( (float)(angle*15) );
                //e.Graphics.ScaleTransform( 0.9f, 0.9f );

                int CaseShouldBeThatHeight = Size.Height / _map.NbCaseHeight;
                int CaseShouldBeThatWidth = Size.Width / _map.NbCaseWidth;

                for (int i = 0; i < _map.NbCaseHeight; i++)
                {
                    for (int j = 0; j < _map.NbCaseWidth; j++)
                    {
                        if (_map.Square[i, j].Decoration == "grass")
                        {
                            e.Graphics.DrawImage( _grass, _map.Square[i, j].Column * CaseShouldBeThatWidth, _map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                        }
                        else if (_map.Square[i, j].Decoration == "path")
                        {
                            e.Graphics.DrawImage( _path, _map.Square[i, j].Column * CaseShouldBeThatWidth, _map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                        }
                        else if (_map.Square[i, j].Decoration == "HomeHen")
                        {
                            e.Graphics.DrawImage( _homeHen, _map.Square[i, j].Column * CaseShouldBeThatWidth, _map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                        }
                    }
                }

                // On affiche les poules
                foreach (Tower t in Map.Towers)
                {
                    if (t.Kind == "hen")
                    {
                        e.Graphics.DrawImage( t.UnitImage, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                    }
                    else if (t is ExplosiveEgg)
                    {
                        e.Graphics.DrawImage( _explosiveEgg, t.Square.Column * CaseShouldBeThatWidth + Convert.ToInt32( CaseShouldBeThatWidth * 0.2 ), t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth - Convert.ToInt32( CaseShouldBeThatWidth * 0.3 ), CaseShouldBeThatHeight );
                    }
                    else if (t.Kind == "human")
                    {
                        e.Graphics.DrawImage( t.UnitImage, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32( CaseShouldBeThatHeight * 0.4 ), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32( (CaseShouldBeThatHeight * 0.4) ) );
                    }
                }

                //On affiche les ennemis
                foreach (Enemy en in Map.Enemies)
                {
                    int x = en.Position.X;
                    int y = en.Position.Y;

                    int imgFutureWidth = this.Width * en.ImageWidth / this.TestWidth;
                    int imgFutureHeight = this.Height * en.ImageHeight / this.TestHeight;
                    int futureX = this.Width * en.X / this.TestWidth;
                    int futureY = this.Height * en.Y / this.TestHeight;

                    e.Graphics.DrawImage( en.UnitImage, futureX, futureY, imgFutureWidth, imgFutureHeight );
                    e.Graphics.DrawImage(en.UnitImage, futureX, futureY, imgFutureWidth, imgFutureHeight);
                }

                // On affiche les oeufs
                foreach (EggLauncher eg in Map.Eggs)
                {
                    int x = eg.Position.X;
                    int y = eg.Position.Y;
                    int imgFutureWidth = this.Width * eg.ImageWidth / this.TestWidth;
                    int imgFutureHeight = this.Height * eg.ImageHeight / this.TestHeight;
                    int futureX = this.Width * eg.Position.X / this.TestWidth;
                    int futureY = this.Height * eg.Position.Y / this.TestHeight;
                    e.Graphics.DrawImage( eg.UnitImage, futureX, futureY, imgFutureWidth, imgFutureHeight );
                }
            }
            base.OnPaint( e );
        }
    }
}