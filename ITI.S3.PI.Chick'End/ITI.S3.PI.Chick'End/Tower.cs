using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public abstract class Tower : Unit, IAssailant
    {
        protected readonly Square _square;
        internal readonly int _damages;
        protected readonly Square[] _range;
        protected readonly int _cost;
        public Square _context;

        protected Tower( Square context, int damages )
        {
            _context = context;
            _square = context;
            _range = ComputeRange().ToArray();
            _damages = damages;
        }

        public override Square Square
        {
            get { return _square; }
        }

        public int Damages
        {
            get { return _damages; }
        }
       
        public override Point Position
        {
            get { return new Point( _square.Column * FinalVariables.SquareWidthInMeters + FinalVariables.SquareWidthInMeters / 2, _square.Line * FinalVariables.SquareHeightInMeters + FinalVariables.SquareHeightInMeters / 2 ); }
        }

        public IReadOnlyList<Square> Range
        {
            get { return _range; }
        }

        public Enemy GetClosestEnemyAttackable()
        {
            return this.GetClosestUnit( _square.Context.Enemies );
        }

        public virtual List<Square> ComputeRange()
        {
            List<Square> squaresInRange = new List<Square>();
            int line = _square.Line;
            int column = _square.Column;

            for (int i = column; i < FinalVariables.NbCaseWidthMap1; i++)
            {
                if (_square.Context.Square[line, i].Decoration == "path")
                    squaresInRange.Add( _square.Context.Square[line, i] );
                else
                    break;
            }

            for (int i = line + 1; i < FinalVariables.NbCaseHeightMap1; i++)
            {
                if (_square.Context.Square[i, column].Decoration == "path")
                    squaresInRange.Add( _square.Context.Square[i, column] );
                else
                    break;
            }

            for (int i = line - 1; i >= 0; i--)
            {
                if (_square.Context.Square[i, column].Decoration == "path")
                    squaresInRange.Add( _square.Context.Square[i, column] );
                else
                    break;
            }

            return squaresInRange;
        }

        public abstract void Attack(Unit ennemi, int tick);

        public override void Die()
        {
            _square.Context.Towers.Remove( this );
            _square.Tower = null;
        }

        public Square Context
        {
            get { return _context; }
        }
    }
}
