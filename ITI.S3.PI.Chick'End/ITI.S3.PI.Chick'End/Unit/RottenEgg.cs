using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class RottenEgg : EggLauncher
    {

        public RottenEgg(Map context, int damage, int x, int y)
            : base(context, damage, x, y)
        {

        }

        public override void Attack(Unit ennemi, int tick)
        {
            Ennemi _ennemi = (Ennemi)ennemi;
            ennemi.Health -= Damages;
            if (_ennemi.AlreadySlow == false)
            {
                _ennemi.Speed = _ennemi.Speed * 2;
                _ennemi.AlreadySlow = true;
            }
        }
    }
}
