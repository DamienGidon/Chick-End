using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public abstract class Tower : Unit, IAssailant, IRemove
    {
        protected Square _square;
        internal readonly int _damages;
        protected List<Square> _range;

        protected Tower(int damages)
        {
            _damages = damages;
            _range = GetRange();
        }

        public int Damages
        {
            get { return _damages; }
        }

        internal List<Square> Range
        {
            get { return _range; }
        }

        public virtual Ennemi GetClosestEnnemiAttackable()
        {
            Ennemi closestEnnemi = null;
            int xClosestEnnemi = FinalVariables._squareWidthInMeters * FinalVariables._nbCaseWidth + FinalVariables._squareWidthInMeters - 1;
            int yClosestEnnemi = FinalVariables._squareWidthInMeters * FinalVariables._nbCaseHeight + FinalVariables._squareWidthInMeters - 1;

            foreach( Ennemi e in _square.Context.Ennemis )
            {
                foreach( Square q in _range)
                {
                    if( e.X / 50 == q.Column && e.X < xClosestEnnemi && e.Y < yClosestEnnemi)
                    {
                        xClosestEnnemi = e.X - _square.Column * FinalVariables._squareWidthInMeters;
                        if (e.Y / 50 > _square.Line)
                            yClosestEnnemi = e.Y - _square.Line * FinalVariables._squareWidthInMeters;
                        else if (e.Y / 50 < _square.Line)
                            yClosestEnnemi = _square.Line * FinalVariables._squareWidthInMeters - e.Y;
                        closestEnnemi = e;
                    }
                }
            }

            return closestEnnemi;
        }

        public virtual void Attack( Unit ennemi )
        {

        }

        public virtual void Remove()
        {
            throw new NotImplementedException();
        }

        public virtual List<Square> GetRange()
        {
            List<Square> squaresInRange = new List<Square>();
            int line = _square.Line;
            int column = _square.Column;

            for( int i = column; i < FinalVariables._nbCaseWidth; i++ )
            {
                if (_square.Context.Square[line, i].Decoration == "path")
                    squaresInRange.Add( _square.Context.Square[line, i] );
                else
                    break;
            }

            for( int i = line + 1; i < FinalVariables._nbCaseHeight; i++)
            {
                if (_square.Context.Square[i, column].Decoration == "path")
                    squaresInRange.Add( _square.Context.Square[i, column] );
                else
                    break;
            }

            for( int i = line - 1; i >= 0; i--)
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
