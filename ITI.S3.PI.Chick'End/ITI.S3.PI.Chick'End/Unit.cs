using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Unit : IDie
    {
        Square _context;
        internal int _health;

        public int Health
        {
            get { return _health;}
            set { _health = value; }
        }

        public void Die()
        {
            _health = 0;
            throw new NotImplementedException();  
        }
    }
}
