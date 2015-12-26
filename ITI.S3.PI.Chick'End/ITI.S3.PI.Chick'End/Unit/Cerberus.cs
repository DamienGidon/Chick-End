using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Cerberus : Ennemi
    {
        public Cerberus( Map context, int damages )
            : base(context, damages)
        {
            Health = 1000;
            Speed = 50;
            _image = Image.FromFile("Cerberus.png");
            _imageWidth = 80;
            _imageHeight = 70;
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
