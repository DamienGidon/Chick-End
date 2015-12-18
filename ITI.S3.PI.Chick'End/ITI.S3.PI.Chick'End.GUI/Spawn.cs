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
            SpawnWolf();
            SpawnFox();
            SpawnAnubis();
            SpawnCerberus();
            SpawnHyena();
            SpawnLion();
        }

        public void SpawnWolf()
        {
            if(_tick % 60 == 0)
            {
                Wolf w = _map.Context.Map.CreateWolf(_map.Context.Map);

                
            }
        }

        public void SpawnFox()
        {
            if (_tick % 200 == 0)
            {
                Fox f = _map.Context.Map.CreateFox(_map.Context.Map);

                Bitmap p = new Bitmap(@"Fox.png");
                Graphics g = Graphics.FromImage(p);

                Rectangle r = new Rectangle(f.Position.X, f.Position.Y, (_map.Width / FinalVariables.NbCaseWidthMap1), (_map.Height / FinalVariables.NbCaseHeightMap1));
                PaintEventArgs e = new PaintEventArgs(_map.CreateGraphics(), r);
                e.Graphics.DrawImage(p, r);
            }
        }

        public void SpawnHyena()
        {
            if (_tick % 500 == 0)
            {
                Hyena h = _map.Context.Map.CreateHyena(_map.Context.Map);

                Bitmap p = new Bitmap(@"Hyena.png");
                Graphics g = Graphics.FromImage(p);

                Rectangle r = new Rectangle(h.Position.X, h.Position.Y, (_map.Width / FinalVariables.NbCaseWidthMap1), (_map.Height / FinalVariables.NbCaseHeightMap1) + 20);
                PaintEventArgs e = new PaintEventArgs(_map.CreateGraphics(), r);
                e.Graphics.DrawImage(p, r);
            }
        }

        public void SpawnLion()
        {
            if (_tick % 120 == 0)
            {
                Lion l = _map.Context.Map.CreateLion(_map.Context.Map);

                Bitmap p = new Bitmap(@"Hyena.png");
                Graphics g = Graphics.FromImage(p);

                Rectangle r = new Rectangle(l.Position.X, l.Position.Y, (_map.Width / FinalVariables.NbCaseWidthMap1), (_map.Height / FinalVariables.NbCaseHeightMap1) + 20);
                PaintEventArgs e = new PaintEventArgs(_map.CreateGraphics(), r);
                e.Graphics.DrawImage(p, r);
            }
        }

        public void SpawnAnubis()
        {
            if (_tick % 6000 == 0)
            {
                Anubis a = _map.Context.Map.CreateAnubis(_map.Context.Map);

                Bitmap p = new Bitmap(@"Hyena.png");
                Graphics g = Graphics.FromImage(p);

                Rectangle r = new Rectangle(a.Position.X, a.Position.Y, (_map.Width / FinalVariables.NbCaseWidthMap1), (_map.Height / FinalVariables.NbCaseHeightMap1) + 20);
                PaintEventArgs e = new PaintEventArgs(_map.CreateGraphics(), r);
                e.Graphics.DrawImage(p, r);
            }
        }

        public void SpawnCerberus()
        {
            if (_tick % 4000 == 0)
            {
                Cerberus c = _map.Context.Map.CreateCerberus(_map.Context.Map);

                Bitmap p = new Bitmap(@"Hyena.png");
                Graphics g = Graphics.FromImage(p);

                Rectangle r = new Rectangle(c.Position.X, c.Position.Y, (_map.Width / FinalVariables.NbCaseWidthMap1), (_map.Height / FinalVariables.NbCaseHeightMap1) + 20);
                PaintEventArgs e = new PaintEventArgs(_map.CreateGraphics(), r);
                e.Graphics.DrawImage(p, r);
            }
        }
    }
}
