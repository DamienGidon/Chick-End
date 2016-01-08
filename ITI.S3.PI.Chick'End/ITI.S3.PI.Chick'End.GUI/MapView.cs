using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End.GUI
{
    class MapView
    {
        readonly Map _context;
        Rectangle _viewMap;

        public MapView(Map map)
        {
            _context = map;
        }

        internal Map Map
        {
            get { return _context; }
        }

        internal Rectangle Area
        {
            get { return _viewMap; }
        }
    }
}
