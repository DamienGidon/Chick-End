using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Cerberus : Enemy
    {
        public Cerberus( Map context, int damages )
            : base(context, damages)
        {
            Health = 500;
            Speed = 30;
            _attackSpeed = 20;
            _passivImage = Image.FromFile("Cerberus.png");
            _attackImage = Image.FromFile("CerberusAttack.png");
            _moveImage = Image.FromFile("CerberusMove.png");

            _image = _passivImage;
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
