using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public abstract class Ennemi : Unit, IAssailant, IMove
    {
        protected Way _way;
        protected int _x;
        protected int _y;
        protected int _speed;
        protected readonly int _damages;
        protected readonly float _range;
        public Map _context;

        protected static Random _r = new Random();

        public Ennemi()
        {
            
        }

        public Map Context
        {
            get { return _context; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        {
            get { return _y; }
        }

        public virtual void Move()
        {
            _x = _x - 50;
        }

        public virtual void Attack( Unit ennemi )
        {

        }
    }
}