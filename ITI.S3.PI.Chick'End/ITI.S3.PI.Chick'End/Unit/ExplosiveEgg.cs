﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class ExplosiveEgg : Tower
    {
        bool _exploded = false;

        public ExplosiveEgg(Square context)
            : base( context, 200 )
        {
            _attackSpeed = 40;
            _health = 1000;
            _passivImage = Image.FromFile("ExplosiveEgg.png");
            _attackImage = Image.FromFile("Baker.png");
            _image = _passivImage;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            foreach( Enemy e in Square.Context.Enemies)
            {
                if( (e.Square == ennemi.Square)
                    || ((e.Square.Line == ennemi.Square.Line) && (e.Square.Column == ennemi.Square.Column + 1) )
                    || ((e.Square.Line == ennemi.Square.Line) && (e.Square.Column == ennemi.Square.Column - 1) )
                    || ((e.Square.Line == ennemi.Square.Line + 1) && (e.Square.Column == ennemi.Square.Column) )
                    || ((e.Square.Line == ennemi.Square.Line - 1) && (e.Square.Column == ennemi.Square.Column) ))
                {
                    ennemi.Health -= Damages;
                    _exploded = true;
                }
            }
        }

        public bool Exploded
        {
            get { return _exploded; }
        }

        public override List<Square> ComputeRange()
        {
            List<Square> range = new List<Square>();
            range.Add( Square );
            return range;
        }
    }
}
