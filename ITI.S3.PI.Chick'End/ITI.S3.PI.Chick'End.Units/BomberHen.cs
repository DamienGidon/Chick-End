using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End.Units
{
    public class BomberHen : Tower
    {
        public BomberHen(Square context)
            : base( context, 15 )
        {
            Health = 50;
        }

        public override void Attack( Unit ennemi )
        {
            throw new NotImplementedException();
        }

        public override List<Square> GetRange()
        {
            throw new NotImplementedException();
        }
    }
}
