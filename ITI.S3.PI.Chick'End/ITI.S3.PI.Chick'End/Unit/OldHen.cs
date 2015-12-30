﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class OldHen : Tower
    {
        internal OldHen( Square context )
            : base( context, 10 )
        {
            _health = 100;
            _kind = "hen";
            _image = Image.FromFile("OldHen.png");
            _passivImage = Image.FromFile("OldHen.png");
            _attackImage = Image.FromFile("OldHenAttack.png");
        }

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % 20 == 0)
            {
                Context.Context.CreateRottenEgg(Square.Context, Square.Tower.Position.X, Square.Tower.Position.Y, 10);
            }
        }

        public override List<Square> ComputeRange()
        {
            return this.GetRange(Square.Context.NbCaseWidth);
        }
    }
}
