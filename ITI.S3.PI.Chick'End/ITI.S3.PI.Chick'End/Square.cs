﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    [Serializable]
    public class Square
    {
        readonly Map _context;
        readonly int _line;
        readonly int _column;
        readonly string _decoration;
        Tower _tower;
        Square _nextSquare;
        Ennemi _ennemi;

        public Square( Map context, int x, int y, string decoration)
        {
            _context = context;
            _decoration = decoration;
            _line = x;
            _column = y;

        }

        public int Line
        {
            get { return _line; }
        }
        public int Column
        {
            get { return _column; }
        }
        public string Decoration
        {
            get { return _decoration; }
        }

        public Tower Tower
        {
            get { return _tower; }
            set { _tower = value; }
        }

        public Ennemi Ennemi
        {
            get { return _ennemi; }
            set { _ennemi = value; }
        }

        public Square NextSquare
        {
            get { return _nextSquare; }
            set { _nextSquare = value; }
        }
    }
}
