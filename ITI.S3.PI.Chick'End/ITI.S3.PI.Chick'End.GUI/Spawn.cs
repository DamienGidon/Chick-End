using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ITI.S3.PI.Chick_End.GUI
{
    class Spawn
    {
        int _tick;
        ViewMapControler _map;

        public Spawn(int tick, ViewMapControler Context)
        {
            _tick = tick;
            _map = Context;
        }

        public void SpawnWolf()
        {
            if(_tick % 60 == 0)
            {
                Wolf w = _map.Context.Map.CreateWolf(_map.Context.Map);

                Bitmap p = new Bitmap(@"Wolf.png");
                Graphics g = Graphics.FromImage(p);

                Rectangle r = new Rectangle(w.Position.X, w.Position.Y, (_map.Width / FinalVariables.NbCaseWidthMap1), (_map.Height / FinalVariables.NbCaseHeightMap1) + 20);
                PaintEventArgs e = new PaintEventArgs(_map.CreateGraphics(), r);
                e.Graphics.DrawImage(p, r);
            }
        }

        public void SpawnFox()
        {
            if (_tick % 100 == 0)
            {
                Fox f = _map.Context.Map.CreateFox(_map.Context.Map);

                Bitmap p = new Bitmap(@"Fox.png");
                Graphics g = Graphics.FromImage(p);

                Rectangle r = new Rectangle(f.Position.X, f.Position.Y, (_map.Width / FinalVariables.NbCaseWidthMap1), (_map.Height / FinalVariables.NbCaseHeightMap1) + 20);
                PaintEventArgs e = new PaintEventArgs(_map.CreateGraphics(), r);
                e.Graphics.DrawImage(p, r);
            }
        }
    }
}
