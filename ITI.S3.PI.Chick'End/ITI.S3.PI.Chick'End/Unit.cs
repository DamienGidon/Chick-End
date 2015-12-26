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
        protected int _imageWidth;
        protected int _imageHeight;
        protected string _kind;

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

        public Image UnitImage
        {
            get { return _image; }
        }

        public abstract void Die();
        
        public abstract Point Position { get; }

        public abstract Square Square { get; }
    }
}
