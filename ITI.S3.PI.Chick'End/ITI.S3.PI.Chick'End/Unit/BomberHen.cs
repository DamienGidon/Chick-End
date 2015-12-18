using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class BomberHen : Tower
    {
        public BomberHen( Square context )
            : base( context, 30 )
        {
            _health = 50;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % 60 == 0)
            {
                ennemi.Health -= Damages;
            }
        }

        //public override List<Square> GetRange()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
