using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ITI.S3.PI.Chick_End
{
    static class UnitExtension
    {
        public static T GetClosestUnit<TSource,T>( this TSource @this,  IEnumerable<T> all ) 
            where TSource : Unit, IAssailant
            where T : Unit
        {
            T closest = null;
            double minpyth = -1;
            foreach (var t in all.Where( item => @this.Range.Contains( item.Square ) ))
            {
                double a = Distance( @this.Position, t.Position );
                if (minpyth == -1)
                {
                    minpyth = a;
                    closest = t;
                }
                if (a < minpyth)
                {
                    minpyth = a;
                    closest = t;
                }
            }
            return closest;
        }

        static double Distance( Point p1, Point p2 )
        {
            int deltaX = p1.X - p2.X;
            int deltaY = p1.Y - p2.Y;
            return Math.Sqrt( deltaX * deltaX + deltaY * deltaY );
        }

        public static List<Square> GetRange(this Tower t, int rangeInSquare)
        {
            List<Square> squaresInRange = new List<Square>();
            int line = t.Square.Line;
            int column = t.Square.Column;

            for (int i = column; i <= column + rangeInSquare && i < t.Square.Context.NbCaseWidth; i++)
            {
                if (t.Square.Context.Square[line, i].Decoration == "path")
                    squaresInRange.Add( t.Square.Context.Square[line, i] );
                else
                    break;
            }

            for (int i = line + 1; i <= i + rangeInSquare && i < t.Square.Context.NbCaseHeight; i++)
            {
                if (t.Square.Context.Square[i, column].Decoration == "path")
                    squaresInRange.Add( t.Square.Context.Square[i, column] );
                else
                    break;
            }

            for (int i = line - 1; i >= 0 && i >= i - rangeInSquare; i--)
            {
                if (t.Square.Context.Square[i, column].Decoration == "path")
                    squaresInRange.Add( t.Square.Context.Square[i, column] );
                else
                    break;
            }
            return squaresInRange;
        }
    }
}
