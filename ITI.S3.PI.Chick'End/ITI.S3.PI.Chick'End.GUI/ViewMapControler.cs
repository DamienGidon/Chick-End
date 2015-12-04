﻿using System;
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
                BackColor = Color.Cyan;
            }
            else
            {
                string directory = Path.GetDirectoryName( Application.ExecutablePath );
                string pathGrass = Path.Combine( directory, @"grass.png" );
                string pathPath = Path.Combine( directory, @"path.png" );
                string pathHomeHen = Path.Combine(directory, @"HomeHen.png");
                string pathHen = Path.Combine(directory, @"HenLeft.png");

                Image grass = Image.FromFile( pathGrass );
                Image path = Image.FromFile( pathPath );
                Image HomeHen = Image.FromFile(pathHomeHen);
                Image hen = Image.FromFile(pathHen);

                int CaseShouldBeThatHeight;
                int CaseShouldBeThatWidth;

                CaseShouldBeThatHeight = e.ClipRectangle.Height / FinalVariables.NbCaseHeight;
                CaseShouldBeThatWidth = e.ClipRectangle.Width / FinalVariables.NbCaseWidth;

                for (int i = 0; i < FinalVariables.NbCaseHeight; i++)
                {
                    for (int j = 0; j < FinalVariables.NbCaseWidth; j++)
                    {
                        if (_context.Map.Square[i, j].Decoration == "grass")
                        {
                            e.Graphics.DrawImage( grass, _context.Map.Square[i, j].Column * CaseShouldBeThatWidth, _context.Map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
                        }
                        else if (_context.Map.Square[i, j].Decoration == "path")
                        {
                            e.Graphics.DrawImage( path, _context.Map.Square[i, j].Column * CaseShouldBeThatWidth, _context.Map.Square[i, j].Line * CaseShouldBeThatHeight, CaseShouldBeThatWidth, CaseShouldBeThatHeight);
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
            }

            base.OnPaint( e );
        } 
    }
}
