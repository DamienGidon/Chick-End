using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public abstract class Unit : IDie
    {
        protected int _health;
        protected Image _image;
        protected Image _passivImage;
        protected Image _attackImage;
        protected int _imageWidth;
        protected int _imageHeight;
        protected string _kind;
        protected int _attackSpeed;

        public int AttackSpeed
        {
            get { return _attackSpeed; }
        }

        public int Health
        {
            get { return _health;}
            set { _health = value; }
        }

        public string Kind
        {
            get { return _kind; }
        }

        public int ImageWidth
        {
            get { return _imageWidth; }
        }

        public virtual void AttackAnimate(int tick,  int attackSpeed)
        {
            if (tick % attackSpeed >= 0 && tick % attackSpeed <= 10)
            {
                _image = _attackImage;
            }
            else
            {
                _image = _passivImage;
            }
        }

        public int ImageHeight
        {
            get { return _imageHeight; }
        }

        public Image UnitImage
        {
            get { return _image; }
        }

        public abstract void Die();
        
        public abstract Point Position { get; }

        public abstract Square Square { get; }
    }
}
