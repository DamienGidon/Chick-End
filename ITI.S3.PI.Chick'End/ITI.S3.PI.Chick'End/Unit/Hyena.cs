using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Hyena : Ennemi
    {
        public Hyena( Map context, int damages )
            : base(context, damages)
        {
            Health = 50;
            Speed = 50;
            _image = Image.FromFile("Hyena.png");
            _imageWidth = 40;
            _imageHeight = 40;
        }

        //public override void Attack( Unit opponent )
        //{
        //    throw new NotImplementedException();
        //}

        //public override void Move()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
