using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public class ViewMapControler : Panel
    {
        Map _map;
        //Animate _animate;

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
                //string pathWolfMove = Path.Combine(directory, @"WolfMove.gif");

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
                //Image WolfMove = Image.FromFile(pathWolfMove);

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
                    if (en is Wolf)
                    {
                        int X = en.Position.X;
                        int Y = en.Position.Y;
                        e.Graphics.DrawImage( Wolf, X, Y - 20 );
                    }

                    if (en is Fox)
                    {
                        int X = en.Position.X;
                        int Y = en.Position.Y;
                        Bitmap imgDest = new Bitmap(50, 50);

                        e.Graphics.DrawImage( Fox, X, Y , imgDest.Width , imgDest.Height );
                    }

                    if (en is Hyena)
                    {
                        int X = en.Position.X;
                        int Y = en.Position.Y;
                        e.Graphics.DrawImage( Hyena, X, Y );
                    }

                    if (en is Lion)
                    {
                        int X = en.Position.X;
                        int Y = en.Position.Y;
                        e.Graphics.DrawImage( Lion, X, Y );
                    }

                    if (en is Cerberus)
                    {
                        int X = en.Position.X;
                        int Y = en.Position.Y;
                        e.Graphics.DrawImage( Cerberus, X, Y );
                    }

                    if (en is Anubis)
                    {
                        int X = en.Position.X;
                        int Y = en.Position.Y;
                        e.Graphics.DrawImage( Anubis, X, Y );
                    }
                }
            }
            base.OnPaint( e );
        }
    }
}
