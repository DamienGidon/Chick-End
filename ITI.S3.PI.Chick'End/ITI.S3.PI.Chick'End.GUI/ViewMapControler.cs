using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    public class ViewMapControler : Panel
    {
        Game _context;

        public void Draw( Graphics g )
        {
            Image grass = Image.FromFile( ".\\Images\\Grass.png" );
            Image path = Image.FromFile( ".\\Images\\Path.png" );

            for (int i = 0; i < FinalVariables._nbCaseHeight; i++)
            {
                for (int j = 0; j < FinalVariables._nbCaseWidth; j++)
                {
                    if (_context.Map.Square[i, j].Decoration == "grass")
                    {
                        g.DrawImage( grass, _context.Map.Square[i, j].Line * FinalVariables._squareWidthInMeters, _context.Map.Square[i, j].Column * FinalVariables._squareWidthInMeters, FinalVariables._squareWidthInMeters, FinalVariables._squareWidthInMeters );
                    }
                    else if (_context.Map.Square[i, j].Decoration == "path")
                    {
                        g.DrawImage( path, _context.Map.Square[i, j].Line * FinalVariables._squareWidthInMeters, _context.Map.Square[i, j].Column * FinalVariables._squareWidthInMeters, FinalVariables._squareWidthInMeters, FinalVariables._squareWidthInMeters );
                    }
                }
            }
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            //Graphics g = new Graphics
            base.OnPaint( e );
            
        }
    }
}
