﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            _kind = "hen";
            _image = Image.FromFile("HenLeft.png");
            _passivImage = Image.FromFile("HenLeft.png");
            _attackImage = Image.FromFile("HenAttack.png");
        }

        public override List<Square> ComputeRange()
        {
            return this.GetRange( Math.Max( Square.Context.NbCaseHeight, Square.Context.NbCaseWidth ) );
        }

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % 20 == 0)
            {
                Context.Context.CreateNormalEgg(Square.Context, Square.Tower.Position.X, Square.Tower.Position.Y, 15);
            }
        }
    }
}
