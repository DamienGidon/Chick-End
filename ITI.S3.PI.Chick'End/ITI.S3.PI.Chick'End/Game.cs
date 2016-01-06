using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Game
    {
        readonly Map _map;
        [NonSerialized]
        readonly Stopwatch _stopwatch;
        bool _isPaused;
        bool _isLost;
        HenCreater _henCreater;

        public Game()
        {
            _map = new Map();
            _henCreater = new HenCreater(_map);
            _stopwatch = new Stopwatch();
        }
        public Game(string test)
        {
            _map = new Map(test);
            _stopwatch = new Stopwatch();
        }

        public Map Map
        {
            get { return _map; }
        }

        public Stopwatch Stopwatch
        {
            get { return _stopwatch; }
        }

        public HenCreater HenCreater
        {
            get { return _henCreater; }
        }

        public bool IsPosed
        {
            get { return _isPaused; }
            set { _isPaused = value; }
        }

        public bool IsLost
        {
            get { return _isLost; }
            set { _isLost = value; }
        }

        public void Update(int tick)
        {
            List<EggLauncher> _eggLaunchers = new List<EggLauncher>();
            foreach ( EggLauncher e in _map.Eggs)
            {
                Ennemi enemy = e.GetClosestEnnemiAttackable();
                if (enemy == null)
                {
                    if(e.Position.X < (FinalVariables.MapWidthInMeters - 35))
                    {
                        e.Move();
                    }
                    else
                    {
                        _eggLaunchers.Add(e);
                    }
                }
                else
                {
                    e.Attack(enemy, tick);
                    _eggLaunchers.Add(e);
                }
            }
            foreach (EggLauncher egg in _eggLaunchers)
            {
                egg.Die();
            }

            foreach ( Ennemi e in _map.Ennemis)
            {
                Tower t = e.GetClosestTowerAttackable();
                if (t == null)
                {
                    e.Move();
                    e.MoveAnimate(tick);
                }
                else if (t is Bucher && e is Fox)
                {
                    e.Move();
                    e.MoveAnimate(tick);
                }
                else
                {
                    if(e is Hyena && t is Bucher)
                    {
                        e.Damages = 200;
                    }
                    e.Attack( t, tick );
                    e.AttackAnimate(tick, t.AttackSpeed);
                    if (t.Health <= 0)
                        t.Die();
                }
            }

            foreach( Tower t in _map.Towers)
            {
                Ennemi e = t.GetClosestEnnemiAttackable();
                if (e != null)
                {
                    t.Attack( e, tick );
                    t.AttackAnimate(tick, t.AttackSpeed);
                    if (e.Health <= 0)
                        e.Die();
                }
            }
        }
    }
}
