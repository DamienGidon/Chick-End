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
            _attackSpeed = 60;
            _health = 50;
            _kind = "hen";
            _passivImage = Image.FromFile("BomberHen.png");
            _attackImage = Image.FromFile("BomberHenAttack.png");
            _image = _passivImage;
        }

        /// <summary>
        /// For now, Bomber Hens attack every enemy which is on the square of the closest enemy attackable.
        /// </summary>
        public override void Attack( Unit ennemi, int tick )
        {
            if (tick % _attackSpeed == 0)
            /// <param name="ennemi"></param>
            {
                Context.Context.CreateRobotEgg(Square.Context, Square.Tower.Position.X, Square.Tower.Position.Y, 15);
            }
        }

        public override List<Square> ComputeRange()
        {
            return this.GetRange( 6 );
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
