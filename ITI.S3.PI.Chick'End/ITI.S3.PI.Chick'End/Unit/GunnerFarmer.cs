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
            : base( context, 15 )
        {
            _health = 50;
            _kind = "human";
            _image = Image.FromFile("GunnerFarmer.png");
            _passivImage = Image.FromFile("GunnerFarmer.png");
            _attackImage = Image.FromFile("GunnerFarmer.png");
        }

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % 20 == 0)
            {
                ennemi.Health -= Damages;
            }
        }

        public override List<Square> ComputeRange()
        {
            return this.GetRange( 6 );
        }
    }
}
