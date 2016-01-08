using System;
using System.Collections.Generic;
using System.Drawing;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class EggLauncher : Unit, IAssailant, IMove
    {
        Map _context;
        protected Way _way;
        protected int _x;
        protected int _y;
        protected List<Square> _range;
        internal readonly int _damages;

        public EggLauncher(Map context, int damage, int x, int y)
        {
            _x = x;
            _y = y;
            _damages = damage;
            _context = context;
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

        public Enemy GetClosestEnemyAttackable()
        {
            return this.GetClosestUnit(_context.Enemies);
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

        public virtual void Attack(Unit enemy, int tick)
        {
            enemy.Health -= Damages;
        }
    }
}
