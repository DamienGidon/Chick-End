using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public abstract class Ennemi : Unit, IAssailant, IMove
    {
        protected Way _way;
        protected int _x;
        protected int _y;
        protected int _speed;
        protected readonly int _damages;
        protected readonly List<Square> _range;
        public Map _context;

        protected static Random _r = new Random();

        public Ennemi( Map context )
        {
            _context = context;
            int numberOfWays = _context.Ways.Count();
            _way = _context.Ways[_r.Next( numberOfWays )];
            _x = _way.FirstSquare.Column * 50 + 30;
            _y = _way.FirstSquare.Line * 50 + 30;
            _range = new List<Square>();
        }

        public Map Context
        {
            get { return _context; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int Damages
        {
            get { return _damages; }
        }

        public override Point Position
        {
            get { return new Point( _x, _y ); }
        }

        public virtual void Move()
        {
            if (_way.Current.Column == _way.Next.Column + 1)
            {
                _x -= FinalVariables._squareWidthInMeters / 8;
                if (_x <= _way.Next.Column * FinalVariables._squareWidthInMeters)
                {
                    _way.NextSquare();
                }
            }
            else if (_way.Current.Line == _way.Next.Line + 1)
            {
                _y -= FinalVariables._squareHeightInMeters / 8;
                if (_y <= _way.Next.Line * FinalVariables._squareHeightInMeters)
                {
                    _way.NextSquare();
                }
            }
            else if (_way.Current.Line == _way.Next.Line - 1)
            {
                _y += FinalVariables._squareHeightInMeters / 8;
                if (_y >= _way.Next.Line * FinalVariables._squareHeightInMeters)
                {
                    _way.NextSquare();
                }
            }

        }

        public override Square Square
        {
            get
            {
                int line = _y / FinalVariables._nbCaseHeight;
                int column = _x / FinalVariables._nbCaseWidth;

                return _context.Square[line, column];
            }
        }

        public IReadOnlyList<Square> Range
        {
            get { return _range; }
        }

        public Tower GetClosestTowerAttackable()
        {
            return this.GetClosestUnit( _context.Towers );
        }

        public virtual void Attack( Unit ennemi )
        {
            Tower closest = GetClosestTowerAttackable();
            if (closest != null)
                closest.Health -= _damages;
        }

        public List<Square> ComputeRange()
        {
            List<Square> squaresInRange = new List<Square>();
            int line = Square.Line;
            int column = Square.Column;

            if (Square.Context.Square[line, column - 1].Decoration == "path")
                squaresInRange.Add( Square.Context.Square[line, column - 1] );
            if (Square.Context.Square[line - 1, column].Decoration == "path")
                squaresInRange.Add( Square.Context.Square[line - 1, column] );
            if (Square.Context.Square[line + 1, column].Decoration == "path")
                squaresInRange.Add( Square.Context.Square[line + 1, column] );

            return squaresInRange;
        }
    }
}