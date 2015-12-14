using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class BomberHen : Tower
    {
        public BomberHen( Square context )
            : base( context, 15 )
        {
            _health = 50;
        }

        /// <summary>
        /// For now, Bomber Hens attack every enemy which is on the square of the closest enemy attackable.
        /// </summary>
        /// <param name="ennemi"></param>
        public override void Attack(Unit ennemi)
        {
            foreach( Ennemi e in Square.Context.Ennemis)
            {
                if ( ( e.Square == ennemi.Square) || (e.Square.Line == ennemi.Square.Line) && ( e.Square.Column == ennemi.Square.Column + 1 ) 
                     || ( e.Square.Line == ennemi.Square.Line + 1 ) && ( e.Square.Column == ennemi.Square.Column )
                    || ( e.Square.Line == ennemi.Square.Line - 1 ) && ( e.Square.Column == ennemi.Square.Column) )
                {
                    e.Health -= Damages;
                }
            }
        }

        public override List<Square> ComputeRange()
        {
            List<Square> squaresInRange = new List<Square>();
            int line = _square.Line;
            int column = _square.Column;

            for (int i = column; i < column + 5; i++)
            {
                if (_square.Context.Square[line, i].Decoration == "path")
                    squaresInRange.Add( _square.Context.Square[line, i] );
                else
                    break;
            }

            for (int i = line + 1; i < i+ 4; i++)
            {
                if (_square.Context.Square[i, column].Decoration == "path")
                    squaresInRange.Add( _square.Context.Square[i, column] );
                else
                    break;
            }

            for (int i = line - 1; i >= 0 || i > i - 4; i--)
            {
                if (_square.Context.Square[i, column].Decoration == "path")
                    squaresInRange.Add( _square.Context.Square[i, column] );
                else
                    break;
            }
            return squaresInRange;
        }
    }
}
