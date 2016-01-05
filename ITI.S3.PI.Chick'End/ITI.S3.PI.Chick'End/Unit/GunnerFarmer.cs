using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class GunnerFarmer : Tower
    {
        public GunnerFarmer(Square context)
            : base( context, 15 )
        {
            _health = 50;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % 20 == 0)
            {
                ennemi.Health -= Damages;
            }
        }

        public override List<Square> ComputeRange()
        {
            return this.GetRange( 6 );
        }

        public override void CreateTower( int line, int column, Map map )
        {
            throw new NotImplementedException();
        }
    }
}
