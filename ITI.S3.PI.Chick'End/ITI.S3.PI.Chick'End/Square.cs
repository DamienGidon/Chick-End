using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    internal class Square
    {
        Placeable _ally;
        List<Unit> _units;
        string _decoration;

        internal Square( string decoration )
        {
            _decoration = decoration;
        }
    }
}
