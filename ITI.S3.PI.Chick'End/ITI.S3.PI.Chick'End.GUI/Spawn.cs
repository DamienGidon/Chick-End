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
            SpawnAll();
        }

        public void SpawnAll()
        {
            if (_tick % 60 == 0)
            {
                Wolf w = _map.Context.Map.CreateWolf(_map.Context.Map);
            }

            if (_tick % 200 == 0)
            {
                Fox f = _map.Context.Map.CreateFox(_map.Context.Map);
            }

            if (_tick % 500 == 0)
            {
                Hyena h = _map.Context.Map.CreateHyena(_map.Context.Map);
            }

            if (_tick % 120 == 0)
            {
                Lion l = _map.Context.Map.CreateLion(_map.Context.Map);
            }

            if (_tick % 6000 == 0)
            {
                Anubis a = _map.Context.Map.CreateAnubis(_map.Context.Map);
            }

            if (_tick % 4000 == 0)
            {
                Cerberus c = _map.Context.Map.CreateCerberus(_map.Context.Map);
            }
        }
    }
}
