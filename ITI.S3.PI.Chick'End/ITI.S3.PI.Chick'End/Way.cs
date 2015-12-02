using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Way
    {
        Square _firstSquare;
        Square _current;

        public Way( Square firstSquare )
        {
            _firstSquare = firstSquare;
            _current = firstSquare;
        }

        public Square FirstSquare
        {
            get { return _firstSquare; }
        }

        public Square Current
        {
            get { return _current; }
        }

        public Square Next
        {
            get { return _current.NextSquare; }
        }        

        public void NextSquare()
        {
            _current = _current.NextSquare;
        }
    }
}
