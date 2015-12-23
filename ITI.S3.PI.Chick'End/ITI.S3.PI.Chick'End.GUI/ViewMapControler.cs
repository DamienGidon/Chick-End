using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public class ViewMapControler : Panel
    {
        Map _map;

        public ViewMapControler()
        {
            DoubleBuffered = true;
        }

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
                //e.Graphics.FillRectangle( Brushes.Yellow, e.ClipRectangle );
                BackColor = Color.Green;
            }
            else
            {
                string directory = Path.GetDirectoryName( Application.ExecutablePath );
                string pathGrass = Path.Combine( directory, @"grass.png" );
                string pathPath = Path.Combine( directory, @"path.png" );
                string pathHomeHen = Path.Combine( directory, @"HomeHen.png" );
                string pathHen = Path.Combine( directory, @"HenLeft.png" );
                string pathRooster = Path.Combine( directory, @"Rooster.png" );
                string pathOldHen = Path.Combine( directory, @"OldHen.png" );
                string pathExplosiveEgg = Path.Combine( directory, @"ExplosiveEgg.png" );
                string pathBomberHen = Path.Combine( directory, @"BomberHen.png" );
                string pathBaker = Path.Combine( directory, @"Baker.png" );
                string pathButcher = Path.Combine( directory, @"Bucher.png" );
                string pathgunnerFarmer = Path.Combine( directory, @"gunnerFarmer.png" );
                string pathInfantryFarmer = Path.Combine( directory, @"InfantryFarmer.png" );
                string pathWolf = Path.Combine( directory, @"Wolf.png" );
                string pathFox = Path.Combine( directory, @"Fox.png" );
                string pathHyena = Path.Combine( directory, @"Hyena.png" );
                string pathLion = Path.Combine( directory, @"Lion.png" );
                string pathCerberus = Path.Combine( directory, @"Cerberus.png" );
                string pathAnubis = Path.Combine( directory, @"Anubis.png" );
                string pathNormalEgg = Path.Combine(directory, @"NormalEgg.png");
                string pathRottenEgg = Path.Combine(directory, @"RottenEgg.png");

                Image grass = Image.FromFile( pathGrass );
                Image path = Image.FromFile( pathPath );
                Image HomeHen = Image.FromFile( pathHomeHen );
                Image hen = Image.FromFile( pathHen );
                Image OldHen = Image.FromFile( pathOldHen );
                Image Rooster = Image.FromFile( pathRooster );
                Image BomberHen = Image.FromFile( pathBomberHen );
                Image ExplosiveEgg = Image.FromFile( pathExplosiveEgg );
                Image Baker = Image.FromFile( pathBaker );
                Image Butcher = Image.FromFile( pathButcher );
                Image gunnerFarmer = Image.FromFile( pathgunnerFarmer );
                Image InfantryFarmer = Image.FromFile( pathInfantryFarmer );
                Image Wolf = Image.FromFile( pathWolf );
                Image Fox = Image.FromFile( pathFox );
                Image Hyena = Image.FromFile( pathHyena );
                Image Lion = Image.FromFile( pathLion );
                Image Cerberus = Image.FromFile( pathCerberus );
                Image Anubis = Image.FromFile( pathAnubis );
                Image NormalEgg = Image.FromFile(pathNormalEgg);
                Image RottenEgg = Image.FromFile(pathRottenEgg);

                int CaseShouldBeThatHeight = e.ClipRectangle.Height / FinalVariables.NbCaseHeightMap1;
                int CaseShouldBeThatWidth = e.ClipRectangle.Width / FinalVariables.NbCaseWidthMap1;

                for (int i = 0; i < FinalVariables.NbCaseHeightMap1; i++)
                {
                    for (int j = 0; j < FinalVariables.NbCaseWidthMap1; j++)
                    {
                        if (_map.Square[i, j].Decoration == "grass")
                        {
                            e.Graphics.DrawImage( grass, _map.Square[i, j].Column * CaseShouldBeThatWidth, _map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                        }
                        else if (_map.Square[i, j].Decoration == "path")
                        {
                            e.Graphics.DrawImage( path, _map.Square[i, j].Column * CaseShouldBeThatWidth, _map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                        }
                        else if (_map.Square[i, j].Decoration == "HomeHen")
                        {
                            e.Graphics.DrawImage( HomeHen, _map.Square[i, j].Column * CaseShouldBeThatWidth, _map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                        }
                    }
                }

                // On affiche les poules
                for (int i = 0; i < FinalVariables.NbCaseHeightMap1; i++)
                {
                    for (int j = 0; j < FinalVariables.NbCaseWidthMap1; j++)
                    {
                        foreach (Tower t in Map.Towers)
                        {
                            if (t is Hen)
                            {
                                e.Graphics.DrawImage( hen, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                            }
                            else if (t is OldHen)
                            {
                                e.Graphics.DrawImage( OldHen, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                            }
                            else if (t is BomberHen)
                            {
                                e.Graphics.DrawImage( BomberHen, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight );
                            }
                            else if (t is ExplosiveEgg)
                            {
                                e.Graphics.DrawImage( ExplosiveEgg, t.Square.Column * CaseShouldBeThatWidth + Convert.ToInt32( CaseShouldBeThatWidth * 0.2 ), t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth - Convert.ToInt32( CaseShouldBeThatWidth * 0.3 ), CaseShouldBeThatHeight );
                            }
                            else if (t is Rooster)
                            {
                                e.Graphics.DrawImage( Rooster, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32( CaseShouldBeThatHeight * 0.1 ), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32( (CaseShouldBeThatHeight * 0.1) ) );
                            }
                            else if (t is Bucher)
                            {
                                e.Graphics.DrawImage( Butcher, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32( CaseShouldBeThatHeight * 0.4 ), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32( (CaseShouldBeThatHeight * 0.4) ) );
                            }
                            else if (t is Baker)
                            {
                                e.Graphics.DrawImage( Baker, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32( CaseShouldBeThatHeight * 0.4 ), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32( (CaseShouldBeThatHeight * 0.4) ) );
                            }
                            else if (t is GunnerFarmer)
                            {
                                e.Graphics.DrawImage( gunnerFarmer, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32( CaseShouldBeThatHeight * 0.4 ), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32( (CaseShouldBeThatHeight * 0.4) ) );
                            }
                            else if (t is InfantryFarmer)
                            {
                                e.Graphics.DrawImage( InfantryFarmer, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32( CaseShouldBeThatHeight * 0.4 ), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32( (CaseShouldBeThatHeight * 0.4) ) );
                            }
                        }
                    }
                }

                //On affiche les ennemis
                foreach (Ennemi en in Map.Ennemis)
                {
                    int x = en.Position.X;
                    int y = en.Position.Y;

                    if (en is Wolf)
                    {
                        e.Graphics.DrawImage( Wolf, x, y - 20, 60, 50 );
                    }
                    else if (en is Fox)
                    {
                        e.Graphics.DrawImage( Fox, x, y , 50 , 40 );
                    }
                    else if (en is Hyena)
                    {
                        e.Graphics.DrawImage( Hyena, x, y, 40, 40 );
                    }
                    else if (en is Lion)
                    {
                        e.Graphics.DrawImage( Lion, x, y, 60, 50 );
                    }
                    else if (en is Cerberus)
                    {
                        e.Graphics.DrawImage( Cerberus, x, y, 80, 70 );
                    }
                    else if (en is Anubis)
                    {
                        e.Graphics.DrawImage( Anubis, x, y, 60, 70 );
                    }
                }

                // On affiche les oeufs
                foreach(EggLauncher eg in Map.Eggs)
                {
                    int x = eg.Position.X;
                    int y = eg.Position.Y;

                    if (eg is NormalEgg)
                    {
                        e.Graphics.DrawImage(NormalEgg, x, y, 26, 20);
                    }
                    else if (eg is RottenEgg)
                    {
                        e.Graphics.DrawImage(RottenEgg, x, y, 26, 20);
                    }
                }
            }
            base.OnPaint( e );
        }
    }
}
