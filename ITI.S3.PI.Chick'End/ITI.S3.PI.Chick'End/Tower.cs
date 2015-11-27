using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public abstract class Tower : Unit, IAssailant, IRemove
    {
        internal readonly int _damages;
        internal readonly float _range;

        protected Tower(int damages, int range)
        {
            _damages = damages;
            _range = range;
        }

        public int Damages
        {
            get { return _damages; }
        }

        internal float Range
        {
            get { return _range; }
        }

        public virtual void Attack( Unit ennemi )
        {

        }

        public virtual void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
