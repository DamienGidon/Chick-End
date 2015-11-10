using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public abstract class Ennemi : Unit, IAttack, IMove
    {
        int _speed;
        readonly int _damages;
        readonly float _range;

        public abstract void Attack(Ennemi opposant);

        public abstract void Move();
    }
}
