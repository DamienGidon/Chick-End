using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Werewolf : Enemy
    {
        public Werewolf(Map context, int damages)
            : base(context, damages)
        {
            Health = 1500;
            Speed = 30;
            _attackSpeed = 20;
            _passivImage = Image.FromFile("Werewolf.png");
            _attackImage = Image.FromFile("WerewolfAttack.png");
            _moveImage = Image.FromFile("WerewolfMove.png");
            _image = _passivImage;
            _imageWidth = 80;
            _imageHeight = 70;
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

