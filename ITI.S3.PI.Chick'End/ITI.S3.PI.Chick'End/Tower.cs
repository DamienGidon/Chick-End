using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    abstract class Tower : Placeable, IAttack
    {
        internal readonly int _damages;
        internal readonly float _range;

        protected Tower(int damages, int range)
        {
            _damages = damages;
            _range = range;
        }

        internal int Damages
        {
            get { return _damages; }
        }

        internal float Range
        {
            get { return _range; }
        }

        public abstract void Attack(Ennemi ennemi);
    }
}
