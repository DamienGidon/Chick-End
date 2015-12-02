using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Wolf : Ennemi
    {
        public Wolf(Map context)
            : base(context)
        {
            Health = 50;
            Speed = 50;
        }

        public override void Attack( Unit opposant )
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
