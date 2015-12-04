using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Way
    {
        Square _firstSquare;

        public Way( Square firstSquare )
        {
            _firstSquare = firstSquare;
        }

        public Square FirstSquare
        {
            get { return _firstSquare; }
        }

        public Square Next()
        {
            return _firstSquare.NextSquare;
        }
    }
}
