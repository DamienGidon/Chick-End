using System;
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
            _health = 5000;
        }

        public override List<Square> ComputeRange()
        {
            return this.GetRange( Math.Max(Square.Context.NbCaseHeight, Square.Context.NbCaseWidth ) );
            //return this.GetRange( Square.Context.NbCaseWidth );
        }

        public override void Attack(Unit ennemi)
        {
            ennemi.Health -= Damages;
        }
    }
}
