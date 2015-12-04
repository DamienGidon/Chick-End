using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Wolf : Ennemi
    {
        public Wolf(Map context)
            : base()
        {
            _context = context;
            int numberOfWays = _context.Ways.Count();
            _way = _context.Ways[_r.Next(numberOfWays)];
            _x = _way.FirstSquare.Column * 50 + 30;
            _y = _way.FirstSquare.Line * 50 + 30;
            Health = 50;
            Speed = 50;
        }

        public override void Attack( Unit opposant )
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
