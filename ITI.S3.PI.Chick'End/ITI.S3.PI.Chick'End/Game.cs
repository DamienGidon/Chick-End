﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Game
    {
        readonly Map _map;
        bool _isPaused;
        bool _isLost;
        HenCreater _henCreater;

        public Game()
        {
            _map = new Map();
            _henCreater = new HenCreater(_map);
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
            List<ExplosiveEgg> _explosiveEggs = new List<ExplosiveEgg>();
            foreach ( EggLauncher e in _map.Eggs)
            {
                Enemy enemy = e.GetClosestEnemyAttackable();
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

            foreach ( Enemy e in _map.Enemies)
            {
                Tower t = e.GetClosestTowerAttackable();

                if (t == null)
                {
                    if (e is Anubis && tick % e.AttackSpeed >= 0 && tick % e.AttackSpeed <= 10)
                    {
                        e.UnitImage = e.AttackImage;
                    }
                    else
                    {
                        e.Move();
                        e.MoveAnimate(tick);
                        //e.UnitImage = e.PassiveImage;
                    }
                }
                else if (t is Steak && e is Fox)
                {
                    e.Move();
                    e.MoveAnimate(tick);
                }
                else
                {
                    if (e is Hyena && t is Butcher)
                    {
                        e.Damages = 200;
                    }
                    e.Attack(t, tick);
                    e.AttackAnimate(tick, t.AttackSpeed);
                    if (t.Health <= 0)
                        t.Die();
                }
            }

            foreach( Tower t in _map.Towers)
            {
                Enemy e = t.GetClosestEnemyAttackable();
                if (e != null)
                {
                    t.Attack( e, tick );
                    t.AttackAnimate(tick, t.AttackSpeed);
                    if (e.Health <= 0)
                        e.Die();

                    if (t is ExplosiveEgg)
                    {
                        ExplosiveEgg ex = (ExplosiveEgg)t;
                        if (ex.Exploded == true)
                        {
                            _explosiveEggs.Add(ex);
                        }
                    }
                }
                else
                {
                    t.UnitImage = t.PassiveImage;
                }
            }
            foreach (ExplosiveEgg ex in _explosiveEggs)
            {
                ex.Die();
            }
        }
    }
}
