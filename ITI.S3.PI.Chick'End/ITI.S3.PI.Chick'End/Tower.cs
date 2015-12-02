using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public abstract class Tower : Unit, IAssailant, IRemove
    {
        protected readonly Square _square;
        internal readonly int _damages;
        protected List<Square> _range;

        protected Tower(Square context, int damages)
        {
            _square = context;
            _range = GetRange();
            _damages = damages;
            
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
            List<Ennemi> test = new List<Ennemi>();

            int thisX = _square.Column * FinalVariables._squareWidthInMeters + FinalVariables._squareWidthInMeters / 2;
            int thisY = _square.Line * FinalVariables._squareHeightInMeters + FinalVariables._squareHeightInMeters / 2;


            test = _square.Context.Ennemis.Where(e => _range.Contains(e.Position)).ToList();
            double minpyth = -1;
            foreach (var en in test)
            {
                double a = pyth(Math.Max(thisX, en.X)-Math.Min(thisX, en.X), Math.Max(thisY, en.Y) - Math.Min(thisY, en.Y));
                if (minpyth == -1)
                {
                    minpyth = a;
                    closestEnnemi = en;
                }
                if (a < minpyth)
                {
                    minpyth = a;
                    closestEnnemi = en;
                }
            }
            

            return closestEnnemi;
        }

        public virtual void Attack( Unit ennemi )
        {
            Ennemi closest = GetClosestEnnemiAttackable();
            if( closest != null )
                closest.Health -= _damages;
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
        public double pyth(int diffX, int diffY)
        {
            return (Math.Sqrt(diffX * diffX + diffY * diffY));
        }
}
}
