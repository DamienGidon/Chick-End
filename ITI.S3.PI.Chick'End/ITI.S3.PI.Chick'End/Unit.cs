using System;
using System.Drawing;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public abstract class Unit : IDie
    {
        protected bool _upgrade;
        protected int _health;
        protected Image _image;
        protected Image _passivImage;
        protected Image _attackImage;
        protected Image _moveImage;
        protected Image _upgradeImage;
        protected Image _attackUpgradeImage;
        protected int _imageWidth;
        protected int _imageHeight;
        protected string _kind;
        protected int _attackSpeed;

        public int AttackSpeed
        {
            get { return _attackSpeed; }
        }

        public void Upgrade()
        {
            _upgrade = true;
            _passivImage =_image = _upgradeImage;
            _attackSpeed = Convert.ToInt32(_attackSpeed / 1.5);
        }

        public Image PassiveImage
        {
            get { return _passivImage; }
        }
        public Image AttackImage
        {
            get { return _attackImage; }
        }
        public Image UnitImage
        {
            get { return _image; }
            set { _image = value; }
        }

        public bool AlreadyUp
        {
            get { return _upgrade; }
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
        public int ImageHeight
        {
            get { return _imageHeight; }
        }

        public virtual void AttackAnimate(int tick,  int attackSpeed)
        {
            if (tick % attackSpeed >= 0 && tick % attackSpeed <= 10)
            {
                if (_upgrade == true)
                {
                    _image = _attackUpgradeImage;
                }
                else
                {
                    _image = _attackImage;
                }
            }
            else
            {
                if (_upgrade == true)
                {
                    _image = _upgradeImage;
                }
                else
                {
                    _image = _passivImage;
                }
            }
        }

        public virtual void MoveAnimate(int tick)
        {
            if (tick % 13 >= 0 && tick % 13 <= 7)
            {
                _image = _moveImage;
            }
            else
            {
                _image = _passivImage;
            }
        }
        
        public abstract void Die();
        
        public abstract Point Position { get; }

        public abstract Square Square { get; }
    }
}
