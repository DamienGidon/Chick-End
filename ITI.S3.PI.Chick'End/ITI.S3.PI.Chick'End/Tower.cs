﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public abstract class Tower : Unit, IAssailant
    [Serializable]
    {
        protected readonly Square _square;
        internal readonly int _damages;
        protected readonly Square[] _range;

        protected Tower( Square context, int damages )
        {
            _square = context;
            _range = ComputeRange().ToArray();
            _damages = damages;
        }

        public Square Square
        {
            get { return _square; }
        }

        public int Damages
        {
            get { return _damages; }
        }

        public override Square Square
        {
            get { return _square; }
        }

        public override Point Position
        {
            get { return new Point( _square.Column * FinalVariables._squareWidthInMeters + FinalVariables._squareWidthInMeters / 2, _square.Line * FinalVariables._squareHeightInMeters + FinalVariables._squareHeightInMeters / 2 ); }
        }

        public IReadOnlyList<Square> Range
        {
            get { return _range; }
        }

        public Ennemi GetClosestEnnemiAttackable()
        {
            return this.GetClosestUnit( _square.Context.Ennemis );
            //return UnitExtension.GetClosestUnit( this, _square.Context.Ennemis );
            //return GetClosestUnit<Ennemi>( _square.Context.Ennemis );
        }

        public virtual List<Square> ComputeRange()
        {
            List<Square> squaresInRange = new List<Square>();
            int line = _square.Line;
            int column = _square.Column;

            for (int i = column; i < FinalVariables._nbCaseWidth; i++)
            {
                if (_square.Context.Square[line, i].Decoration == "path")
                    squaresInRange.Add( _square.Context.Square[line, i] );
                else
                    break;
            }

            for (int i = line + 1; i < FinalVariables._nbCaseHeight; i++)
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

        public virtual void Attack( Unit ennemi )
        {
            throw new NotImplementedException();
        }
    }
}
