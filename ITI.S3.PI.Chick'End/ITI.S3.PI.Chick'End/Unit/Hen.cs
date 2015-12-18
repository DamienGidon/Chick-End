using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Hen : Tower
    {
        public Hen(Square context)
            : base( context, 15 )
        {
            _health = 100;
        }

        //public override List<Square> ComputeRange()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % 20 == 0)
            {
                ennemi.Health -= Damages;
            }
        }
        
        /*
        public override void Remove()
        {

        }
        */
    }
}
