using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Bucher : Tower
    {
        internal Bucher(Square context)
            : base( context, 15 )
        {
            _attackSpeed = 20;
            _health = 400;
            _kind = "human";
            _passivImage = Image.FromFile("Butcher.png");
            _attackImage = Image.FromFile("Butcher.png");
            _image = _passivImage;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % _attackSpeed == 0)
            {
                ennemi.Health -= Damages;
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
