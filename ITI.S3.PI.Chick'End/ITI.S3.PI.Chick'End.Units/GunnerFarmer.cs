using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End.Units
{
    class GunnerFarmer : Tower
    {
        internal GunnerFarmer(Square context)
            : base( 15 )
        {
            this.Health = 50;
            _square = context;
        }

        public override void Attack(Unit ennemi)
        {
            ennemi.Health -= Damages;
        }

        public override List<Square> GetRange()
        {
            throw new NotImplementedException();
        }

        /*
        public override void Remove()
        {
            
        }
        */
    }
}
