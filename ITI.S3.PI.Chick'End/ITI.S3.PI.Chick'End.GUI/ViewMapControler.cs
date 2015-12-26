﻿using System;
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
                BackColor = Color.Green;
            }
            else
            {
                string directory = Path.GetDirectoryName( Application.ExecutablePath );
                string pathGrass = Path.Combine( directory, @"grass.png" );
                string pathPath = Path.Combine( directory, @"path.png" );
                string pathHomeHen = Path.Combine( directory, @"HomeHen.png" );
                string pathExplosiveEgg = Path.Combine( directory, @"ExplosiveEgg.png" );

                Image grass = Image.FromFile( pathGrass );
                Image path = Image.FromFile( pathPath );
                Image HomeHen = Image.FromFile( pathHomeHen );
                Image ExplosiveEgg = Image.FromFile( pathExplosiveEgg );


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
                foreach (Tower t in Map.Towers)
                {
                    if(t.Kind == "hen")
                    {
                        e.Graphics.DrawImage(t.UnitImage, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
                    }
                    else if (t is ExplosiveEgg)
                    {
                        e.Graphics.DrawImage(ExplosiveEgg, t.Square.Column * CaseShouldBeThatWidth + Convert.ToInt32(CaseShouldBeThatWidth * 0.2), t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth - Convert.ToInt32(CaseShouldBeThatWidth * 0.3), CaseShouldBeThatHeight);
                    }
                    else if (t.Kind == "human")
                    {
                        e.Graphics.DrawImage(t.UnitImage, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32(CaseShouldBeThatHeight * 0.4), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32((CaseShouldBeThatHeight * 0.4)));
                    }
                }

                //On affiche les ennemis
                foreach (Ennemi en in Map.Ennemis)
                {
                    int x = en.Position.X;
                    int y = en.Position.Y;

                    e.Graphics.DrawImage(en.UnitImage, x, y, en.ImageWidth, en.ImageHeight);
                }

                // On affiche les oeufs
                foreach(EggLauncher eg in Map.Eggs)
                {
                    int x = eg.Position.X;
                    int y = eg.Position.Y;

                    e.Graphics.DrawImage(eg.UnitImage, x, y, eg.ImageWidth, eg.ImageHeight);
                }
            }
            base.OnPaint( e );
        }
    }
}