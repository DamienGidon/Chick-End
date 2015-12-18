using System;
using System.Collections.Generic;
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
            _health = 5000;
        }

        public override void Attack(Unit ennemi)
        {
            Ennemi _ennemi = (Ennemi) ennemi;
            ennemi.Health -= Damages;
            if (_ennemi.AlreadySlow == false)
            {
                _ennemi.Speed = _ennemi.Speed *2;
                _ennemi.AlreadySlow = true;
            }
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
