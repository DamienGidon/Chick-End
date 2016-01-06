using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Wolf : Ennemi
    {
        public Wolf(Map context, int damages)
            : base(context, damages)
        {
            Health = 100;
            Speed = 20;
            _attackSpeed = 20;
            _passivImage = Image.FromFile("Wolf.png");
            _attackImage = Image.FromFile("WolfAttack.png");
            _moveImage = Image.FromFile("WolfMove.png");
            _image = _passivImage;
            _imageWidth = 60;
            _imageHeight = 50;
        }

        //public override void Attack( Unit opposant )
        //{
        //    throw new NotImplementedException();
        //}

        //public override void Move()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
