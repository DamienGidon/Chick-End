using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public abstract class Tower : Unit, IAssailant, IRemove
    {
        protected Square _square;
        internal readonly int _damages;
        protected List<Square> _range;

        protected Tower(int damages)
        {
            _damages = damages;
        }

        public Square Square
        {
            get { return _square; }
        }

        public int Damages
        {
            get { return _damages; }
        }

        internal List<Square> Range
        {
            get { return _range; }
        }

        public Ennemi GetClosestEnnemiAttackable()
        {

            return null;
        }

        public virtual void Attack( Unit ennemi )
        {

        }

        public virtual void Remove()
        {
            throw new NotImplementedException();
        }

        public abstract List<Square> GetRange();
    }
}
