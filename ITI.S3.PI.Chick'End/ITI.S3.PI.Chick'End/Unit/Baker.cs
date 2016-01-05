using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Baker : Tower
    {
        internal Baker(Square context)
            : base( context, 0 )
        {
            _health = 500;
        }

        public override void CreateTower( int line, int column, Map map )
        {
            Tower t = new Baker(Square.Context.Square[line, column] );
            Square.Context.Square[line, column].Tower = t;
            Square.Context.Towers.Add( t );
        }

        public override void Attack(Unit ennemi, int tick)
        {
            
        }

        //public override List<Square> GetRange()
        //{
        //    throw new NotImplementedException();
        //}

        /*
        public override void Remove()
        {

        }
        */
    }
}
