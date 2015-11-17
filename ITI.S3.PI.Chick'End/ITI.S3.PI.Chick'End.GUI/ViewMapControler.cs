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

                Image grass = Image.FromFile( pathGrass );
                Image path = Image.FromFile( pathPath );

                for (int i = 0; i < FinalVariables._nbCaseHeight; i++)
                {
                    for (int j = 0; j < FinalVariables._nbCaseWidth; j++)
                    {
                        if (_context.Map.Square[i, j].Decoration == "grass")
                        {
                            e.Graphics.DrawImage( grass, _context.Map.Square[i, j].Column * FinalVariables._squareWidthInMeters, _context.Map.Square[i, j].Line * FinalVariables._squareWidthInMeters, FinalVariables._squareWidthInMeters, FinalVariables._squareWidthInMeters );
                        }
                        else if (_context.Map.Square[i, j].Decoration == "path")
                        {
                            e.Graphics.DrawImage( path, _context.Map.Square[i, j].Column * FinalVariables._squareWidthInMeters, _context.Map.Square[i, j].Line * FinalVariables._squareWidthInMeters, FinalVariables._squareWidthInMeters, FinalVariables._squareWidthInMeters );
                        }
                    }
                }
            }

            base.OnPaint( e );
        }
    }
}
