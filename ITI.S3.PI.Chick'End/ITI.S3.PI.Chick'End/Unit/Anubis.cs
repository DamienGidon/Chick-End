using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Anubis : Ennemi
    {
        public Anubis( Map context, int damages )
            : base(context, damages)
        {
            Health = 500;
            Speed = 50;
            _passivImage = Image.FromFile("Anubis.png");
            _attackImage = Image.FromFile("Anubis.png");
            _image = _passivImage;
            _imageWidth = 60;
            _imageHeight = 70;
        }

        public void Summon(int tick)
        {
            if (tick % 60 == 0)
            {
                Context.CreateAnubisWolf(Square.Context, this.GetX, this.GetY);
            }
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
