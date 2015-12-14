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

        public override void Attack(Unit ennemi)
        {
            ennemi.Health -= Damages;
        }

        public override List<Square> ComputeRange()
        {
            List<Square> range = new List<Square>();
            range.Add( Square );
            return range;
        }

        /*
        public override void Remove()
        {

        }
        */
    }
}
