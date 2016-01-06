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
        Game _game;

        public Spawn( int tick, Game Context )
        {
            _tick = tick;
            _game = Context;
            SpawnAll();
            SpawnFromAnubis();
            SpawnSteak();
        }

        public void SpawnAll()
        {
            if (_tick % 60 == 0)
            {
                Wolf w = _game.Map.CreateWolf( _game.Map );
            }

            if (_tick % 200 == 0)
            {
                Fox f = _game.Map.CreateFox( _game.Map );
            }

            if (_tick % 500 == 0)
            {
                Hyena h = _game.Map.CreateHyena( _game.Map );
            }

            if (_tick % 120 == 0)
            {
                Lion l = _game.Map.CreateLion( _game.Map );
            }

            if (_tick % 3000 == 0)
            {
                Anubis a = _game.Map.CreateAnubis( _game.Map );
            }

            if (_tick % 4000 == 0)
            {
                Cerberus c = _game.Map.CreateCerberus( _game.Map );
            }
        }

        public void SpawnFromAnubis()
        {
            List<Anubis> _anubis = new List<Anubis>();
            foreach( Ennemi e in _game.Map.Ennemis)
            {
                if (e is Anubis)
                {
                    Anubis i = (Anubis) e;
                    _anubis.Add(i);
                }
            }

            foreach(Anubis a in _anubis)
            {
                a.Summon(_tick);
            }
        }

        public void SpawnSteak()
        {
            List<Bucher> _butchers = new List<Bucher>();
            foreach (Tower t in _game.Map.Towers)
            {
                if (t is Bucher)
                {
                    Bucher i = (Bucher)t;
                    _butchers.Add(i);
                }
            }

            foreach (Bucher a in _butchers)
            {
                a.Summon(_tick);
            }
        }
    }
}