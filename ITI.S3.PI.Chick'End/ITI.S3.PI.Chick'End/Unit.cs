using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    class Unit : Square, IDie
    {
        internal Point _position;
        internal int _health;

        internal int Health
        {
            get { return _health;}
            set { _health = value; }
        }


        public void Die()
        {
            throw new NotImplementedException();
        }
    }
}
