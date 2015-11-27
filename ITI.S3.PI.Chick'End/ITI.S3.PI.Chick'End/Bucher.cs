using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    class Bucher : Tower
    {
        internal Bucher()
            : base(10, 15)
        {
            _health = 50;
        }

        public override void Attack(Unit ennemi)
        {
            ennemi.Health -= Damages;
        }
        
        /*
        public override void Remove()
        {

        }
        */
    }
}
