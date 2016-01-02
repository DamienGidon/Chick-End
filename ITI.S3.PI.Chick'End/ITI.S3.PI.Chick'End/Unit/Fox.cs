using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Fox : Ennemi
    {
        public Fox( Map context, int damages )
            : base(context, damages)
        {
            Health = 100;
            Speed = 10;
            _attackSpeed = 20;
            _passivImage = Image.FromFile("Fox.png");
            _attackImage = Image.FromFile("Fox.png");
            _image = _passivImage;
            _imageWidth = 50;
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
