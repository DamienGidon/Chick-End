using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class BomberHen : Tower
    {
        public BomberHen( Square context )
            : base( context, 30 )
        {
            _health = 50;
            _kind = "hen";
            _image = Image.FromFile("BomberHen.png");
            _passivImage = Image.FromFile("BomberHen.png");
            _attackImage = Image.FromFile("BomberHen.png");
        }

        /// <summary>
        /// For now, Bomber Hens attack every enemy which is on the square of the closest enemy attackable.
        /// </summary>
        public override void Attack( Unit ennemi, int tick )
        {
            if (tick % 60 == 0)
            /// <param name="ennemi"></param>
            {
                foreach (Ennemi e in Square.Context.Ennemis)
                {
                    if ((e.Square == ennemi.Square)
                        || ((e.Square.Line == ennemi.Square.Line) && (e.Square.Column == ennemi.Square.Column + 1))
                        || ((e.Square.Line == ennemi.Square.Line + 1) && (e.Square.Column == ennemi.Square.Column))
                        || ((e.Square.Line == ennemi.Square.Line - 1) && (e.Square.Column == ennemi.Square.Column)))
                    {
                        e.Health -= Damages;
                    }
                }
            }
        }

        public override List<Square> ComputeRange()
        {
            return this.GetRange( 4 );
            //List<Square> squaresInRange = new List<Square>();
            //int line = _square.Line;
            //int column = _square.Column;

            //for (int i = column; i < column + 5; i++)
            //{
            //    if (_square.Context.Square[line, i].Decoration == "path")
            //        squaresInRange.Add( _square.Context.Square[line, i] );
            //    else
            //        break;
            //}

            //for (int i = line + 1; i < i+ 4; i++)
            //{
            //    if (_square.Context.Square[i, column].Decoration == "path")
            //        squaresInRange.Add( _square.Context.Square[i, column] );
            //    else
            //        break;
            //}

            //for (int i = line - 1; i >= 0 || i > i - 4; i--)
            //{
            //    if (_square.Context.Square[i, column].Decoration == "path")
            //        squaresInRange.Add( _square.Context.Square[i, column] );
            //    else
            //        break;
            //}
            //return squaresInRange;
        }
    }
}
