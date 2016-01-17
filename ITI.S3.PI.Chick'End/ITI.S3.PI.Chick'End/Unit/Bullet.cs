using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Bullet : EggLauncher
    {
        public Bullet(Map context, Square[] towerRange, int damage, int x, int y)
            : base(context, towerRange, damage, x, y)
        {
            _image = Image.FromFile("bullet.png");
            _imageWidth = 26;
            _imageHeight = 20;
        }
    }
}
