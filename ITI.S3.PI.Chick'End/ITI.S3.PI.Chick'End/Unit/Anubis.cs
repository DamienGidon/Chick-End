using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Anubis : Ennemi
    {
        public Anubis( Map context, int damages )
            : base(context, damages)
        {
            Health = 500;
            Speed = 50;
        }

        public void Summon(int tick)
        {
            if (tick % 20 == 0)
            {
                Context.CreateWolf(Square.Context);
            }
        }

        //public override void Attack( Unit opponent )
        //{
        //    throw new NotImplementedException();
        //}

        //public override void Move()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
