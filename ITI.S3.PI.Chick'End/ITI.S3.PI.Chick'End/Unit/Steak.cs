using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Steak : Tower
    {

        public Steak(Square context)
            : base( context, 0 )
        {
            _attackSpeed = 20;
            Health = 500;
            _kind = "hen";
            _image = Image.FromFile("Steak.png");
            _passivImage = Image.FromFile("Steak.png");
            _attackImage = Image.FromFile("Steak.png");
            _imageWidth = 26;
            _imageHeight = 20;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            if (tick % _attackSpeed == 0)
            {
                //ennemi.Health -= Damages;
            }
        }
    }
}
