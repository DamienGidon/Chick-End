using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    class Hyena : Ennemi
    {
        public Hyena( Map context )
            : base(context)
        {
            Health = 50;
            Speed = 50;
        }

        public override void Attack( Unit opponent )
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
