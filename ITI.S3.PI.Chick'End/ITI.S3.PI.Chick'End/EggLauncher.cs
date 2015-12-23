using System;
using System.Collections.Generic;
using System.Drawing;

namespace ITI.S3.PI.Chick_End
{
    public class EggLauncher : Unit, IAssailant, IMove
    {
        Map _context;
        protected Way _way;
        protected int _x;
        protected int _y;
        protected List<Square> _range;
        internal readonly int _damages;

        public EggLauncher(Map context, int damage)
        {
            _damages = damage;
            _context = context;
            _range = ComputeRange();
        }

        public int GetX
        {
            get { return _x; }
            set { _x = value; }
        }

        public int GetY
        {
            get { return _y; }
            set { _y = value; }
        }

        public override Point Position
        {
            get { return new Point(_x, _y); }
        }

        public Map Context
        {
            get { return _context; }
        }

        public Way Way
        {
            get { return _way; }
        }

        public virtual void Move()
        {
            _x = _x + 30;
            //if (_way.Current.Column == _way.Next.Column + 1)
            //{
            //    _x -= FinalVariables.SquareWidthInMeters / 30;
            //    if (_x <= _way.Next.Column * FinalVariables.SquareWidthInMeters)
            //    {
            //        _way.NextSquare();
            //    }
            //}
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
            set { _range = ComputeRange(); }
        }

        public Ennemi GetClosestEnnemiAttackable()
        {
            return this.GetClosestUnit(_context.Ennemis);
        }

        public List<Square> ComputeRange()
        {
            List<Square> squaresInRange = new List<Square>();
            squaresInRange.Add(Square);

            return squaresInRange;
        }

        public override void Die()
        {
            _context.Eggs.Remove( this );
        }

        public int Damages
        {
            get { return _damages; }
        }

        public void Attack(Unit ennemi, int tick)
        {
            ennemi.Health -= Damages;
        }
    }
}
