using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Wolf : Ennemi
    {
        public Wolf(Map context, int damages)
            : base(context, damages)
        {
            Health = 100;
            Speed = 20;
        }

        //public override void Attack( Unit opposant )
        //{
        //    throw new NotImplementedException();
        //}

        //public override void Move()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
