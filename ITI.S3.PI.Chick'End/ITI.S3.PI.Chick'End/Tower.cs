using System;
using System.Collections.Generic;
using System.Drawing;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public abstract class Tower : Unit, IAssailant
    {
        protected readonly Square _square;
        internal readonly int _damages;
        protected readonly Square[] _range;
        public Square _context;

        protected Tower( Square context, int damages )
        {
            _context = context;
            _square = context;
            _range = ComputeRange().ToArray();
            _damages = damages;
        }

        // Properties
        public Square Context
        {
            get { return _context; }
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
            return this.GetRange( Math.Max( Square.Context.NbCaseHeight, Square.Context.NbCaseWidth ) );
        }

        public abstract void Attack(Unit ennemi, int tick);

        public override void Die()
        {
            _square.Context.Towers.Remove( this );
            _square.Tower = null;
        }

    }
}
