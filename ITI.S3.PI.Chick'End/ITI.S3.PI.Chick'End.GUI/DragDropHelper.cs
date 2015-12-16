using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End.GUI
{
    class DragDropHelper
    {
        int _xTower;
        int _yTower;

        int _xCase;
        int _yCase;

        Bitmap _tower;

        public DragDropHelper(int xTower, int yTower, Bitmap _tower)
        {
            _xTower = xTower;
            _yTower = yTower;
        }

        public DragDropHelper(int xCase, int yCase)
        {
            _xCase = xCase;
            _yCase = yCase;
        }

        public void Drag()
        {

        }
    }
}
