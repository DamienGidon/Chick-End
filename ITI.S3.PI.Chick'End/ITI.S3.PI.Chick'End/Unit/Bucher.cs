using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Bucher : Tower
    {
        internal Bucher(Square context)
            : base( context, 15 )
        {
            _health = 50;
        }

        public override void Attack(Unit ennemi)
        {
            ennemi.Health -= Damages;
        }

        //public override List<Square> GetRange()
        //{
        //    throw new NotImplementedException();
        //}

        /*
        public override void Remove()
        {

        }
        */
    }
}
