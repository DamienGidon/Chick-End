using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Game
    {
        Map _context;

        public Game()
        {
            _context = new Map();
        }

        public Map Map
        {
            get { return _context; }
        }
    }
}
