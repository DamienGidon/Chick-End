using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ITI.S3.PI.Chick_End
{
    public class Game
    {
        Map _context;
        Stopwatch _stopwatch;

        public Game()
        {
            _context = new Map();
            _stopwatch = new Stopwatch();
        }

        public Map Map
        {
            get { return _context; }
        }

        public Stopwatch Stopwatch
        {
            get { return _stopwatch; }
        }
    }
}
