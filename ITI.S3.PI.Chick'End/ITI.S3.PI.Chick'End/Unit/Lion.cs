using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Lion : Ennemi
    {
        public Lion( Map context, int damages )
            : base(context, damages)
        {
            Health = 50;
            Speed = 30;
            _image = Image.FromFile("Lion.png");
            _imageWidth = 60;
            _imageHeight = 50;
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
