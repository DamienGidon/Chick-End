using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End.Units
{
    public class BomberHen : Tower
    {
        public BomberHen()
            : base(10, 15)
        {

        }

        public override void Attack( Unit ennemi )
        {
            throw new NotImplementedException();
        }
    }
}
