using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace ITI.S3.PI.Chick_End.GUI
{
    public class ViewMapControler : Control
    {
        Game _context;

        public ViewMapControler()
        {
            _context = new Game();
            DoubleBuffered = true;
        }

        public Game Context
        {
            get { return _context; }
            set { _context = value; }
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            
            if (this.IsInDesignMode())
            {
                //e.Graphics.FillRectangle( Brushes.Yellow, e.ClipRectangle );
                BackColor = Color.Green;
            }
            else
            {
                string directory = Path.GetDirectoryName(Application.ExecutablePath);
                string pathGrass = Path.Combine(directory, @"grass.png");
                string pathPath = Path.Combine(directory, @"path.png");
                string pathHomeHen = Path.Combine(directory, @"HomeHen.png");
                string pathHen = Path.Combine(directory, @"HenLeft.png");
                string pathRooster = Path.Combine(directory, @"Rooster.png");
                string pathOldHen = Path.Combine(directory, @"OldHen.png");
                string pathExplosiveEgg = Path.Combine(directory, @"ExplosiveEgg.png");
                string pathBomberHen = Path.Combine(directory, @"BomberHen.png");
                string pathBaker = Path.Combine(directory, @"Baker.png");
                string pathButcher = Path.Combine(directory, @"Bucher.png");
                string pathgunnerFarmer = Path.Combine(directory, @"gunnerFarmer.png");
                string pathInfantryFarmer = Path.Combine(directory, @"InfantryFarmer.png");
                string pathWolf = Path.Combine(directory, @"Wolf.png");


                Image grass = Image.FromFile(pathGrass);
                Image path = Image.FromFile(pathPath);
                Image HomeHen = Image.FromFile(pathHomeHen);
                Image hen = Image.FromFile(pathHen);
                Image OldHen = Image.FromFile(pathOldHen);
                Image Rooster = Image.FromFile(pathRooster);
                Image BomberHen = Image.FromFile(pathBomberHen);
                Image ExplosiveEgg = Image.FromFile(pathExplosiveEgg);
                Image Baker = Image.FromFile(pathBaker);
                Image Butcher = Image.FromFile(pathButcher);
                Image gunnerFarmer = Image.FromFile(pathgunnerFarmer);
                Image InfantryFarmer = Image.FromFile(pathInfantryFarmer);
                Image Wolf = Image.FromFile(pathWolf);

                int CaseShouldBeThatHeight = e.ClipRectangle.Height / FinalVariables.NbCaseHeight;
                int CaseShouldBeThatWidth = e.ClipRectangle.Width / FinalVariables.NbCaseWidth;

                for (int i = 0; i < FinalVariables.NbCaseHeight; i++)
                {
                    for (int j = 0; j < FinalVariables.NbCaseWidth; j++)
                    {
                        if (_context.Map.Square[i, j].Decoration == "grass")
                        {
                            e.Graphics.DrawImage(grass, _context.Map.Square[i, j].Column * CaseShouldBeThatWidth, _context.Map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
                        }
                        else if (_context.Map.Square[i, j].Decoration == "path")
                        {
                            e.Graphics.DrawImage(path, _context.Map.Square[i, j].Column * CaseShouldBeThatWidth, _context.Map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
                        }
                        else if (_context.Map.Square[i, j].Decoration == "HomeHen")
                        {
                            e.Graphics.DrawImage(HomeHen, _context.Map.Square[i, j].Column * CaseShouldBeThatWidth, _context.Map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
                        }
                    }
                }
                for (int i = 0; i < FinalVariables.NbCaseHeight; i++)
                {
                    for (int j = 0; j < FinalVariables.NbCaseWidth; j++)
                    {
                        foreach (Tower t in Context.Map.Towers)
                        {
                            if (t is Hen)
                            {
                                e.Graphics.DrawImage(hen, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
                            }

                        }
                    }
                }

                // On affiche les poules
                for (int i = 0; i < FinalVariables.NbCaseHeight; i++)
                {
                    for (int j = 0; j < FinalVariables.NbCaseWidth; j++)
                    {
                        foreach (Tower t in Context.Map.Towers)
                        {
                            if (t is Hen)
                            {
                                e.Graphics.DrawImage(hen, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
                            }
                            else if (t is OldHen)
                            {
                                e.Graphics.DrawImage(OldHen, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
                            }
                            else if (t is BomberHen)
                            {
                                e.Graphics.DrawImage(BomberHen, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
                            }
                            else if (t is ExplosiveEgg)
                            {
                                e.Graphics.DrawImage(ExplosiveEgg, t.Square.Column * CaseShouldBeThatWidth + Convert.ToInt32(CaseShouldBeThatWidth * 0.2), t.Square.Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth - Convert.ToInt32(CaseShouldBeThatWidth * 0.3), CaseShouldBeThatHeight);
                            }
                            else if (t is Rooster)
                            {
                                e.Graphics.DrawImage(Rooster, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32(CaseShouldBeThatHeight * 0.1), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32((CaseShouldBeThatHeight * 0.1)));
                            }
                            else if (t is Bucher)
                            {
                                e.Graphics.DrawImage(Butcher, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32(CaseShouldBeThatHeight * 0.4), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32((CaseShouldBeThatHeight * 0.4)));
                            }
                            else if (t is Baker)
                            {
                                e.Graphics.DrawImage(Baker, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32(CaseShouldBeThatHeight * 0.4), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32((CaseShouldBeThatHeight * 0.4)));
                            }
                            else if (t is GunnerFarmer)
                            {
                                e.Graphics.DrawImage(gunnerFarmer, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32(CaseShouldBeThatHeight * 0.4), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32((CaseShouldBeThatHeight * 0.4)));
                            }
                            else if (t is InfantryFarmer)
                            {
                                e.Graphics.DrawImage(InfantryFarmer, t.Square.Column * CaseShouldBeThatWidth, t.Square.Line * CaseShouldBeThatHeight - Convert.ToInt32(CaseShouldBeThatHeight * 0.4), CaseShouldBeThatWidth, CaseShouldBeThatHeight + Convert.ToInt32((CaseShouldBeThatHeight * 0.4)));
                            }
                            
                        }
                    }
                }
                foreach(Ennemi en in Context.Map.Ennemis)
                {
                    if(en is Wolf)
                    {
                        
                        e.Graphics.DrawImage(Wolf, en.Position.X, en.Position.Y -20);
                    }
                }
            }
            base.OnPaint( e );
        } 
        
    }
}
