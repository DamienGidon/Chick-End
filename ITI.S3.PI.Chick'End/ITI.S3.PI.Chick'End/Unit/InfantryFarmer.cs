﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class InfantryFarmer : Tower
    {
        internal InfantryFarmer( Square context )
            : base( context, 30 )
        {
            _attackSpeed = 20;
            _health = 5000;
            _kind = "human";
            _passivImage = Image.FromFile("InfantryFarmer.png");
            _attackImage = Image.FromFile("InfantryFarmer.png");
            _image = _passivImage;
        }

        public override void Attack(Unit ennemi, int tick)
        {
            foreach (Ennemi e in Square.Context.Ennemis)
            {
                if (tick % _attackSpeed == 0)
                {
                    if ((e.Square == ennemi.Square)
                        || ((e.Square.Line == ennemi.Square.Line) && (e.Square.Column == ennemi.Square.Column + 1)))
                    {
                        ennemi.Health -= Damages;
                    }
                }
            }
        }

        public override void CreateTower( int line, int column, Map map )
        {
            throw new NotImplementedException();
        }

        //public override List<Square> GetRange()
        //{
        //    throw new NotImplementedException();
        //}

        /*
        public override void Remove()
        {

        }
        */
    }
}
