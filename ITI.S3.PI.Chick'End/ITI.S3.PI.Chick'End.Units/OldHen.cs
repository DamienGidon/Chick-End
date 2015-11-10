using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.S3.PI.Chick_End;

namespace ITI.S3.PI.Chick_End.Units
{
    internal class OldHen : Tower
    {
        internal OldHen()
            : base(10, 15)
        {
            Health = 50;
        }

        public override void Attack(Ennemi ennemi)
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
