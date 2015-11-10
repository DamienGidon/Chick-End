using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Square
    {
        readonly Map _context;
        readonly int _line;
        readonly int _column;
        string _decoration;

        internal Square( Map context, int x, int y, string decoration )
        {
            _context = context;
            _decoration = decoration;
            _line = x;
            _column = y;
        }

        internal int X
        {
            get { return _line; }
        }
        internal int Y
        {
            get { return _column; }
        }
    }
}
