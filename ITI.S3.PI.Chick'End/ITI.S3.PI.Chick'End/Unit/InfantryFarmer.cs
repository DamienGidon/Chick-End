using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class InfantryFarmer : Tower
    {
        internal InfantryFarmer( Square context )
            : base( context, 50 )
        {
            _attackSpeed = 20;
            _health = 100;
            _kind = "human";
            _passivImage = Image.FromFile("InfantryFarmer.png");
            _attackImage = Image.FromFile("InfantryFarmerAttack.png");
            _image = _passivImage;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            foreach (Enemy e in Square.Context.Enemies)
            {
                if (tick % _attackSpeed == 0)
                {
                        ennemi.Health -= Damages;   
                }
            }
        }

        public override List<Square> ComputeRange()
        {
            return this.GetRange(0);
        }


        /*
        public override void Remove()
        {

        }
        */
    }
}
