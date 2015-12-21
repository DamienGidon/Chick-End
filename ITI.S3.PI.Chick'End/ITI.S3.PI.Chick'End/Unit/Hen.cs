﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Hen : Tower
    {
        public Hen(Square context)
            : base( context, 15 )
        {
            _health = 100;
        }

        public override List<Square> ComputeRange()
        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % 20 == 0)
            {
            return this.GetRange( Math.Max(Square.Context.NbCaseHeight, Square.Context.NbCaseWidth ) );
                ennemi.Health -= Damages;
            }
        }

        public override void Attack(Unit ennemi)
        {
            ennemi.Health -= Damages;
        }
    }
}
