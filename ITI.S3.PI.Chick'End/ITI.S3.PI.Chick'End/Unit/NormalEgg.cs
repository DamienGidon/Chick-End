using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class NormalEgg : EggLauncher
    {

        public NormalEgg(Map context, int damage, int x, int y)
            : base(context, damage, x, y)
        {
            _image = Image.FromFile("NormalEgg.png");
            _imageWidth = 26;
            _imageHeight = 20;
        }
    }
}
