﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End.Units
{
    class BomberHen : Tower
    {
        public BomberHen()
            : base(10, 15)
        {

        }

        public override void Attack( Ennemi ennemi )
        {
            throw new NotImplementedException();
        }
    }
}
