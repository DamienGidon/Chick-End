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
            _health = 100;
            _kind = "human";
            _image = Image.FromFile("Butcher.png");
            _passivImage = Image.FromFile("Butcher.png");
            _attackImage = Image.FromFile("Butcher.png");
        }

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % 20 == 0)
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
