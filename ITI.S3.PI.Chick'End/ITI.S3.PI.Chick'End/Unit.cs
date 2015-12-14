using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public abstract class Unit : IDie
    {
        protected int _health;

        public int Health
        {
            get { return _health;}
            set { _health = value; }
        }

        public abstract void Die();
        
        public abstract Point Position { get; }

        public abstract Square Square { get; }
    }
}
