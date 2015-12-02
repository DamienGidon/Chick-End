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
        readonly Map _context;
        readonly Stopwatch _stopwatch;
        bool _isPaused;

        public Game()
        {
            _context = new Map();
            _stopwatch = new Stopwatch();
        }

        public Map Context
        {
            get { return _context; }
        }

        public Stopwatch Stopwatch
        {
            get { return _stopwatch; }
        }

        public bool IsPosed
        {
            get { return _isPaused; }
            set { _isPaused = value; }
        }

        public void Update()
        {
            //foreach( )
        }
    }
}
