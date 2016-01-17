using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public abstract class Enemy : Unit, IAssailant, IMove
    {
        protected Way _way;
        protected int _x;
        protected int _y;
        protected int _speed;
        protected int _damages;
        protected List<Square> _range;
        public Map _context;
        bool _alreadySlow = false;

        protected static Random _r = new Random();

        public Enemy( Map context, int damages )
        {
            _context = context;
            _damages = damages;
            int numberOfWays = _context.Ways.Count();
            _way = _context.CreateWay( _context.Ways[_r.Next( numberOfWays )]);
            _x = _way.FirstSquare.Column * FinalVariables.SquareWidthInMeters + FinalVariables.SquareWidthInMeters - 1;
            _y = _way.FirstSquare.Line * FinalVariables.SquareHeightInMeters;
            _range = ComputeRange();
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public bool AlreadySlow
        {
            get { return _alreadySlow; }
            set { _alreadySlow = value; }
        }


        public Map Context
        {
            get { return _context; }
        }
        public Way Way
        {
            get { return _way; }
        }
        public int Damages
        {
            get { return _damages; }
            set { _damages = value; }
        }
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public override Point Position
        {
            get { return new Point( _x, _y ); }
        }

        public virtual void Move()
        {
            if (_way.Current.Column == _way.Next.Column + 1)
            {
                _x -= FinalVariables.SquareWidthInMeters / Speed;
                if (_x <= _way.Next.Column * FinalVariables.SquareWidthInMeters)
                {
                    _way.NextSquare();
                }
            }
            else if (_way.Current.Line == _way.Next.Line + 1)
            {
                _y -= FinalVariables.SquareHeightInMeters / Speed;
                if (_y <= _way.Next.Line * FinalVariables.SquareHeightInMeters)
                {
                    _way.NextSquare();
                }
            }
            else if (_way.Current.Line == _way.Next.Line - 1)
            {
                _y += FinalVariables.SquareHeightInMeters / Speed;
                if (_y >= _way.Next.Line * FinalVariables.SquareHeightInMeters)
                {
                    _way.NextSquare();
                }
            }
            _range = ComputeRange();
        }

        public override Square Square
        {
            get
            {
                int line = _y / FinalVariables.SquareHeightInMeters;
                int column = _x / FinalVariables.SquareWidthInMeters;

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

        public virtual void Attack( Unit tower, int tick )
        {
            if (tick % _attackSpeed == 0)
            {
                tower.Health -= Damages;
            }
        }

        public List<Square> ComputeRange()
        {
            List<Square> squaresInRange = new List<Square>();
            squaresInRange.Add( Square );

            return squaresInRange;
        }

        public override void Die()
        {
            _context.Enemies.Remove( this );
        }
    }
}