using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public abstract class Ennemi : Unit, IAttack, IMove
    {
        Way _way;
        int _x;
        int _y;
        int _speed;
        readonly int _damages;
        readonly float _range;
        readonly Map _context;

        Random _r;

        public Ennemi()
        {
            int numberOfWays = _context.Ways.Count();
            _way = _context.Ways[_r.Next( numberOfWays )];
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public abstract void Attack( Ennemi opposant );

        public virtual void Move()
        {

        }
    }
}