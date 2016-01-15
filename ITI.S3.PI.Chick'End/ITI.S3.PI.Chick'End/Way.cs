using System;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
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

        public Square NextSquare()
        {
            return _current = _current.NextSquare;
        }
    }
}
