using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class GunnerFarmer : Tower
    {
        public GunnerFarmer(Square context)
            : base( context, 200 )
        {
            _attackSpeed = 20;
            _health = 50;
            _kind = "human";
            _passivImage = Image.FromFile("GunnerFarmer.png");
            _attackImage = Image.FromFile("GunnerFarmerAttack.png");
            _image = _passivImage;
        }

        public override List<Square> ComputeRange()
        {
            return this.GetRange(Math.Max(Square.Context.NbCaseHeight, Square.Context.NbCaseWidth));
        }

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % _attackSpeed == 0)
            {
                Context.Context.CreateBullet(Square.Context, Square.Tower.Position.X, Square.Tower.Position.Y, 30);
            }
        }
    }
}
