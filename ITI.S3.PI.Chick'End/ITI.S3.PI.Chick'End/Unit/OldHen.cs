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

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % 20 == 0)
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

        public override List<Square> ComputeRange()
        {
            return this.GetRange(Square.Context.NbCaseWidth);
        }

        public override void CreateTower( int line, int column, Map map )
        {
            throw new NotImplementedException();
        }
    }
}
