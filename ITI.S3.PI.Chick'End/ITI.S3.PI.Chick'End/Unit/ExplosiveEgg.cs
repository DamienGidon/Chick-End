using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class ExplosiveEgg : Tower
    {
        public ExplosiveEgg(Square context)
            : base( context, 15 )
        {
            _health = 50;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            foreach( Ennemi e in Square.Context.Ennemis)
            {
                if( (e.Square == ennemi.Square)
                    || ((e.Square.Line == ennemi.Square.Line) && (e.Square.Column == ennemi.Square.Column + 1) )
                    || ((e.Square.Line == ennemi.Square.Line) && (e.Square.Column == ennemi.Square.Column - 1) )
                    || ((e.Square.Line == ennemi.Square.Line + 1) && (e.Square.Column == ennemi.Square.Column) )
                    || ((e.Square.Line == ennemi.Square.Line - 1) && (e.Square.Column == ennemi.Square.Column) ))
                {
                    ennemi.Health -= Damages;
                }
            }
        }

        public override List<Square> ComputeRange()
        {
            List<Square> range = new List<Square>();
            range.Add( Square );
            return range;
        }

        public override void CreateTower( int line, int column, Map map )
        {
            throw new NotImplementedException();
        }
    }
}
