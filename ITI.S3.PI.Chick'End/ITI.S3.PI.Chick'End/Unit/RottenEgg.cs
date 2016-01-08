using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class RottenEgg : EggLauncher
    {

        public RottenEgg(Map context, int damage, int x, int y)
            : base(context, damage, x, y)
        {
            _image = Image.FromFile("RottenEgg.png");
            _imageWidth = 26;
            _imageHeight = 20;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            Enemy _ennemi = (Enemy)ennemi;
            ennemi.Health -= Damages;
            if (_ennemi.AlreadySlow == false)
            {
                _ennemi.Speed = _ennemi.Speed * 2;
                _ennemi.AlreadySlow = true;
            }
        }
    }
}
