using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Map
    {
        readonly Dictionary<string, Tower> _towers;
        readonly Dictionary<string, Ennemi> _ennemis;
        List<Unit> AllUnits
        {
            get
            {
                List<Unit> units = new List<Unit>();
                foreach (Tower tower in _towers.Values) units.Add(tower);
                foreach (Ennemi ennemi in _ennemis.Values) units.Add(ennemi);

                return units;
            }
        }
        Square[,] _squares;
        /*
         * Constructor
         */
        internal Map()
        {
            Square[,] _squares = new Square[8,13];

            // Setting the hen house
            for( int i = 3; i < 6; i++)
            {
                int j = 0;
                _squares[i, j] = new Square(this, i, j, "hen home" );
            }
            // Setting the other decorations
            for( int i = 0; i < 9; i++)
            {
                // Setting the trees
                if( i < 3 || i > 5)
                {
                    for( int j = 0; j < 14; j++)
                    {
                        _squares[i, j] = new Square( this, i, j, "tree" );
                    }
                }
                else if( i == 4)
                {
                    for( int j = 1; j < 14; j++)
                    {
                        _squares[i, j] = new Square( this, i, j, "tree" );
                    }
                }
                // Setting the paths
                if( i == 3 || i == 5)
                {
                    for( int j = 1; j < 14; j++)
                    {
                        _squares[i, j] = new Square( this, i, j, "path" );
                    }
                }
            }
        }

        internal Square GetSquare(int y, int x)
        {
            return _squares[x, y];
        }
        /*
        public void PutHen(int y, int x )
        {
            if (GetSquare( y, x ).Ally != null)
                throw new ArgumentException();
            else
                GetSquare( y, x ).Ally = new Hen();
        }
        */
    }
}