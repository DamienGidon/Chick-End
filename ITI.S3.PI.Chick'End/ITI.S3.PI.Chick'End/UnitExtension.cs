using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
